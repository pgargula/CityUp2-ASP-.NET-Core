document.addEventListener('DOMContentLoaded', function () {
    initListMap();
}, false);
var cityGeo
function initListMap() {
    $.ajax({
        type: 'GET',
        url: '/api/ApiCity/' +Id,
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