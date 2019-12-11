// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code
function AddNotification(callback,msg) {
    showSnackbar(msg);
    setTimeout(function () {
        callback();
    }, 700);
}


function showSnackbar(msg) {
    var x = document.getElementById("snackbar");
    x.innerHTML = msg//"Pomyślnie dodano zgłoszenie;
    x.className = "show";
    setTimeout(function () {
        x.className = x.className.replace("show", "");
    }, 3000);
}