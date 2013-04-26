//task 1

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

function changeStyle() {

    document.getElementById("style").href = "styles/style2.css"

}
function showHistory() {

    document.getElementById("history").style.display ="inline"
}
function hideHistory() {

    document.getElementById("history").style.display ="none"
}
function clearHistory() {

    document.getElementById("history").innerHTML ="";
}