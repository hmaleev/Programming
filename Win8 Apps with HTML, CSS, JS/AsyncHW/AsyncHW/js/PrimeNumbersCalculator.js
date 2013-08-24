///<reference path ="//Microsoft.WinJS.1.0/js/base.js" />

var isPrime = function (number) {
    for (var i = 2; i < number; i++) {
        if (number % i == 0) {
            return false;
        }
    }
    return true;
}

var calculatePrimesByRange = function (fromNumber, toNumber) {
    var primesList = [];

    for (var num = fromNumber; num <= toNumber; num++) {
        if (isPrime(num)) {
            primesList.push(num);
        }
    }

    return primesList;
}

var calculatePrimes = function (numbersCount) {
    var primesList = [];
    var primesCount = 0;
    for (var num = 0; ;num++) {
        if (isPrime(num)) {
            primesList.push(num);
            primesCount++
        }
        if (primesCount==numbersCount) {
            break;
        }
    }
    return primesList;
}

var calculatePrimesToNumber = function (number) {
    var primesList = [];
   
    for (var num = 0; num<number ; num++) {
        if (isPrime(num)) {
            primesList.push(num);
           
        }
    }
    return primesList;
}

onmessage = function (event) {
    var firstNumber = event.data.firstNumber;
    var lastNumber = event.data.lastNumber;

    var primes = calculatePrimesByRange(firstNumber, lastNumber);
    var primesByNumber = calculatePrimes(firstNumber);
    var primesToNumber = calculatePrimesToNumber(firstNumber);
    postMessage(primesToNumber);
    postMessage(primesByNumber);
    postMessage(primes);
}
