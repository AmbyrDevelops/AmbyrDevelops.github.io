function initializeNavbarCollapse() {
    // Ensure the navbar collapses when a link is clicked
    document.addEventListener('DOMContentLoaded', function () {
        const navLinks = document.querySelectorAll('.nav-link'); // Select all nav links
        const navbarCollapse = document.querySelector('.navbar-collapse'); // Select the collapse element

        navLinks.forEach(link => {
            link.addEventListener('click', () => {
                if (navbarCollapse.classList.contains('show')) {
                    // Close the navbar collapse
                    new bootstrap.Collapse(navbarCollapse).toggle();
                }
            });
        });
    });
}
