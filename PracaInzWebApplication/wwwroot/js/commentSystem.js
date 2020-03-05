var date;
var urlAddcomment = "/api/ApiComment/Add"
var urlAddResponse = "/api/ApiComment/AddResponse"

/*  $('#response').click(function() {       //showing response
      var responseArea = document.getElementById("responseArea");
      responseArea.style.display = "block";
  });*/
function showResponseArea(id) {
    var responseAreaId = "responseArea" + id;
    var responseArea = document.getElementById(responseAreaId);
    if (responseArea.style.display == "block")
        responseArea.style.display = "none";
    else
        responseArea.style.display = "block";
}


function sendComment() {  ///send comment
    var commnentText = $('#commentText').val();
    var date = new Date().toLocaleString();

    var model = { applicationid: appId, userid: user, text: commnentText, date: date };

    $.ajax({
        type: "POST",
        url: urlAddcomment,
        data: model,
        success: function () {

            refreshComments();
            AddNotification(function () { }, "Pomyślnie dododano komentarz");
        }
    });

}

function sendResponse(id) {  ///send comment response
    var commnentTextResponse = $('#commentTextResponse' + id).val();
    var date = new Date().toLocaleString();
    var commentId = id;
    var model = { commentid: commentId, userid: user, text: commnentTextResponse, date: date };

    $.ajax({
        type: "POST",
        url: urlAddResponse,
        data: model,
        success: function () {
            refreshComments()
            AddNotification(function () { }, "Pomyślnie dododano komentarz");
        }
    });

}

function refreshComments() {
    var container = $("#commentContainer");
    $.ajax({
        type: "GET",
        url: "/Comment/CommentView/?applicationId=" + appId,
        success: function (data) {
            container.html(data);
        }
    });

}