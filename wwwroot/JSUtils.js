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

async function CargarImagen() {
    let file = await selectFile("image/*", true);
    document.getElementById('imageCard').src = URL.createObjectURL(file[0])
    //var a = document.createElement('input');
    //a.type = 'file';
    //a.click();
}
// ---- function definition ----
function selectFile(contentType, multiple) {
    return new Promise(resolve => {
        let input = document.createElement('input');
        input.type = 'file';
        input.multiple = multiple;
        input.accept = contentType;

        input.onchange = _ => {
            let files = Array.from(input.files);
            if (multiple)
                resolve(files);
            else
                resolve(files[0]);
        };

        input.click();
    });
}