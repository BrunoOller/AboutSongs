// Exibir o botão ao rolar a página
window.onscroll = function() {
    toggleTopButton();
};

function toggleTopButton() {
    const topButton = document.getElementById("topButton");
    if (document.body.scrollTop > 200 || document.documentElement.scrollTop > 200) {
        topButton.style.display = "block"; // Mostra o botão
    } else {
        topButton.style.display = "none"; // Oculta o botão
    }
}

// Função para rolar ao topo
function scrollToTop() {
    window.scrollTo({
        top: 0,
        behavior: "smooth"
    });
}