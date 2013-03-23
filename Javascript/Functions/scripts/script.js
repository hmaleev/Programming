//task 1
function Task1 ()
{
	document.getElementById("task1").innerHTML="";
	var number =42;
	var result;

	LastDigit(number);
	function LastDigit (number)
	{ 
		var digit = number%10;
		switch (digit)
		{
			case 0: result="Zero"; break;
			case 1: result="One"; break;
			case 2: result="Two"; break;
			case 3: result="Three";break;
			case 4: result="Four";break;
			case 5: result="Five";break;
			case 6: result="Six";break;
			case 7: result="Seven";break;
			case 8: result="Eight";break;
			case 9: result="Nine";break;
			default: result="Not a valid number"; break;
		}
		document.getElementById("task1").innerHTML=result;
	}

}
function Task2 ()
{
	document.getElementById("task2").innerHTML;
	var number =4205;
	var arr1 = new Array();
	var result;
	var j=0;

	for (var i = number; i > 1; i/=10)
	{

		arr1[j]=parseInt(i%10);	
		j++;
	};

	result = arr1.toString();

	document.getElementById("task2").innerHTML=result;
}
		
//task 3
function Task3 ()
{
var text = "Tomorrow will be the exam . The exam will begin at 10";
var word ="exam";
//var arr1 = new Array();
arr1 = text.split(" " ||".");
	document.getElementById("task3").innerHTML=arr1;
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