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
const cardContainer = document.querySelector('.carousel-track');
const prevBtn = document.getElementById('prevBtn');
const nextBtn = document.getElementById('nextBtn');

const cardWidth = 192 + 2.2; // Largura do card + margem
const cardsPerView = 6; // Total de cards visíveis
const totalCards = 12; // Total fixo de cards
const totalSteps = totalCards / cardsPerView; // Total de movimentos possíveis (2 no caso de 12 cards)

let currentPosition = 0;

function updatePosition() {
    // Calcula o deslocamento em pixels
    const translateXValue = -(currentPosition * cardsPerView * cardWidth);

    // Aplica o deslocamento ao contêiner
    cardContainer.style.transform = `translateX(${translateXValue}px)`;

    // Gerencia a visibilidade dos botões
    prevBtn.disabled = currentPosition === 0;
    nextBtn.disabled = currentPosition === totalSteps - 1;
}

// Eventos de clique nos botões
prevBtn.addEventListener('click', () => {
    if (currentPosition > 0) {
        currentPosition--;
        updatePosition();
    }
});

nextBtn.addEventListener('click', () => {
    if (currentPosition < totalSteps - 1) {
        currentPosition++;
        updatePosition();
    }
});

// Inicializa o estado do carrossel
updatePosition();
