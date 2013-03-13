//task 1
function task1 ()
{
	var a =42;
	var b=10;
	var c;
	if (a>b)
		{
			c=a;
			a=b;
			b=c;
			alert(a);
			alert(b);
		}

}

//task 2
function task2 ()
{
	var a=-5;
	var b=2;
	var c=5;
	var count=0;
	if (a<0)
	{
		count++;
	} 
	if (b<0)
	{
		count++;
	} 
	if (c<0)
	{
		count++;
	} 
	if (count%2==0) 
		{
			alert("The sign is +")
		}
	else
		{
			alert("The sign is -")
		};


}
		
//task 3
function task3 ()
{
	var a=prompt("a");
	var b=prompt("b");
	var c=prompt("c");
	var count=0;
	var max=a;
//	alert(max);
	
	if (a<b)
	{
		if (b<c)
		{
			max=c;
		} 
		else
		{
			max=b;
		}
	}
	else
	{
		if (a>c)
		{
			max=a;
		}
		else
		{
		max=c;
		};
	}
	alert("max: "+max);
	
	


}

//task 4
function task4 ()
{
	var a=prompt("a");
	var b=prompt("b");
	var c=prompt("c");
	var exchange;
	var count=0;
	var max=a;
//	alert(max);
	
	if (a<b)
	{
		if (b<c)
		{
			exchange=a;
			a=c;
			c=exchange;

		} 
		else
		{
			exchange=a;
			a=b;
			b=exchange;
			if (b<c) 
			{
				exchange=b;
				b=c;
				c=exchange;
			}
		}
	}
	else
	{
		if (b<c)
		{
			if (a>c)
			{
				exchange=b;
				b=c;
				c=exchange;
			} 
			else
			{};
		}

	}
	alert("Descending order: "+a+" "+b+" "+c);
}

//task5
function task5()
{
	var input=prompt("enter a digit:")
	input = parseInt(input);
switch (input)
{
	case 0:alert("Zero"); break;
	case 1: alert("One"); break;
	case 2: alert("Two"); break;
	case 3: alert("Three"); break;
	case 4: alert("Four"); break;
	case 5: alert("Five"); break;
	case 6: alert("Six"); break;
	case 7: alert("Seven"); break;
	case 8: alert("Eight"); break;
	case 9: alert("Nine"); break;
	default: alert("This is not a digit!"); break;
}

}

//task6
function task6()
{
	var a=2;
	var b=3;
	var c=-5;
	var x1;
	var x2;
	var D;

	D=Math.pow(b,2)-4*(a*c);
	x1= (-b +Math.sqrt(D) )/(2*a);
	x2= (-b -Math.sqrt(D) )/(2*a);
	alert("x1: "+x1+"\nx2: "+x2);
}



function task7()
{

}



//task8
function task8()
{

}
