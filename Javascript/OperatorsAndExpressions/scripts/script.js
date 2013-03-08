//task 1
function task1 ()
 {
	var a =prompt ("Please choose a number to check");

	if (a%2==0) 
	{
		alert("The result is: Even")
	} 
	else
	{
	alert("The result is: Odd")
	};
}

//task 2
function task2 ()
{
	var check = false;
	var number=35;
	if (number%5==0 && number%7==0) 
		{
			check =true;
		}
		if (check==true)
		{
			alert("This number can be divided by both 5 and 7")
		} 
		else
		{
			alert("This number can't be divided by both	 5 and 7")
		};
}
		
//task 3
function task3 ()
{
var width=prompt("choose the length of the rectangle:");
var height=prompt("Choose the width of the rectangle");
var area;

area=width*height;
alert("The area is: "+area);
}

//task 4
function task4 ()
{
var number=1832;
var result;
number = number/100;
result=number%10
if (result%7>=0 && result%7<1)
 {
 	alert("the third digit is 7")
 }
  else
  	{
  		alert("the third digit isn't 7")
  	};
}

//task5
function task5()
{
	var number=16;
	var mask=1<<3;
	var result =number&mask;
	result=result>>3
	
	alert("The third bit in this number is: " +result);
}

//task6
function task6()
{
	var xCoordinate=5;
	var yCoordinate=2;
	var radius =5;
	var center=0;
	var result;
	var point;
	var circle;
	circle=Math.pow(radius,2)
	point=Math.pow( (xCoordinate-center) ,2) + Math.pow( (xCoordinate-center) ,2);
	if (point<circle) 
		{
			alert("the point is inside a circle")
		}
	else
	 	{
			alert("the point is not inside a circle")
	 	};

}
//task7

//task8
function task8()
{
	
}
