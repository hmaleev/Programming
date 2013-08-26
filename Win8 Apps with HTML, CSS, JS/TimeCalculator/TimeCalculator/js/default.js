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


            var calc = document.getElementById("calcDays");
            calc.addEventListener("click", calculateDaysDifference);

            var calc2 = document.getElementById("calcHours");
            calc2.addEventListener("click", calculatehoursDifference);

            var calc3 = document.getElementById("calcDaysAndHours");
            calc3.addEventListener("click", calculateDaysAndHoursDifference);
        }
    };

    app.oncheckpoint = function (args) {
    };
   
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
    app.start();
})();
