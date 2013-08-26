// For an introduction to the Page Control template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232511
(function () {
    "use strict";

    WinJS.UI.Pages.define("/pages/spaceFlightPrograms/spaceFlightPrograms.html", {
        // This function is called whenever a user navigates to this page. It
        // populates the page elements with the app's data.
        ready: function (element, options) {
            // TODO: Initialize the page here.
        },

        unload: function () {
            // TODO: Respond to navigations away from this page.
        },

        updateLayout: function (element, viewState, lastViewState) {
            /// <param name="element" domElement="true" />

            // TODO: Respond to changes in viewState.
        }
    });
})();


function GoToX15(e) {
    e.preventDefault();
    WinJS.Navigation.navigate('/pages/spaceFlightPrograms/MannedMissions/X-15 rocket plane/X-15RocketPlane.html');
}

function GoToProjectMercury(e) {
    e.preventDefault();
    WinJS.Navigation.navigate('/pages/spaceFlightPrograms/MannedMissions/ProjectMercury/projectMercury.html');
}

function GoToProjectGemini(e) {
    e.preventDefault();
    WinJS.Navigation.navigate('/pages/spaceFlightPrograms/MannedMissions/ProjectGemini/projectGemini.html');
}

function GoToProjectApollo(e) {
    e.preventDefault();
    WinJS.Navigation.navigate('/pages/spaceFlightPrograms/MannedMissions/ProjectApollo/projectApollo.html');
}
