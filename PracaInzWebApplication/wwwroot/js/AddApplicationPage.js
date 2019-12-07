
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
                $("#citySelect").append('<option value="' + modelName.cityId +'" data-lng="' + modelName.geolocation.longitude + '" data-ltd="' + modelName.geolocation.latitude +'">' + modelName.name + '</option>');
                    });
           $('#citySelect').val(defaultCity).change();      //set user default city
                }
            });

        //populating category select
    $.ajax({
            type: 'GET',
        url: '/api/ApiCategory/',
        contentType: "application/json",
        dataType: 'json',
        success: function (categories) {
            $.each(categories, function (key, modelName) {
                        var option = new Option(modelName, modelName);
                $(option).html(modelName);
                $("#categorySelect").append('<option value="' + modelName.categoryId + '">' + modelName.name + '</option>');
                    });
           $('#categorySelect').val(1).change();
                }
            });

        var cityLocation;
            var citySelect = document.getElementById('citySelect');
            var selectedCity = citySelect.options[citySelect.selectedIndex].text;
            var input = document.getElementById('streetInput');
            var lng = document.getElementById('lng');
            var ltd = document.getElementById('ltd');
            var map;
            var marker;
            var geocoder

        /// insert text about choosen photes
        $(document).ready(function () {
            $('.custom-file-input').on("change", function () {
                    var fileLabel = $(this).next('.custom-file-label');
                    var files = $(this)[0].files;
                    if (files.length > 1) {
                        fileLabel.html('Wybrano '+files.length+' zdjęcia' );
                    }
                    else if (files.length == 1) {
                        fileLabel.html(files[0].name);
                    }
                });
            });

        $('#citySelect').on('change', function() {/// changing map display location after changing city
                var selected = $(this).find('option:selected');
                userCityLng = selected.data('lng');
                userCityLng = selected.data('ltd');
                cityLocation = new google.maps.LatLng(selected.data('ltd'), selected.data('lng'));
                map.setCenter(cityLocation);
                map.setZoom(12);
            });


       
            function initMap() {
                //sttarting location

                map = new google.maps.Map(
                    document.getElementById('googleMap'), { zoom: 12, center: cityLocation });

                //map click setting lng ltd
                map.addListener('click', function (e) {
                    placeMarker(e.latLng, map);
                });

                geocoder = new google.maps.Geocoder;

                ////Setting for autocomplete places
                var autocomplete = new google.maps.places.Autocomplete(input);
                autocomplete.bindTo('bounds', map);

                // Set the data fields to return when the user selects a place.
                autocomplete.setFields(
                    ['address_components', 'geometry', 'icon', 'name']);

                marker = new google.maps.Marker({
                map: map,
                anchorPoint: new google.maps.Point(0, -29)
            });

                autocomplete.setTypes(['address']); //only adress allowed

                autocomplete.addListener('place_changed', function () {
                    lng.value = marker.getPosition().lng();
                    lng.value = marker.getPosition().lat();
                    marker.setVisible(false);
                    var place = autocomplete.getPlace();
                    if (!place.geometry) {
                        // User entered the name of a Place that was not suggested and
                        // pressed the Enter key, or the Place Details request failed.
                        window.alert("Brak danych dla: '" + place.name + "'");
                        return;
                    }

                    // If the place has a geometry, then present it on a map.
                    if (place.geometry.viewport) {
                        map.fitBounds(place.geometry.viewport);
                    } else {
                        map.setCenter(place.geometry.location);
                        map.setZoom(17);
                    }
                    marker.setPosition(place.geometry.location);
                    marker.setVisible(true);

                    var address = '';
                    if (place.address_components) {
                        address = place.address_components[0] && place.address_components[0].short_name;
                        input.value = address;
                    }
                });

            }

            function getGeocode(geocoder, map, marker) {

                geocoder.geocode({ 'location': marker.position }, function (results, status) {
                    if (status === 'OK') {
                        if (results[0]) {
                            input.value = results[0].address_components[1].long_name;
                        } else {
                            window.alert('nie znaleziono danych');
                        }
                    } else {
                        window.alert('Geocoder failed due to: ' + status);
                    }
                });
            }



            //check if marker exist then clean map and set new
            function placeMarker(position, map) {
                if (marker) {
                    marker.setMap(null);
                }
                marker = new google.maps.Marker({
            position: position,
            map: map
            });
                ltd.value = marker.getPosition().lat().toFixed(9);
                lng.value = marker.getPosition().lng().toFixed(9);
                getGeocode(geocoder,map, marker);
                map.panTo(position);
            }