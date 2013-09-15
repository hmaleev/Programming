// For an introduction to the Page Control template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232511
(function () {
    "use strict";

    WinJS.UI.Pages.define("/pages/brands/nokia/nokia.html", {
        // This function is called whenever a user navigates to this page. It
        // populates the page elements with the app's data.
        ready: function (element, options) {
            // TODO: Initialize the page here.
            var pageContent = document.getElementById("pageInfo");
            var phones = document.getElementById("phones");
            var x;
            WinJS.xhr({
                url: "http://www.gsmarena.com/nokia-phones-1.php",
                type: "GET"
            }).done(function (response) {
                pageContent.innerHTML = toStaticHTML(response.responseText);
               var phonesList = document.getElementsByTagName("ul");
               for (var i = 3; i < phonesList.length-1; i++) {
                   phones.innerHTML += phonesList[i].innerHTML;
               }

                pageContent.innerHTML = " ";
            }, function (error) {
                console.log(error.statusText)
            });
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
