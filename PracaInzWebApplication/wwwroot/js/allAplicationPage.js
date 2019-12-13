

var url = "GetAllByCity/" + cityId
var detailsPath = "/User/"


//populating city select
$.ajax({
    type: 'GET',
    url: '/api/ApiCity/',
    contentType: "application/json",
    dataType: 'json',
    success: function (cities) {
        $.each(cities, function (key, modelName) {
            var option = new Option(modelName, modelName);
            $(option).html(modelName);
            $("#citySelect").append('<option value="' + modelName.cityId + '" data-lng="' + modelName.geolocation.longitude + '" data-ltd="' + modelName.geolocation.latitude + '">' + modelName.name + '</option>');
        });
        $('#citySelect').val(cityId).change();      //set user default city
    }
});

$('#citySelect').on('change', function () {/// changing map display location after changing city
    var selected = $(this).find('option:selected');
    cityId = selected.val();
    url = "GetAllByCity/" + cityId
    initListMap();
});


