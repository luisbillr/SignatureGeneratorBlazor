function SaveDivAsImage(div) {
    var doc = document.getElementById("Signature");
    var docOpen = document.getElementsByClassName("main");
    html2canvas(doc).then(canvas => {
        backgroundColor: "#ffffff";
        //var myImage = canvas.toDataURL("image/png");
        //document.body.appendChild(canvas);
        onrendered: {
            var a = document.createElement('a');
            // toDataURL defaults to png, so we need to request a jpeg, then convert for file download.
            a.href = canvas.toDataURL("image/jpeg").replace("image/jpeg", "image/octet-stream");
            a.download = 'firma.jpg';
            a.click();
        }
        
    });
    return "";
}