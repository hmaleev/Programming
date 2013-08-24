/// <reference path="Tomato.js" />
/// <reference path="Cucumber.js" />
/// <reference path="MushroomMixin.js" />
/// <reference path="Vegetable.js" />
(function () {
   
    WinJS.Application.onactivated = function () {
        var tomato = new PlantKingdom.Vegetables.Tomato("red", true, 10)
        var cucumber = new PlantKingdom.Vegetables.Cucumber("green", true);
        console = new DomLogger(document.getElementById("output"));
     
        var Mix = WinJS.Class.mix(PlantKingdom.Vegetables.Tomato, MushroomMixin);
        var TomatoGMO = new Mix("red", true, 10);
        TomatoGMO.grow(10);
        console.log(TomatoGMO);
    };
    
    WinJS.Application.start();
})();
