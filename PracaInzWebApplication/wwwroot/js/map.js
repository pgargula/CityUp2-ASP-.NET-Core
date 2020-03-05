
var map
var cityLocation

function initMap(cityGeo) {
    //sttarting location
    cityLocation = new google.maps.LatLng(cityGeo.geolocation.latitude, cityGeo.geolocation.longitude);
    map = new google.maps.Map(
        document.getElementById('googleMap'), { zoom: 12, center: cityLocation });



}

function loadMarker(applicationData) {
    var model = {
        id: applicationData.applicationId,
        title: applicationData.title,
        street: applicationData.adress.street,
        description: applicationData.description,
        picture: applicationData.applicationPictures[0].picturePath,
        latitude: applicationData.adress.geolocation.latitude,
        longitude: applicationData.adress.geolocation.longitude
    }
    var marker = createMarker(model);
}

function createMarkerIcon(iconUrl) {
    return {
        url: iconUrl,
        scaledSize: new google.maps.Size(40, 40),
        origin: new google.maps.Point(0, 0),
        anchor: new google.maps.Point(32, 65),
        labelOrigin: new google.maps.Point(20, 50)
    }
}

function createMarker(model) {
    var infowindow = new google.maps.InfoWindow({
        maxWidth: 180
    });

    var marker = new google.maps.Marker({
        position: new google.maps.LatLng(model.latitude, model.longitude),
        map: map,
        animation: google.maps.Animation.DROP,
        title: model.username,
        icon: createMarkerIcon('https://image.flaticon.com/icons/svg/252/252025.svg'),
        label: {
            text: model.title,
            color: '#a00',
            fontSize: '16px',
            fontWeight: 'bold'
        }
    });
    google.maps.event.addListener(marker,
        'click',
        (function (marker) {
            return function () {
                infowindow.setContent('<h5>' +
                    model.title +
                    '</h5>' +
                    '<p>' +
                    model.street +
                    '</p>' +
                    '<p>' +
                    model.description +
                    '</p>' +
                    '<img style="width: 140px; height: 140px"  src="' + model.picture + '"/>' +
                    '<a class="btn btn-primary" role="button" href="ApplicationDetails?applicationId=' + model.id + '">Detale</a>');
                infowindow.open(map, marker);
            }
        })(marker));

    return marker;
}