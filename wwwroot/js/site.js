function scrollToElement(elementId) {
    var element = document.getElementById(elementId);
    if (element) {
        element.scrollIntoView({ behavior: 'smooth', block: 'center' });
    }
}

let previousClickedButton = null;

window.addEventListener('click', function (event) {
    const clickedElement = event.target;
    const isEntryButton = clickedElement.closest('.entry-button');
    const isEditForm = clickedElement.closest('form');

    if (isEntryButton) {
        if (previousClickedButton !== isEntryButton) {
            previousClickedButton = isEntryButton;
        }
    } else if (!isEditForm) {
        if (previousClickedButton !== null) {
            DotNet.invokeMethodAsync('EduVerse', 'DeselectEntry')
                .then(() => console.log('DeselectEntry invoked successfully'))
                .catch(err => console.error('Error invoking DeselectEntry:', err));
            previousClickedButton = null;
        }
    }
});



function openPdfInNewTab(pdfDataUrl) {
    var win = window.open();
    win.document.write('<iframe src="' + pdfDataUrl + '" frameborder="0" style="border:0; top:0; left:0; bottom:0; right:0; width:100%; height:100%;" allowfullscreen></iframe>');
}
    function scrollToElement(elementId) {
        var element = document.getElementById(elementId);
    if (element) {
        element.scrollIntoView({ behavior: 'smooth', block: 'center' });
        }
    }
