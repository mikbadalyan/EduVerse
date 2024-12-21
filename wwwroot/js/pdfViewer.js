function viewPDF(pdfData) {
    var pdfWindow = window.open("");
    pdfWindow.document.write(
        "<iframe width='100%' height='100%' src='" + pdfData + "'></iframe>"
    );
}
