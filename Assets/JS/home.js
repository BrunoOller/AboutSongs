document.addEventListener('DOMContentLoaded', function() {
    var header = document.querySelector('.cabecalho');
    var lastScrollTop = 0;

    window.addEventListener('scroll', function() {
        var currentScroll = window.pageYOffset || document.documentElement.scrollTop;

        if (currentScroll > lastScrollTop && currentScroll > header.offsetHeight) {
            // Rolando para baixo e já passou da altura do header
            header.classList.add('hidden');
        } else if (currentScroll < lastScrollTop) {
            // Rolando para cima
            header.classList.remove('hidden');
        }

        // Atualiza a posição de rolagem
        lastScrollTop = currentScroll <= 0 ? 0 : currentScroll;
    });
});