/// <reference path="//Microsoft.WinJS.1.0/js/base.js" />
/// <reference path="//Microsoft.WinJS.1.0/js/ui.js" />
(function () {
    var userData = {
        username: "",
        sessionKey: "",
        remember: false,
        data: new Array(),
        hasChanges: false,
    };

    var task = {
        title: "",
        content: "",
        finishDate: "",
        status: ""
    };

    var createNewTask = function (title, content, finishDate) {
        var newTask = {
            title: title,
            content: content,
            finishDate: finishDate,
            status: "images/inprogress.png"
        };

        userData.hasChanges = true;

        if (userData.data == null) {
            userData.data = new Array();
        }
        userData.data.push(newTask);
    };

    var ObservableTask = WinJS.Binding.define(task);

    var getObservableTask = function (title, content, finishDate, status) {
        return new ObservableTask({
            title: title,
            content: content,
            finishDate: finishDate,
            status: status
        });
    }

    var makeBindableTasks = function () {

        var list = new Array();

        for (var i in userData.data) {

            var title = userData.data[i].title;
            var content = userData.data[i].content;
            var finishDate = userData.data[i].finishDate;
            var status = userData.data[i].status;

            list.push(getObservableTask(title, content, finishDate, status));
        }

        return new WinJS.Binding.List(list);
    }

    var bindableTasks = new makeBindableTasks();

    var finishTasks = function (args) {
        for (var i in args) {
            userData.data[args[i]].status = "images/done.png"
        }
    }

    WinJS.Namespace.define("DataPersister", {
        createNewTask: createNewTask,
        userData: userData,
        tasks: bindableTasks,

        update: function () {
            this.tasks = makeBindableTasks();
        },

        finishTasks: finishTasks,
    });
}())