function resizeTextToFit(container) {
    const containerWidth = container.clientWidth;
    let fontSize = 60; // Tamanho inicial da fonte
    container.style.fontSize = `${fontSize}px`;

    while (container.scrollWidth > containerWidth && fontSize > 0) {
      fontSize -= 0.8; // Ajusta o tamanho da fonte
      container.style.fontSize = `${fontSize}px`;
    }
  }

  const textContainer = document.getElementById('n-album');
  resizeTextToFit(textContainer);