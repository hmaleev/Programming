//task 1
function task1 ()
{
	document.getElementById("demo").innerHTML="";
	var length=100;

for (var i = 0; i <=length; i++)
{
	document.getElementById("demo").innerHTML+=(" "+i);
};
}

//task 2
function task2 ()
{
	document.getElementById("task2").innerHTML="";
	var length=100;

for (var i = 0; i <=length; i++)
{
	if (i %21!=0) 
		{
			document.getElementById("task2").innerHTML+=" "+i;
		};
	
};
}
		
//task 3
function task3 ()
{
var sequence = new Array(42, 23, 2, 8, -51, -5);

sequence[0]=2;
sequence[1]=23;
sequence[2]=42;
sequence[3]=-8;	
var min=sequence[0];
var max=sequence[0];
	document.getElementById("task3").innerHTML="";
	for (var i = 0; i <sequence.length; i++) 
	{
		if (sequence[i]>max)
		{
			max=sequence[i];

		};
		if (sequence[i]<min)
		{
			min=sequence[i];
		};
	};
	document.getElementById("task3").innerHTML+="MAX: "+max+"</br>";
	document.getElementById("task3").innerHTML+="MIN: "+min;
}

//task 4
function task4 ()
{

}

