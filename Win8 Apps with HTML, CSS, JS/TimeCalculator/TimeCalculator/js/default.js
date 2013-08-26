// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";
    
    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {
            if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {  
            } else {     
            }
            args.setPromise(WinJS.UI.processAll());


            var DaysDifference = document.getElementById("Days-menu-button-id");
            DaysDifference.addEventListener("click", calculateDaysDifference);

            var HoursDifference = document.getElementById("Time-menu-button-id");
            HoursDifference.addEventListener("click", calculatehoursDifference);

            var DaysHoursDifference = document.getElementById("DaysTime-menu-button-id");
            DaysHoursDifference.addEventListener("click", calculateDaysAndHoursDifference);

            var openElement = document.getElementById("open-button-id");
            openElement.addEventListener("click", openElementClicked);
            
            var switchDateElement = document.getElementById("switchDates");
            switchDateElement.addEventListener("change", HideOrShowDate);

            var switchHoursElement = document.getElementById("switchHours");
            switchHoursElement.addEventListener("change", HideOrShowHours);

        }
    };

    app.oncheckpoint = function (args) {
    };
   

    var HideOrShowDate = function (eventinfo) {
        var switchbtn =document.getElementById("switchDates");
        var startDate = document.getElementById("startDate");
        var endDate = document.getElementById("endDate");
        var DaysDifference = document.getElementById("Days-menu-button-id");
        var DaysHoursDifference = document.getElementById("DaysTime-menu-button-id");

        if (switchbtn.className === "win-toggleswitch win-on") {

            startDate.style.display = "none";
            endDate.style.display = "none";
            DaysDifference.style.display = "none";
            DaysHoursDifference.style.display = "none";
        }
        else {
            startDate.style.display = "inline-block";
            endDate.style.display = "inline-block";
            DaysDifference.style.display = "block";
            DaysHoursDifference.style.display = "block";
        }
    }

    var HideOrShowHours = function (eventinfo) {
        var switchbtn = document.getElementById("switchHours");
        var startHour = document.getElementById("startHour");
        var endHour = document.getElementById("endHour");
        var HoursDifference = document.getElementById("Time-menu-button-id");
        var DaysHoursDifference = document.getElementById("DaysTime-menu-button-id");

        if (switchbtn.className === "win-toggleswitch win-on") {

            startHour.style.display = "none";
            endHour.style.display = "none";
            HoursDifference.style.display = "none";
            DaysHoursDifference.style.display="none";
        }
        else {
            startHour.style.display = "inline-block";
            endHour.style.display = "inline-block";
            HoursDifference.style.display = "block";
            DaysHoursDifference.style.display = "block";
        }
    }

    var calculateDaysDifference = function (eventinfo) {

        var startDay = document.getElementById("startDate").winControl.current;
        var endDay = document.getElementById("endDate").winControl.current;
     
        var difference = document.getElementById("output");

        var Day = new Date(startDay);
        var startDay = Day.getDate();
        var startMonth = Day.getMonth();
        var startYear = Day.getFullYear();

        var Day = new Date(endDay);
        var endDay = Day.getDate();
        var endMonth = Day.getMonth();
        var endYear = Day.getFullYear();

        var diff = "the difference is: " + (endYear - startYear) + " Years " + (endMonth - startMonth) + " Months " + (endDay - startDay) + " Days"
        difference.innerText = diff;
    }

    var calculatehoursDifference = function (eventinfo) {

        var startHour = document.getElementById("startHour").winControl.current;
        var endHour = document.getElementById("endHour").winControl.current;
     
        var difference = document.getElementById("output");


        var Day = new Date(startHour);
        var startHour = Day.getHours();
        var startMinute = Day.getMinutes();

        var Day = new Date(endHour);
        var endHour = Day.getHours();
        var endMinute = Day.getMinutes();

        var diff = "The difference is: " + (endHour - startHour) + " Hours " + (endMinute - startMinute) + " Minutes "
        difference.innerText = diff;
    }

    var calculateDaysAndHoursDifference = function (eventInfo) {

        var startDay = document.getElementById("startDate").winControl.current;
        var endDay = document.getElementById("endDate").winControl.current;

        var difference = document.getElementById("output");

        var Day = new Date(startDay);
        var startDay = Day.getDate();
        var startMonth = Day.getMonth();
        var startYear = Day.getFullYear();

        var Day = new Date(endDay);
        var endDay = Day.getDate();
        var endMonth = Day.getMonth();
        var endYear = Day.getFullYear();

        var difference = document.getElementById("output");


        var startHour = document.getElementById("startHour").winControl.current;
        var endHour = document.getElementById("endHour").winControl.current;

        var Time = new Date(startHour);
        var startHour = Time.getHours();
        var startMinute = Time.getMinutes();

        var Time = new Date(endHour);
        var endHour = Time.getHours();
        var endMinute = Time.getMinutes();

        var diff = "the difference is: " + (endYear - startYear) + " Years " + (endMonth - startMonth) + " Months "
           + (endDay - startDay) + " Days " + (endHour - startHour) + " Hours " + (endMinute - startMinute) + " Minutes";
        difference.innerText = diff;
    }

    var openElementClicked = function () {
        var menu = document.getElementById("menu-id").winControl;
        menu.show();
    }
    app.start();
})();
