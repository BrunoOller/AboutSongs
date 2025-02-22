// Botão de voltar ao topo
window.onscroll = function() {
    toggleTopButton();
};

function toggleTopButton() {
    const topButton = document.getElementById("topButton");
    if (document.body.scrollTop > 200 || document.documentElement.scrollTop > 200) {
        topButton.style.display = "block";
    } else {
        topButton.style.display = "none";
    }
}

function scrollToTop() {
    window.scrollTo({
        top: 0,
        behavior: "smooth"
    });
}