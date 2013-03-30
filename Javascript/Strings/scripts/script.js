//task 1
function Task1 ()
{
var str="Levski";
var res;
var array = new Array();
var newarr = new Array();
array = str;
for (var i = 0, j = array.length-1; i < array.length; i++,j--)
{
    newarr [i] = array[j];
}
res = newarr.toString();
document.getElementById("task1").innerHTML = res;

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


}

//task 4
function Task4 ()
{
	
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

	
}