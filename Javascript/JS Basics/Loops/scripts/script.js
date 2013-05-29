//task 1
function PrintNumbers ()
{
	document.getElementById("printNumbersResult").innerHTML="";
	var length=100;

for (var i = 0; i <=length; i++)
{
	document.getElementById("printNumbersResult").innerHTML+=(" "+i);
};
}

//task 2
function NotDivisibleNumbers ()
{
	document.getElementById("NotDivisibleNumbersResult").innerHTML="";
	var length=100;

for (var i = 0; i <=length; i++)
{
	if (i %21!=0) 
		{
			document.getElementById("NotDivisibleNumbersResult").innerHTML+=" "+i;
		};
	
};
}
		
//task 3
function MinAndMaxInSequnce ()
{
var sequence = new Array(42, 23, 2, 8, -51, -5);

sequence[0]=2;
sequence[1]=23;
sequence[2]=42;
sequence[3]=-8;	
var min=sequence[0];
var max=sequence[0];
	document.getElementById("MinAndMaxInSequnceResult").innerHTML="";
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
	document.getElementById("MinAndMaxInSequnceResult").innerHTML+="MAX: "+max+"</br>";
	document.getElementById("MinAndMaxInSequnceResult").innerHTML+="MIN: "+min;
}

//task 4
function MinAndMaxProperty ()
{
document.getElementById("MinAndMaxPropertyResult").innerHTML="";
var min="ZZ";
var max="AA";
for(var i in document)
{
	if (i<min) 
		{
			min=i;
		}
	if (max<i) 
	{
		max=i;
	}
}	document.getElementById("MinAndMaxPropertyResult").innerHTML+="Document propeties: "+"</br>";
	document.getElementById("MinAndMaxPropertyResult").innerHTML+="MAX: "+max+"</br>";
	document.getElementById("MinAndMaxPropertyResult").innerHTML+="MIN: "+min+"</br>";

	for(var property in window)
{
	if (property<min) 
		{
			min=property;
		}
	if (max<property) 
	{
		max=property;
	}
}	document.getElementById("MinAndMaxPropertyResult").innerHTML+="Window propeties: "+"</br>";
	document.getElementById("MinAndMaxPropertyResult").innerHTML+="MAX: "+max+"</br>";
	document.getElementById("MinAndMaxPropertyResult").innerHTML+="MIN: "+min+"</br>";
var min="z";
var max="a";
for(var property in navigator)
{
	if (property<min) 
		{
			min=property;
		}
	if (max<property) 
	{
		max=property;
	}
}	document.getElementById("MinAndMaxPropertyResult").innerHTML+="Navigator propeties: "+"</br>";
	document.getElementById("MinAndMaxPropertyResult").innerHTML+="navigator MAX: "+max+"</br>";
	document.getElementById("MinAndMaxPropertyResult").innerHTML+="MIN: "+min+"</br>";

}

