//task 1
function Task1 ()
{
var str="Proba";
var res;
var array = new Array();
var newarr = new Array();
array = str;
for (var i = 0, j = array.length-1; i < array.length; i++,j--)
{
    newarr [i] = array[j];
}
res = newarr.toString(newarr);
//document.getElementById("task1").innerHTML = res;
for (var i = 0; i < res.length; i++) {
    if (i % 2 === 0) {
        document.getElementById("task1").innerHTML += res[i];
    }
}
}

//task2
function Task2 ()
{

    var input = "((a+b)(/5-d)";
    var array = new Array();
    array = input;
    var countOpeningBracket = 0;
    var countClosingBracket = 0;
    for (var i = 0; i < array.length; i++)
    {
        if (array[i] == "(")
        {
            countOpeningBracket++;
        }
        if (array[i] == ")")
        {
            countClosingBracket++;
        }
    }
    if (countClosingBracket != countOpeningBracket) {
        document.getElementById("task2").innerHTML += "Invalid bracket expression";
    }
    else {
        document.getElementById("task2").innerHTML += "Valid bracket expression";
    }
}
		

//task 3
function Task3 ()
{
    var text = " We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
    var array = new Array();
    var test = "in"
    var count = 0;
    var subString
    array = text.split(" ");
    for (var i = 0; i < array.length; i++) {
        subString = array[i].toString();
        if ( subString.contains(test))
        {
            count++;
        }
        if (subString === test) {
            count++;

        }

    }

    //document.getElementById("task3").innerHTML += array;
    document.getElementById("task3").innerHTML += count;

}

//task 4
function Task4 ()
{
    var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>ANYthing</lowcase> else.";

    var upCaseBegining = "<upcase>";
    var upCaseEnd = "</upcase>"
    var lowCaseBegining = "<lowcase>";
    var lowCaseEnd = "</lowcase>"
    var isLowCase = false;
    var array = new Array();
    var isUpCase = false;
    array = text.split(" ");
    var subString;
    for (var i = 0; i < array.length; i++) {
        subString = array[i];
        //--------upper casing-----------
        if (subString.contains(upCaseBegining)) {
            isUpCase = true;
            //subString.contains("</upcase>");

        }
        if (isUpCase === true) {
            array[i] = subString.toUpperCase();


        }
        if (subString.contains(upCaseEnd)) {
            isUpCase = false;
        }
        //-----lower casing----------
        if (subString.contains(lowCaseBegining)) {
            isLowCase = true;
            //subString.contains("</upcase>");

        }
        if (isLowCase === true) {
            array[i] = subString.toLowerCase();


        }
        if (subString.contains(lowCaseEnd)) {
            isLowCase = false;
        }
        //-----mix casing------------

    }
    document.getElementById("task4").innerHTML += array;
}


//task 5
function Task5 ()
{
	

}



//task 6
function Task6 ()
{
	
}

//task 7
function Task7 ()
{

    var text = "http://www.gong.bg/forum/index.php";
    var protocol = "";
    var server="";
    var resource="";
    var isProtocol = true;
    var isServer = false;
    var isResource = false

    var length = text.length;
    for (var i = 0; i < length; i++)
    {
        //--------protocol------------
        if (isProtocol === true && text[i] !== ":") {
            protocol += text[i];
        }
        else {
            isProtocol = false;
        }
        if (isProtocol === false && text[i]==="w" )
        {
            isServer=true;
            
        }
        //-------------server---------
        if (isServer===true && text[i]!=="/") {
            server+=text[i];
        }
        else {
            isServer = false;
        }
        //-----resource-----------
        if (isServer === false && isProtocol === false )
        {
            resource += text[i];
        }
    }
    resource = resource.replace('://', "");
    document.getElementById("task7").innerHTML += protocol + "</br>";
    document.getElementById("task7").innerHTML += server + "</br>";
    document.getElementById("task7").innerHTML += resource;
}