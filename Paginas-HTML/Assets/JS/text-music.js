window.addEventListener('load', adjustFontSize);
window.addEventListener('resize', adjustFontSize);

function adjustFontSize() {
    const songName = document.getElementById('name-song');
    let fontSize = 60; // Tamanho inicial da fonte
    songName.style.fontSize = `${fontSize}px`;

    // Reduz o tamanho da fonte enquanto o título não caber na largura
    while (songName.scrollWidth > songName.offsetWidth && fontSize > 10) {
        fontSize--;
        songName.style.fontSize = `${fontSize}px`;
    }
}