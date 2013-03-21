//task 1
function Task1 ()
{
	document.getElementById("task1").innerHTML="";
	var array = new Array ();
	for (var i = 0; i<20; i++) 
	{
		array[i]=i*5;
		document.getElementById("task1").innerHTML +=array[i] +" ";
	}

}
function Task2 ()
{
	document.getElementById("task2").innerHTML="";
	var firstArray = new Array ("a","z","d");
	var secondArray = new Array ("a","y","d");
	var equal =false;

	for (var i = 0; i <firstArray.length; i++) 
	{
		if (firstArray[i]==secondArray[i])
		 {
		 	equal=true;

		 }
		 else
		 {
		 	equal=false;
		 }
		if (equal==false && firstArray[i]>secondArray[i]) 
			{
				document.getElementById("task2").innerHTML +="The first array is larger lexicographically";
				break;
			}
		if (equal==false && firstArray[i]<secondArray[i]) 
			{
				document.getElementById("task2").innerHTML +="The first array is smaller lexicographically";
				break;
			};
		
	}
	if (equal==true)
	 {document.getElementById("task2").innerHTML +="The two arrays are equal"};

}
		
//task 3
function Task3 ()
{
var array = new Array (2, 1, 1, 2, 3, 3, 2, 2, 2, 1)
var count=1;
var max=1;
var result = new Array();

var startPosition;

for (var i = 0; i<array.length-1; i++) 
{
	if (array[i]==array[i+1]) 
	{
		count++;
		count;
		
	}
	else
	{
	   count=1;

	}
	if (max<count)
	{
	   max=count
	   console.log(max);
	   startPosition=i;
	   console.log(startPosition);
	   element=array[i];
	}

}

	for (var i = 0; i<max; i++) 
	{
		result[i]=element;
		document.getElementById("task3").innerHTML +=result[i]+" ";
	}
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

