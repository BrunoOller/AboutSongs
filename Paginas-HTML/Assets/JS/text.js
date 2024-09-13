window.addEventListener('load', adjustFontSize);
window.addEventListener('resize', adjustFontSize);

function adjustFontSize() {
    const albumName = document.getElementById('name-album');
    let fontSize = 60; // Tamanho inicial da fonte
    albumName.style.fontSize = `${fontSize}px`;

    // Reduz o tamanho da fonte enquanto o título não caber na largura
    while (albumName.scrollWidth > albumName.offsetWidth && fontSize > 10) {
        fontSize--;
        albumName.style.fontSize = `${fontSize}px`;
    }
}