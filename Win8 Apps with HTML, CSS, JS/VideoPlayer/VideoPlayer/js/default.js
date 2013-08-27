// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;
    var playlist = new Windows.Media.Playlists.Playlist();

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {
            if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
                // TODO: This application has been newly launched. Initialize
                // your application here.
            } else {
                // TODO: This application has been reactivated from suspension.
                // Restore application state here.
            }

            var loadedVideosList = document.getElementById("loaded-videos");
            var player = document.getElementById("player");
            //var list2 = document.getElementById("plList");
            loadedVideosList.addEventListener("click", function (event) {
                var videoEntry = event.target;

                if (videoEntry.tagName.toLowerCase() == "strong") {
                    videoEntry = videoEntry.parentElement;
                }

                player.src = videoEntry.getAttribute("data-song-url");
                player.play();
            });

            var addSongListEntry = function (songName, videoDuration, songUrl) {
                var duration = videoDuration / 1000;
             //   var title = songName || 
                var videoEntry = document.createElement("li");
                videoEntry.setAttribute("data-song-url", songUrl);
                videoEntry.innerHTML = "<strong>" + songName + "</strong>" + " Duration: " + duration.toLocaleString() +" seconds";
                loadedVideosList.appendChild(videoEntry);
            }
            var i = 0;
            var addSong = function (storageFile) {
                var fileUrl = URL.createObjectURL(storageFile);

                playlist.files.append(storageFile);
           
                storageFile.properties.getVideoPropertiesAsync().then(function (properties) {
                    
                  var title =  properties.title || storageFile.displayName;
                    properties.duration;
                    addSongListEntry(title, properties.duration, fileUrl);
                });
            }
           

            WinJS.Utilities.id("pick-file-button").listen("click", function () {
                var openPicker = Windows.Storage.Pickers.FileOpenPicker();
                openPicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.videosLibrary;

               
                openPicker.fileTypeFilter.append(".avi");
                openPicker.fileTypeFilter.append(".mp4");
                openPicker.fileTypeFilter.append(".wmv");
                openPicker.pickSingleFileAsync().then(addSong);
            });

            WinJS.Utilities.id("pick-multiple-files-button").listen("click", function () {
                var openPicker = Windows.Storage.Pickers.FileOpenPicker();
                openPicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.videosLibrary;
                openPicker.fileTypeFilter.append(".avi");
                openPicker.fileTypeFilter.append(".mp4");
                openPicker.fileTypeFilter.append(".wmv");
                openPicker.pickMultipleFilesAsync().then(function (files) {
                    files.forEach(addSong);
                });
            });

            //var playlistContainer = function (playlist) {
            //    var list2 = document.getElementById("loaded-videos");
            //    list2.s
            //}
            args.setPromise(WinJS.UI.processAll());
        }
    };

    app.oncheckpoint = function (args) {
        // TODO: This application is about to be suspended. Save any state
        // that needs to persist across suspensions here. You might use the
        // WinJS.Application.sessionState object, which is automatically
        // saved and restored across suspension. If you need to complete an
        // asynchronous operation before your application is suspended, call
        // args.setPromise().
    };

    app.start();
})();




