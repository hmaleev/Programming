// For an introduction to the Page Control template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232511
(function () {
    "use strict";

    WinJS.UI.Pages.define("/pages/departures/departures.html", {
        // This function is called whenever a user navigates to this page. It
        // populates the page elements with the app's data.
        ready: function (element, options) {
            // TODO: Initialize the page here.
            var p = document.getElementById("txt");
            var table = document.getElementById("table-departures");
            table.innerHTML = "";
            var x = 0;
            var tableEndRow;
            var currentPage;
            var endPage;
            var results = "20";

            WinJS.xhr({
                url: "http://www.sofia-airport.bg/pages/departures.aspx",
                type: "GET"
            }).then(function (response) {
                console.log(response);
                response.responseText
                var pageinfo = document.getElementById("pageinfo");
                pageinfo.innerHTML = toStaticHTML(response.responseText);
                currentPage = document.getElementsByClassName("gridLinkActivePage");
                currentPage = currentPage[0].textContent;
                pageinfo.outerHTML = "";
                switch (results) {
                    case "10": endPage = parseInt(currentPage) + 1; break;
                    case "20": endPage = parseInt(currentPage) + 2; break;
                    case "30": endPage = parseInt(currentPage) + 3; break;
                }
                GetPages();
            })

            function GetPages() {
                for (var i = currentPage; i < endPage; i++) {

                    WinJS.xhr({
                        url: "http://www.sofia-airport.bg/pages/departures.aspx?lm01=103&lm02=51&lm03=51&p=" + i,
                        type: "GET"
                    }).then(function (response) {
                        p.innerHTML += toStaticHTML(response.responseText);
                        table.innerHTML += document.getElementsByTagName("table")[x].innerHTML;

                        if (tableEndRow !== undefined) {
                            table.rows[tableEndRow + 1].outerHTML = "";
                            table.rows[tableEndRow].outerHTML = "";
                            for (var i = 1; i < table.rows.length; i++) {
                                if (i % 2 == 1) {
                                    table.rows[i].style.backgroundColor = "green";
                                }
                                table.rows[i].cells[9].outerHTML = ""
                            }
                        }
                        table.rows[0].outerHTML = "<th>Дата</th><th>Час</th><th>Полет</th><th>Тип самолет</th><th>Направление</th><th>Терминал</th><th>Очакван час</th><th>Статус</th><th>Наземен оператор</th>";
                        table.rows[1].outerHTML = "";

                        tableEndRow = table.rows.length;
                        x++;
                    },
               function (error) {
                   console.log(error);
               });
                }
            }
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
