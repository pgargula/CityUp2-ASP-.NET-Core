var urlUpdateStatus = "/api/ApiApplication/UpdateStatus";
var urlUpdateAdminMsg = "/api/ApiApplication/UpdateAdminMsg";
var urlPopulateStatusSelect = "/api/ApiApplication/GetStatuses";

var adminMsgButton = document.getElementById("adminMsgButton");
var statusButton = document.getElementById("statusButton");

///populate status select
$.ajax({
    type: 'GET',
    url: urlPopulateStatusSelect,
    contentType: "application/json",
    dataType: 'json',
    success: function (statuses) {
        $.each(statuses, function (key, modelName) {
            var option = new Option(modelName, modelName);
            $(option).html(modelName);
            $("#statusSelect").append('<option value="' + modelName.statusId + '">' + modelName.label + '</option>');
        });
    }
});


$('#statusSelect').on('change', function () {/// send new status
    var selected = $(this).find('option:selected');
    statusId = selected.val();
    var model = { applicationId: appId, statusId: statusId };
    $.ajax({
        type: "POST",
        url: urlUpdateStatus,
        data: model,
        success: function () {
            document.getElementById("statusAlert").textContent = selected.text();
            editStatus()
            AddNotification(function () { }, "Pomyślnie zmieniono status");
        }
    });
});

function updateAdminMsg() {
    var msg = $('#adminMsgText').val();
    var model = { applicationId: appId, msg: msg };
    $.ajax({
        type: "POST",
        url: urlUpdateAdminMsg,
        data: model,
        success: function () {
            document.getElementById("adminMsgView").textContent = msg;
            AddNotification(function () { }, "Pomyślnie zmieniono wiadomość");
        }
    });
}


function editAdminMsg() {
    if (document.getElementById("adminMsgView").style.display == "block") {
        document.getElementById("adminMsgView").style.display = "none";
        document.getElementById("adminMsgInput").style.display = "block";
        adminMsgButton.textContent = "Dodaj"

    }
    else {
        document.getElementById("adminMsgView").style.display = "block";
        document.getElementById("adminMsgInput").style.display = "none";
        adminMsgButton.textContent = "Zmień"
        updateAdminMsg();
    }
}

function editStatus() {
    if (document.getElementById("statusView").style.display == "block") {
        document.getElementById("statusView").style.display = "none";
        document.getElementById("status").style.display = "block";
        statusButton.textContent = "Anuluj";
    }
    else {
        document.getElementById("statusView").style.display = "block";
        document.getElementById("status").style.display = "none";
        statusButton.textContent = "Zmień";
    }

}
///gallery
function changeMainPhoto(e) {
    var newSrc = $(e).attr('src');
    $('#mainPhoto').attr("src", newSrc);
}


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
function initMap() {
    var applicationLocation = new google.maps.LatLng(ltd , lng);
    var map = new google.maps.Map(document.getElementById('googleMap'), { zoom: 18, center: applicationLocation });

    var marker = new google.maps.Marker({
        position: applicationLocation,
        map: map,

    });
}