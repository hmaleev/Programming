//task 1
function CheckForEvenNumber ()
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
function CheckDivison ()
{
	var check = false;
	var number=prompt ("Please choose a number to check");
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
function CalculateRectangleArea ()
{
var width=prompt("choose the length of the rectangle:");
var height=prompt("Choose the width of the rectangle");
var area;

area=width*height;
alert("The area is: "+area);
}

//task 4
function CheckThirdDigit ()
{
var number=prompt ("Please choose a number with at least 3 numbers to check");;
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
function CheckThirdBit()
{
	var number=prompt ("Please choose a number to check");;
	var mask=1<<3;
	var result =number&mask;
	result=result>>3
	
	alert("The third bit in this number is: " +result);
}

//task6
function FindPointInCircle()
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



function FindPrimeNumbers()
{
            var isPrime = true;
            
            alert("The Prime numbers between 1 and 100 are: ");

            for (var number = 2; number <= 100; number++)
            {
                for (var prime = 2; prime <= 100; prime++)
                {
                    if (number != prime && number % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }

                if (isPrime)
                {
 document.getElementById("result2").innerHTML=document.writeln(number);

                }
                isPrime = true;
            }
}



//task8
function CalculateTrapezoidArea()
{
	var a=4;
	var b=2;
	var h=2;
	var result;
	result=((a+b)/2)*h;
	alert("The area of the trapezoid is: "+result)
}
//task9

function task9()
{
	        var radius = 3;
            var x;
            var y;
            var a = 1;
            var b = 1;
            var top = 1;
            var left = -1;
            var width = 6;
            var height = 2;

            var input;
            var result;


            alert("please write the coordinate of x: ");
            input = Console.ReadLine();
            x = Double.Parse(input);
            alert("please write the coordinate of y: ");
            input = Console.ReadLine();
            y = Double.Parse(input);
            if ((x<5 && x>-1) && (y<1 && y>-1))
                alert("this point lies inside a rectangle" );
            else
                alert("this point does not lie inside a rectangle");

            //result = ((x-a) * (x-a)) + ((y-b) * (y-b));
            //if (result < (radius * radius))
            //    Console.WriteLine("the point is inside a circle");
            //else
            //    Console.WriteLine("This point isn't inside a circle");

}