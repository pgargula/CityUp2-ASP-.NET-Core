var urlAddVote = "/api/ApiApplication/AddVote";
var urlDeleteVote = "/api/ApiApplication/DeleteVote";



function addVote() {
    var model = { applicationId: appId, userId: user };
    $.ajax({
        type: "POST",
        url: urlAddVote,
        data: model,
        success: function () {
            refreshScore();
        }
    });
}

function deleteVote() {
    var model = { applicationId: appId, userId: user };
    $.ajax({
        type: "POST",
        url: urlDeleteVote,
        data: model,
        success: function () {
            refreshScore();
        }
    });
}      

function refreshScore() {
    var container = $("#scoreContainer");
    $.ajax({
        type: "GET",
        url: "/Application/ScoreView/?applicationId=" + appId,
        success: function (data) {
            container.html(data);
        }
    });
}