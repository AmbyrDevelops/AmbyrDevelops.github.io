function initializeNavbarCollapse() {
    // Ensure the navbar collapses when a link is clicked
    document.addEventListener('DOMContentLoaded', function () {
        const navLinks = document.querySelectorAll('.nav-link'); // Select all nav links
        const navbarCollapse = document.querySelector('.navbar-collapse'); // Select the collapse element

        // Show/hide functionality for the button
        if (toggleButton && navbarCollapse) {
            toggleButton.addEventListener('click', () => {
                if (navbarCollapse.classList.contains('show')) {
                    // Close the navbar
                    navbarCollapse.classList.remove('show');
                } else {
                    // Open the navbar
                    navbarCollapse.classList.add('show');
                }
            });
        }

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

// Call the function to initialize functionality
initializeNavbarCollapse();
