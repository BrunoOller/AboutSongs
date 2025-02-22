let comments = [
    {
        id: 1,
        userId: 1,
        name: "Usuário 1",
        text: "Ótimo conteúdo, parabéns!",
        likes: 0,
        dislikes: 0,
        liked: false,
        disliked: false,
        replies: [],
    },
    {
        id: 2,
        userId: 2,
        name: "Usuário 2",
        text: "Muito interessante, gostei bastante.",
        likes: 0,
        dislikes: 0,
        liked: false,
        disliked: false,
        replies: [],
    },
    {
        id: 3,
        userId: 1,
        name: "Usuário 1",
        text: "Outro comentário de exemplo.",
        likes: 0,
        dislikes: 0,
        liked: false,
        disliked: false,
        replies: [],
    },
    {
        id: 4,
        userId: 2,
        name: "Usuário 2",
        text: "Gostei muito desse artigo.",
        likes: 0,
        dislikes: 0,
        liked: false,
        disliked: false,
        replies: [],
    },
    // Adicione mais comentários para simular um cenário maior
];

const COMMENTS_LIMIT = 3; // Limite de comentários exibidos inicialmente
let displayedComments = COMMENTS_LIMIT;
const loggedInUserId = 1; // ID do usuário logado

function displayComments() {
    const commentsContainer = document.getElementById("commentsContainer");
    commentsContainer.innerHTML = "";

    // Exibe apenas os comentários até o limite
    const visibleComments = comments.slice(0, displayedComments);

    visibleComments.forEach(comment => {
        const commentElement = document.createElement("div");
        commentElement.className = "comment";

        const avatar = document.createElement("img");
        avatar.src = "https://via.placeholder.com/40";
        avatar.alt = comment.name;
        avatar.className = "comment-avatar";

        const content = document.createElement("div");
        content.className = "comment-content";

        const name = document.createElement("div");
        name.className = "comment-name";
        name.textContent = comment.name;

        const text = document.createElement("div");
        text.className = "comment-text";
        text.textContent = comment.text;

        const actions = document.createElement("div");
        actions.className = "comment-actions";

        const likeBtn = document.createElement("span");
        likeBtn.className = `like ${comment.liked ? "clicked" : ""}`;
        likeBtn.innerHTML = `<i class="fas fa-thumbs-up"></i> ${comment.likes}`;
        likeBtn.onclick = () => toggleLike(comment);

        const dislikeBtn = document.createElement("span");
        dislikeBtn.className = `dislike ${comment.disliked ? "clicked" : ""}`;
        dislikeBtn.innerHTML = `<i class="fas fa-thumbs-down"></i> ${comment.dislikes}`;
        dislikeBtn.onclick = () => toggleDislike(comment);

        const editBtn = document.createElement("span");
        editBtn.innerHTML = `<i class="fas fa-edit"></i> Editar`;
        editBtn.onclick = () => {
            if (comment.userId === loggedInUserId) {
                openEditModal(comment);
            } else {
                alert("Você não pode editar este comentário.");
            }
        };

        const deleteBtn = document.createElement("span");
        deleteBtn.innerHTML = `<i class="fas fa-trash-alt"></i> Excluir`;
        deleteBtn.onclick = () => {
            if (comment.userId === loggedInUserId) {
                openDeleteModal(comment.id);
            } else {
                alert("Você não pode excluir este comentário.");
            }
        };

        const replyBtn = document.createElement("span");
        replyBtn.innerHTML = `<i class="fas fa-reply"></i> Responder`;
        replyBtn.onclick = () => openReplyModal(comment.id);

        actions.append(likeBtn, dislikeBtn, editBtn, deleteBtn, replyBtn);
        content.append(name, text, actions);
        commentElement.append(avatar, content);

        if (comment.replies.length > 0) {
            const repliesContainer = document.createElement("div");
            repliesContainer.className = "replies";
            comment.replies.forEach(reply => {
                const replyElement = document.createElement("div");
                replyElement.className = "comment reply";

                const replyText = document.createElement("div");
                replyText.className = "comment-text";
                replyText.textContent = reply.text;

                repliesContainer.append(replyElement);
            });
            commentElement.append(repliesContainer);
        }

        commentsContainer.append(commentElement);
    });

    // Se o número de comentários exibidos for menor que o total, exibe o botão "Ver mais"
    if (displayedComments < comments.length) {
        const viewMoreButton = document.createElement("button");
        viewMoreButton.textContent = "Ver mais";
        viewMoreButton.className = "view-more-btn";
        viewMoreButton.onclick = loadMoreComments;
        commentsContainer.append(viewMoreButton);
    }
}

function loadMoreComments() {
    displayedComments += COMMENTS_LIMIT; // Aumenta o número de comentários exibidos
    displayComments(); // Atualiza a lista de comentários
}

function postComment() {
    const newCommentText = document.getElementById("newComment").value;
    const newComment = {
        id: comments.length + 1,
        userId: loggedInUserId,
        name: "Novo Usuário",
        text: newCommentText,
        likes: 0,
        dislikes: 0,
        liked: false,
        disliked: false,
        replies: [],
    };
    comments.push(newComment);
    displayComments();
}

function toggleLike(comment) {
    if (comment.liked) {
        comment.likes--;
    } else {
        comment.likes++;
        if (comment.disliked) {
            comment.dislikes--;
            comment.disliked = false;
        }
    }
    comment.liked = !comment.liked;
    displayComments();
}

function toggleDislike(comment) {
    if (comment.disliked) {
        comment.dislikes--;
    } else {
        comment.dislikes++;
        if (comment.liked) {
            comment.likes--;
            comment.liked = false;
        }
    }
    comment.disliked = !comment.disliked;
    displayComments();
}

function openEditModal(comment) {
    editCommentId = comment.id;
    document.getElementById("editCommentText").value = comment.text;
    document.getElementById("editModal").style.display = "flex";
}

function saveEdit() {
    const editedText = document.getElementById("editCommentText").value;
    comments = comments.map(comment =>
        comment.id === editCommentId ? { ...comment, text: editedText } : comment
    );
    displayComments();
    closeModal();
}

function openDeleteModal(commentId) {
    editCommentId = commentId;
    document.getElementById("confirmDeleteModal").style.display = "flex";
}

function confirmDelete() {
    comments = comments.filter(comment => comment.id !== editCommentId);
    displayComments();
    closeModal();
}

function openReplyModal(commentId) {
    const replyText = prompt("Escreva sua resposta:");
    if (replyText) {
        const comment = comments.find(c => c.id === commentId);
        comment.replies.push({
            id: comment.replies.length + 1,
            text: replyText,
        });
        displayComments();
    }
}

function closeModal() {
    document.getElementById("editModal").style.display = "none";
    document.getElementById("confirmDeleteModal").style.display = "none";
    editCommentId = null;
}

document.addEventListener("DOMContentLoaded", displayComments);
