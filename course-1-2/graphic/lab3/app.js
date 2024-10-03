tippy('.a-part', {
    content(reference) {
        return `<div class="center">
                    <b>${reference.getAttribute('data-title')}</b><br><br>
                    ${reference.getAttribute('data-description')}</div>
        `;
    },
    allowHTML: true,
});