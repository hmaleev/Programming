/// <reference path="//Microsoft.WinJS.1.0/js/base.js" />
WinJS.Namespace.define("PlantKingdom", {
    Vegetable: WinJS.Class.define(function(color, isEatable){
        this._color = color;
        this._isEatable = isEatable;
        //this.radius = radius;
    }, {
        color: {
            get: function () { return this._color; },
            set: function (val) {
                this._color = val;
                //console.log(oldName + "'s name changed to: " + this._name);
            }
        },
        isEatable: {
            get: function () { return this._isEatable; },
            set: function (val) {
                this._isEatable = val;
                //console.log(oldName + "'s name changed to: " + this._name);
            }
        },
    })
});