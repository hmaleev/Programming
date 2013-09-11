// For an introduction to the Page Control template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232511
(function () {
    "use strict";

    WinJS.UI.Pages.define("/pages/settings/settings.html", {
        // This function is called whenever a user navigates to this page. It
        // populates the page elements with the app's data.
        ready: function (element, options) {
            // TODO: Initialize the page here.
            //var selectedOptionIndex = Windows.Storage.ApplicationData.current.roamingSettings.values["optionIndex"];
            //console.log(selectedOptionIndex);
            //var displayFlights = document.getElementById("displayFlights");
            //displayFlights.selectedIndex = selectedOptionIndex;

            var defaultFilghtsToShow = Windows.Storage.ApplicationData.current.roamingSettings.values["displayFlights"];    
            var v = Windows.Storage.ApplicationData.current.roamingSettings.values["optionValue"];

            //         console.log(WinJS.Application.roaming.folder.path);
            console.log(defaultFilghtsToShow);
            console.log(v);

            if (v===undefined) {
                v = 0;
            }
            else {
                var x = document.getElementById("displayFlights");
                x.selectedIndex = v;
            }
            if (defaultFilghtsToShow === undefined) {
                defaultFilghtsToShow = displayFlights.options[v].value;
            }

            displayFlights.onchange = function (e) {
                Windows.Storage.ApplicationData.current.roamingSettings.values["displayFlights"] = displayFlights.options[displayFlights.selectedIndex].value;
                Windows.Storage.ApplicationData.current.roamingSettings.values["optionValue"] = displayFlights.options[displayFlights.selectedIndex].index;
                console.log(defaultFilghtsToShow);

            }
           
        },

        unload: function () {
            // TODO: Respond to navigations away from this page.
            //var x = displayFlights.selectedIndex;
           
        },

        updateLayout: function (element, viewState, lastViewState) {
            /// <param name="element" domElement="true" />

            // TODO: Respond to changes in viewState.
        }
    });
})();