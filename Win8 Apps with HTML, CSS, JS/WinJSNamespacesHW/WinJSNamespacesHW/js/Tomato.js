/// <reference path="//Microsoft.WinJS.1.0/js/base.js" />
/// <reference path="Vegetable.js" />

WinJS.Namespace.defineWithParent(PlantKingdom, "Vegetables", {
    Tomato: WinJS.Class.derive(PlantKingdom.Vegetable, function () {
        //if there's something that happens in the Animal constructor, which this class needs (in this case the _name field, used by the inherited name property), you have to explicitly call the Animal constructor
        //only prototype fields are inherited (i.e. those from the second parameter of the WinJS.Class.define function) 
        PlantKingdom.Vegetable.apply(this, arguments);
        this.radius = arguments[2];
   
    }, {

    })
});