function adjustAlbumTitleFontSize() {
  const title = document.getElementById('name-album');
  const maxFontSize = 60; // Máximo de 60px
  const minFontSize = 24; // Mínimo de 24px
  const screenWidth = window.innerWidth;
  const newFontSize = Math.max(minFontSize, Math.min(maxFontSize, screenWidth / 20)); // Ajuste conforme necessário

  title.style.fontSize = `${newFontSize}px`;
}

// Chama a função ao carregar a página e ao redimensionar a janela
window.addEventListener('load', adjustAlbumTitleFontSize);
window.addEventListener('resize', adjustAlbumTitleFontSize);