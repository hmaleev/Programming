/// <reference path="../../../js/YeahToast.js" />
/// <reference path="../../../js/scripts/popUpMessage.js" />
/// <reference path="../../../js/scripts/uiEditor.js" />
/// <reference path="../../../js/scripts/httpRequester.js" />
/// <reference path="//Microsoft.WinJS.1.0/js/ui.js" />
/// <reference path="//Microsoft.WinJS.1.0/js/base.js" />
// For an introduction to the Page Control template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232511
(function () {
    "use strict";

    var applicationData = Windows.Storage.ApplicationData.current;

    var localSettings = applicationData.localSettings;

    WinJS.UI.Pages.define("/pages/tasks/show/show.html", {
        ready: function (element, options) {
            var appBar = document.getElementById("appbar").winControl;
            appBar.disabled = false;

            if (DataPersister.userData.data == undefined || DataPersister.userData.data == '') {
                appBar.show();
            }
            var localStorage = window.localStorage;

            var addButton = document.getElementById("add");
            var updateButton = document.getElementById("edit");
            var backButton = document.getElementById("back-button");
            var syncButton = document.getElementById("sync");
            var tasksList = document.getElementById("tasks").winControl;
            var deleteButton = document.getElementById("delete").winControl;
            var finishButton = document.getElementById("finish").winControl;
            var logoutButton = document.getElementById("logout").winControl;
           // var notificationShown = false;
            var selectedTasks = new Array();

           
            var localTasks = JSON.parse(localStorage.getItem("taskContent"));
            var taskData = [];
           
            if (localTasks !== null) {
                    for (var i = 0; i < localTasks.length; i++) {
                        taskData[i] = localTasks[i]._backingData;
                    }
                DataPersister.userData.data = taskData;

                var list = document.getElementById("tasks").winControl;
                list.itemDataSource = new WinJS.Binding.List(DataPersister.userData.data).dataSource;
               
                console.log(DataPersister.userData.data);
            }

            addButton.addEventListener("click", function () {
                WinJS.Navigation.navigate("pages/tasks/create/create.html");
            });

            tasksList.addEventListener("contextmenu", function () {
                var triger = this.winControl;
                selectedTasks = new Array();

                triger.selection.getItems().then(function (items) {

                    for (var i in items) {
                        selectedTasks.push(items[i].index);
                    }
                });
            });

            appBar.addEventListener("beforeshow", function () {
                if (selectedTasks.length > 1) {
                    appBar.hideCommands("add");
                    appBar.hideCommands("edit");
                    appBar.showCommands("delete");
                    appBar.showCommands("finish");
                    if (DataPersister.userData.hasChanges) {
                        appBar.showCommands("sync");
                    }
                    else {
                        appBar.hideCommands("sync");
                    }
                }
                else if (selectedTasks.length > 0) {
                    appBar.hideCommands("add");
                    appBar.showCommands("edit");
                    appBar.showCommands("delete");
                    appBar.showCommands("finish");
                    if (DataPersister.userData.hasChanges) {
                        appBar.showCommands("sync");
                    }
                    else {
                        appBar.hideCommands("sync");
                    }
                }
                else {
                    appBar.showCommands("add");
                    appBar.hideCommands("edit");
                    appBar.hideCommands("delete");
                    appBar.hideCommands("finish");
                    if (DataPersister.userData.hasChanges) {
                        appBar.showCommands("sync");
                    }
                    else {
                        appBar.hideCommands("sync");
                    }
                }
            });

            deleteButton.addEventListener("click", function () {
                for (var i = selectedTasks.length-1; i>=0 ; i--) {
                    DataPersister.userData.data.splice(selectedTasks[i], 1);
                }
                selectedTasks = new Array();
                localStorage.setItem("deleteTasks", "true");
                DataPersister.update();
               
                WinJS.Navigation.navigate("/pages/tasks/show/show.html");
                localStorage.removeItem("deleteTasks");
                DataPersister.userData.hasChanges = true;
            });

            updateButton.addEventListener("click", function () {
                var taskToEdit = selectedTasks[0];
                WinJS.Navigation.navigate("/pages/tasks/update/update.html", taskToEdit);
            });

            finishButton.addEventListener("click", function () {
                DataPersister.finishTasks(selectedTasks);
                DataPersister.userData.hasChanges = true;
                DataPersister.update();
                WinJS.Navigation.navigate("/pages/tasks/show/show.html");
            });

            //syncButton.addEventListener("click", function () {
            //    if (!DataPersister.userData.hasChanges) {
            //        return;
            //    }

            //    var progressBar = new UI.ProgressBar(document.body);
            //    progressBar.Show();

            //    Request.UserSync(DataPersister.userData.sessionKey, JSON.stringify(DataPersister.userData.data)).then(function (request) {
                   
            //        progressBar.Hide();
            //        //Message.Show("true");\
            //        if (DataPersister.userData.hasChanges) {
            //            YeahToast.show({ title: "Sync done" });
            //            //notificationShown = true;
            //        }
            //        DataPersister.userData.hasChanges = false;

            //    }, function (error) {
            //        progressBar.Hide();
            //        //Message.Show("false");
            //    });

            //});

            logoutButton.addEventListener("click", function () {
                var progressBar = new UI.ProgressBar(document.body);
                progressBar.Show();

                Request.UserLogOut(DataPersister.userData.sessionKey).then(function (request) {
                    progressBar.Hide();
                    DataPersister.userData.remember = false;
                    localSettings.values["user"] = undefined;
                    localStorage.removeItem("remember");
                    WinJS.Navigation.navigate("pages/menu/login/login.html");

                }, function (request) {
                    progressBar.Hide();
                });
            });
        }
    });
})();
