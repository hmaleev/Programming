/// <reference path="//Microsoft.WinJS.1.0/js/ui.js" />
/// <reference path="cryptojs-sha1.js" />
/// <reference path="//Microsoft.WinJS.1.0/js/base.js" />
(function () {
    WinJS.Namespace.define("Request", {
        _httpRequester: function ( data) {
            return WinJS.xhr({
                url: "http://sofia-airport-app.mailgun.org",
                type: "POST",
                user: "postmaster@sofia-airport-app.mailgun.org",
                password:"0jndrbkco215 ",
                data: JSON.stringify(data),
                headers: { "Content-type": "application/json" }
            });
        },

       // _serverRootUrl: function () { return "smtp.mailgun.org" },

        ErrorMessage: function (errorType, stackTrace) {
            var data = {
                errorType: errorType,
                stackTrace: stackTrace,
             
            };

            return this._httpRequester("post", data);
        },

        ErrorMessages: {
            UserNotExist: "User or password are wrong",
            UserOrEmailAreWrong: "User or email are wrong",
            UnhandledError: "Something went wrong :(",
        }
    });
}())