//switching beetween map and tab view
var list = document.getElementById("list");
var googleMap = document.getElementById("googleMap");

$('#showList').on('change', function () {
    list.style.display = "block";
    googleMap.style.display = "none";
});
$('#showMap').on('change', function () {
    list.style.display = "none";
    googleMap.style.display = "block";
});


document.addEventListener('DOMContentLoaded', function () {
    initListMap();
}, false);
var cityGeo
function initListMap() {
    $.ajax({
        type: 'GET',
        url: '/api/ApiCity/' +cityId,
        contentType: "application/json",
        dataType: 'json',
        success: function (cityGeo) {
            getAppData();
            initMap(cityGeo);
        }
    });
};

function getAppData() {
    $.ajax({
        type: 'GET',
        url: '/api/ApiApplication/' + url,
        contentType: "application/json",
        dataType: 'json',
        success: function (result) {
            initTable(result);
            for (var i = 0; i < result.length; i++) {
                loadMarker(result[i]);
            }
        }
    });
}