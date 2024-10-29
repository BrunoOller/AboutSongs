// Animação de scroll
const myObserver = new IntersectionObserver((entries) => {
    entries.forEach( (entry) => {
        if (entry.isIntersecting) {
            entry.target.classList.add('show')
        } else {
            entry.target.classList.remove('show')
        }
    })
})

const elements = document.querySelectorAll('.hidden')

elements.forEach((element) => myObserver.observe(element))

// Script para diminuir a fonte caso o texto ultrapasse o tamanho máximo
// Álbum
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

// Músicas
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

// Carrossel de cards
const cardContainer = document.querySelector('.card-container');
const prevBtn = document.getElementById('prevBtn');
const nextBtn = document.getElementById('nextBtn');

let currentPosition = 0;
const cardsPerView = 5;
const cardWidth = 260;
const totalCards = document.querySelectorAll('.card').length;

function updatePosition() {
    const maxPosition = Math.max(0, totalCards - cardsPerView);
    const offset = Math.min(currentPosition * cardsPerView, maxPosition);
    const translateXValue = -offset * cardWidth;

    cardContainer.style.transform = `translateX(${translateXValue}px)`;

    prevBtn.disabled = currentPosition === 0;
    nextBtn.disabled = offset >= maxPosition;
}

prevBtn.addEventListener('click', () => {
    if (currentPosition > 0) {
        currentPosition--;
        updatePosition();
    }
});

nextBtn.addEventListener('click', () => {
    if ((currentPosition + 1) * cardsPerView < totalCards) {
        currentPosition++;
        updatePosition();
    }
});

updatePosition();