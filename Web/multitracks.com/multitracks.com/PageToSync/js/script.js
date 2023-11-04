var parentContainer = document.querySelector('.read-more-container');

parentContainer.addEventListener('click', event => {

    var current = event.target;

    var isReadMoreBtn = current.className.includes('read-more-btn');

    if (!isReadMoreBtn) return;

    var currentText = event.target.parentNode.querySelector('.read-more-text');

    currentText.classList.toggle('read-more-text--show');

    current.textContent = current.textContent.includes('Read More') ? "Read Less..." : "Read More...";

})