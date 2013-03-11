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

}

//task5
function task5()
{

}

//task6
function task6()
{

}



function task7()
{

}



//task8
function task8()
{

}
