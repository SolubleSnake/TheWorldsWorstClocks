// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
//const watchId = navigator.geolocation.watchPosition(position => {
//    const { latitude, longitude } = position.coords;
//    // Show a map centered at latitude / longitude.
//});

//function buttonClickHandler() {
//    // Cancel the updates when the user clicks a button.
//    navigator.geolocation.clearWatch(watchId);
//}

navigator.geolocation.getCurrentPosition(
    successCallback,
    console.error,
    { maximumAge: 600_000 }
);

function successCallback(position) {
    // By using the 'maximumAge' member above, the position
    // object is guaranteed to be at most 10 minutes old.
}
