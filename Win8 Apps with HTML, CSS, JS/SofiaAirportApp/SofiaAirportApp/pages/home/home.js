(function () {
    "use strict";

    WinJS.UI.Pages.define("/pages/home/home.html", {
        // This function is called whenever a user navigates to this page. It
        // populates the page elements with the app's data.
        ready: function (element, options) {
            // TODO: Initialize the page here.
            var appBar = document.getElementById("appbar");
            appBar.disabled = true;
        }
    });
})();

function GoToArrivals(e) {
    e.preventDefault();
    WinJS.Navigation.navigate('/pages/arrivals/arrivals.html');
}

function GoToDepartures(e) {
    e.preventDefault();
    WinJS.Navigation.navigate('/pages/departures/departures.html');
}