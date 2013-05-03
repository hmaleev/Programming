var styles = new Array();
styles[0] = "styles/defaultStyle.css";
styles[1] = "styles/redStyle.css";
styles[2] = "styles/blueStyle.css";

function CompareNumbers() {

    var playerNumber = document.getElementById("inputNumber").value;
    document.getElementById("hiddenNumber").innerHTML = playerNumber;
    var playerNumberAsString = playerNumber.toString();
    var i;
    var j;
    var bullCount = 0;
    var cowCount = 0;
    var randomNumber = document.getElementById("task2").innerHTML;
    var randomNumberAsString = randomNumber.toString();
    for (i = 0; i < playerNumber.length; i++) {
        for (j = 0; j < playerNumber.length; j++) {

            if (playerNumber.charAt(i) === randomNumberAsString.charAt(j) && i === j) {
                bullCount++;
                break;
            }
            if (playerNumber.charAt(i) === randomNumberAsString.charAt(j) && i !== j) {

                cowCount++
                break;
            };
        };
    };
    document.getElementById("task1").innerHTML = "Cows: " + cowCount + " Bulls: " + bullCount;
}

function GenerateRandomNumber() {

    var randomNumber;
    var lengthOfNumber = 1;
    for (;;) {
        randomNumber = Math.floor(Math.random() * 10000)
        lengthOfNumber = randomNumber.toString().length;
        if (lengthOfNumber === 4) {
            var isRandomNumber = CheckForUniqueDigits(randomNumber);

            break;
        };

    };
    if (!isRandomNumber) {
        GenerateRandomNumber();
    } else {
        document.getElementById("task2").innerHTML = randomNumber;
    }
}

function CheckForUniqueDigits(randomNumber) {

    var number = randomNumber;
    //    var number = document.getElementById("task2").innerHTML;
    var isUnique = true;
    var i;
    var j;
    var lengthOfNumber = 1;
    var numberAsString = number.toString();
    for (i = 0; i < numberAsString.length - 1; i++) {
        if (!isUnique) {
            break;
        };
        for (j = i + 1; j <= numberAsString.length - 1; j++) {

            if (numberAsString.charAt(i) !== numberAsString.charAt(j)) {
                isUnique = true;
            } else {
                isUnique = false
                break;
            };
        };
    };
    //  document.getElementById("task3").innerHTML = isUnique + " ";
    return isUnique;
};

function AddToHistory() {

    var playerNumber = document.getElementById("hiddenNumber").innerHTML;
    var count = document.getElementById("task1").innerHTML;
    document.getElementById("history").innerHTML += playerNumber + "</br>";
    document.getElementById("history").innerHTML += count + "</br>";
}

function changeStyle(style) {

    document.getElementById("style").href = style;
    var text = document.getElementById("style").href;
    saveState(text);

}

function saveState(text) {

    var value = text;
    var key = "path";
    localStorage.setItem(key, value);
}

function AddToHistory() {

    var playerNumber = document.getElementById("hiddenNumber").innerHTML;
    var count = document.getElementById("task1").innerHTML;
    document.getElementById("history").innerHTML += playerNumber + "</br>";
    document.getElementById("history").innerHTML += count + "</br>";
}

function showHistory() {

    document.getElementById("history").style.display = "inline";
    document.getElementById("showHistoryBtn").style.display = "none";
    document.getElementById("hideHistoryBtn").style.display = "inline";
}

function hideHistory() {

    document.getElementById("history").style.display = "none";
    document.getElementById("hideHistoryBtn").style.display = "none";
    document.getElementById("showHistoryBtn").style.display = "inline";
}

function clearHistory() {

    document.getElementById("history").innerHTML = "";
}

function startNewGame() {
    GenerateRandomNumber();
    //document.write("<script src='moreStuff.js' type='text/javascript'></script>");

    document.getElementById("GuessNumber").style.display = "inline";
    document.getElementById("inputNumber").style.display = "inline";
    clearHistory();
    hideHistory();
}