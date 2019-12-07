// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code
function itemAddNotification(callback) {
    showSnackbar();
    setTimeout(function () {
        callback();
    }, 700);
}


function showSnackbar() {
    var x = document.getElementById("snackbar");
    x.innerHTML = "Pomyślnie dodano zgłoszenie!";
    x.className = "show";
    setTimeout(function () {
        x.className = x.className.replace("show", "");
    }, 3000);
}