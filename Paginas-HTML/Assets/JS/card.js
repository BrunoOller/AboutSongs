const cardContainer = document.querySelector('.card-container');
const prevBtn = document.getElementById('prevBtn');
const nextBtn = document.getElementById('nextBtn');

let currentPosition = 0;
const cardsPerView = 5;
const cardWidth = 260; // Largura do card + margem
const totalCards = document.querySelectorAll('.card').length;

function updatePosition() {
    // Cálculo da posição máxima considerando todos os cards
    const maxPosition = Math.max(0, totalCards - cardsPerView);
    const offset = Math.min(currentPosition * cardsPerView, maxPosition);
    const translateXValue = -offset * cardWidth;

    cardContainer.style.transform = `translateX(${translateXValue}px)`;

    // Desabilitar botões conforme a posição atual
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

updatePosition(); // Inicializa a posição correta dos botões
