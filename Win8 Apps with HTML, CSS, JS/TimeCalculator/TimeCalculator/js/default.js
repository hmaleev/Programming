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

            var startDate = document.getElementById("startDate");
            startDate.addEventListener("change", startDayChange);

            var endDate = document.getElementById("endDate");
            endDate.addEventListener("change", endDayChange);

            var startDate = document.getElementById("startHour");
            startDate.addEventListener("change", startHourChange);

            var endDate = document.getElementById("endHour");
            endDate.addEventListener("change", endHourChange);

            var calc = document.getElementById("calc");
            calc.addEventListener("click", calculateDaysDifference);

            var calc2 = document.getElementById("calcHours");
            calc2.addEventListener("click", calculatehoursDifference);
        }
    };

    app.oncheckpoint = function (args) {
    };
   
    var calculateDaysDifference = function (eventinfo) {

        var startDay = document.getElementById("startDateResult").innerText;
        var endDay = document.getElementById("endDateResult").innerText;
     

        var difference = document.getElementById("diff");


        var Day = new Date(startDay);
        var startDay = Day.getDate();
        var startMonth = Day.getMonth();
        var startYear = Day.getFullYear();

        var Day = new Date(endDay);
        var endDay = Day.getDate();
        var endMonth = Day.getMonth();
        var endYear = Day.getFullYear();

        var diff = "the difference is: " + (startYear - endYear) + " Years " + (startMonth - endMonth) + " Months " + (startDay - endDay) + " Days"
        difference.innerText = diff;
    }

    var calculatehoursDifference = function (eventinfo) {

        var startHour = document.getElementById("startHourResult").innerText;
        var endHour = document.getElementById("endHourResult").innerText;
     
        var difference = document.getElementById("HourDifference");


        var Day = new Date(startHour);
        var startHour = Day.getHours();
        var startMinute = Day.getMinutes();

        var Day = new Date(endHour);
        var endHour = Day.getHours();
        var endMinute = Day.getMinutes();

        var diff = "The difference is: " + (startHour - endHour) + " Hours " + (startMinute - endMinute) + " Minutes "
        difference.innerText = diff;

    }

    var startDayChange = function (eventInfo) {
        var result;
        var day  = document.getElementById("startDateResult");
        var datePickerElement = document.getElementById("startDate").winControl;
        result = datePickerElement.current;
        day.innerHTML = result
    }

    var endDayChange = function (eventInfo) {
        var result;
        var day = document.getElementById("endDateResult");
        var datePickerElement = document.getElementById("endDate").winControl;
        result = datePickerElement.current;
        day.innerHTML = result
    }

    var startHourChange = function (eventInfo) {
        var result;
        var time = document.getElementById("startHourResult");
        var datePickerElement = document.getElementById("startHour").winControl;
        result = datePickerElement.current;
        time.innerHTML = result
    }

    var endHourChange = function (eventInfo) {
        var result;
        var time = document.getElementById("endHourResult");
        var datePickerElement = document.getElementById("endHour").winControl;
        result = datePickerElement.current;
        time.innerHTML = result
    }
    app.start();
})();
