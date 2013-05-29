//task 1
function task1 ()
{
	var firstNumber =42;
	var secondNumber=10;
	var exchange;
	if (firstNumber>secondNumber)
		{
			exchange=firstNumber;
			firstNumber=secondNumber;
			secondNumber=exchange;
			
			alert("After the exchange the first number is: "+firstNumber);
			alert("After the exchange the second number is: "+secondNumber);
		}

}

//task 2
function task2 ()
{
	var firstNumber=parseInt(prompt("enter first number:"));
	var secondNumber=parseInt(prompt("enter second number:"));
	var thirdNumber=parseInt(prompt("enter third number:"));
	var count=0;
	if (firstNumber<0)
	{
		count++;
	} 
	if (secondNumber<0)
	{
		count++;
	} 
	if (thirdNumber<0)
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
	var firstNumber=parseInt(prompt("enter first number:"));
	var secondNumber=parseInt(prompt("enter second number:"));
	var thirdNumber=parseInt(prompt("enter third number:"));
	var count=0;
	var max=firstNumber;
//	alert(max);
	
	if (firstNumber<secondNumber)
	{
		if (secondNumber<thirdNumber)
		{
			max=thirdNumber;
		} 
		else
		{
			max=secondNumber;
		}
	}
	else
	{
		if (firstNumber>thirdNumber)
		{
			max=firstNumber;
		}
		else
		{
		max=thirdNumber;
		};
	}
	alert("max: "+max);
	
	


}

//task 4
function task4 ()
{
	var firstNumber=parseInt(prompt("enter first number:"));
	var secondNumber=parseInt(prompt("enter second number:"));
	var thirdNumber=parseInt(prompt("enter third number:"));
	var exchange;
	var count=0;
	var max=firstNumber;
//	alert(max);
	
	if (firstNumber<secondNumber)
	{
		if (secondNumber<thirdNumber)
		{
			exchange=firstNumber;
			firstNumber=thirdNumber;
			thirdNumber=exchange;

		} 
		else
		{
			exchange=firstNumber;
			firstNumber=secondNumber;
			secondNumber=exchange;
			if (secondNumber<thirdNumber) 
			{
				exchange=secondNumber;
				secondNumber=thirdNumber;
				thirdNumber=exchange;
			}
		}
	}
	else
	{
		if (secondNumber<thirdNumber)
		{
			if (firstNumber>thirdNumber)
			{
				exchange=secondNumber;
				secondNumber=thirdNumber;
				thirdNumber=exchange;
			} 
			
		}

	}
	alert("Descending order: "+firstNumber+" "+secondNumber+" "+thirdNumber);
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

    var max=0;      
    var firstNumber = parseInt( prompt("Please enter the first number:"));
    var secondNumber = parseInt( prompt("Please enter the second number:"));
 	var	thirdNumber = parseInt( prompt("Please enter the thied number:"));
 	var	fourthNumber = parseInt( prompt("Please enter the fourth number:"));
  	var	fifthNumber = parseInt( prompt("Please enter the fifth number:"));

        if (firstNumber != secondNumber | firstNumber != thirdNumber)
        {
            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    max = firstNumber;
                }
                else
                {
                    max = thirdNumber;
                }
            }
            else
            {
                if (secondNumber > thirdNumber)
                {
                    max = secondNumber;
                }
                else
                {
                    max = thirdNumber;
                }
            }
        }
       

            if (fourthNumber > fifthNumber)
            {
                if (max > fourthNumber)
                {
                    alert("The biggest number is: "+ max);
                }
                else
                {
                   alert("The biggest number is: "+ fourthNUmber);
                }
            }
            else
            {
                if (max > fifthNumber)
                {
                   alert("The biggest number is: " +max);
                }
                else
                {
                    alert("The biggest number is: " +fifthNumber);
                }
            }

}



//task8
function task8()
{
var input =parseInt(prompt("number:"));
var res;
var output="";

res = parseInt(input/100);
if (res>0) 
{
	switch (res)
	{
		//case 0: output ="Zero"; break;
		case 1: output ="One Hundred"; break;
		case 2: output ="Two Hundred"; break;
		case 3: output ="Three Hundred"; break;
		case 4: output ="Four Hundred"; break;
		case 5: output ="Five Hundred"; break;
		case 6: output ="Six Hundred"; break;
		case 7: output ="Seven Hundred"; break;
		case 8: output ="Eight Hundred"; break;
		case 9: output ="Nine Hundred"; break;
		default: alert("Out of Range"); break;
	}
};

res = parseInt((input/10)%10);
if (res!=0 && res!=1)
{
	switch (res)
	{
		

		//case 1: output ="One Hundred"; break;
		case 2: output +=" Twenty"; break;
		case 3: output +=" Thirty"; break;
		case 4: output +=" Fourty"; break;
		case 5: output +=" Fifty"; break;
		case 6: output +=" Sixty"; break;
		case 7: output +=" Seventy"; break;
		case 8: output +=" Eighty "; break;
		case 9: output +=" Ninety"; break;
		//default: alert("Out of Range"); break;
	}
		switch (input%10)
	{
		

		case 1: output ="One"; break;
		case 2: output +=" Two"; break;
		case 3: output +=" Three"; break;
		case 4: output +=" Four"; break;
		case 5: output +=" Five"; break;
		case 6: output +=" Six"; break;
		case 7: output +=" Seven"; break;
		case 8: output +=" Eight "; break;
		case 9: output +=" Nine"; break;
		//default: alert("Out of Range"); break;
	}
}


else
{
	if (res==0) 
		{	res=parseInt(input%10)
			switch (res)
			{
				//case 0: output ="Zero"; break;
				//case 1: output ="One Hundred"; break;
				case 2: output +=" Two"; break;
				case 3: output +=" Three"; break;
				case 4: output +=" Four"; break;
				case 5: output +=" Five"; break;
				case 6: output +=" Six"; break;
				case 7: output +=" Seven"; break;
				case 8: output +=" Eight "; break;
				case 9: output +=" Nine"; break;
				//default: alert("Out of Range"); break;
			}
		}
		
	if (res==1) 
	{
		res=parseInt(input%10)
			switch (res)
			{
				case 0: output +=" Ten"; break;
				case 1: output +=" Eleven"; break;
				case 2: output +=" Twelve"; break;
				case 3: output +=" Thirteen"; break;
				case 4: output +=" Fourteen"; break;
				case 5: output +=" Fifteen"; break;
				case 6: output +=" Sixteen"; break;
				case 7: output +=" Seventeen"; break;
				case 8: output +=" Eighteen "; break;
				case 9: output +=" Nineteen"; break;
				//default: alert("Out of Range"); break;
			}
	}
} 
	alert(output)
}
