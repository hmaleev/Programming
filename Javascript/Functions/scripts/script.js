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

//task2
function Task2 ()
{
	document.getElementById("task2").innerHTML;
	var number =4205;
	var arr1 = new Array();
	var result;
	

	for (var i = number, j=0; i > 1; i/=10)
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
	var inputText = document.getElementById("inputText").value;
	var inputWord =document.getElementById("inputWord").value;

	searchForWord(inputText,inputWord,"no")

	function searchForWord (inputText,inputWord,type)
	{
		var text =inputText;
		var word=inputWord;
		var arr1 = new Array();

		switch(type)
		{
			case "yes":
				{
					var count =0;
					arr1=text.split(" ");
					for (var i = 0; i < arr1.length; i++)
					{	
						if (arr1[i]==word)
						{
							count++;
						}
					};
					document.getElementById("task3").innerHTML+=count;
					break;
				}
			case "no":
				{
					var count =0;
					text=text.toLowerCase();
					arr1=text.split(" ");
					for (var i = 0; i < arr1.length; i++)
					{	
						if (arr1[i]==word)
						{
							count++;
						}
					};
					document.getElementById("task3").innerHTML+=count;
					break;
				}
		}
	}

}

//task 4
function Task4 ()
{
	var webPage=document.getElementsByTagName("div");
	var count=webPage.length;
	document.getElementById("task4").innerHTML=count;
}


//task 5
function Task5 ()
{
	var inputText = document.getElementById("inputNumber").value;
	var number=document.getElementById("Number2").value;
	var arr1=inputText.split(" "||",");

	var count=0;
		for (var i = 0; i <=arr1.length; i++)
		{
				if (arr1[i]==number)
				{
					count++;
				};
		};
	document.getElementById("task5").innerHTML=count;

}



//task 6
function Task6 ()
{
	var isBigger =false;
	var inputText = document.getElementById("inputNumber3").value;
	var position=parseInt( document.getElementById("position").value);

	var array=inputText.split(" "||",");

	if (array[position]>array[position-1] && array[position]>array[position+1])
	{
		isBigger=true;
		document.getElementById("task6").innerHTML+=isBigger;
	}
	else
	{
		isBigger=false;
		document.getElementById("task6").innerHTML+=isBigger;
	}
}

//task 7
function Task7 ()
{

	var isBigger =false;
	var inputText = document.getElementById("inputNumber5").value;
	var array=inputText.split(" "||",");


	for (var position = 1; position <array.length-1; position ++) 
	{
		if (array[position]>array[position-1] && array[position]>array[position+1])
		{
			isBigger=true;
			document.getElementById("task7").innerHTML+="Thie index of the first number bigger than its neighbours is: "+ position;
		}
		else
		{
			isBigger=false;
			document.getElementById("task7").innerHTML+="-1" + " (There is no element bigger than its neighbours)";
		}
	};
}