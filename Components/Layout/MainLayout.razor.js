export function initializeScrollEffect() {
    window.addEventListener('scroll', function () {
        const header = document.querySelector('.header');
        if (window.scrollY > 0) {
            header.classList.add('fixed-header');
        } else {
            header.classList.remove('fixed-header');
        }
    });
}
