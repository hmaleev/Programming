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

var array = new Array (3, 2, 3, 4, 5, 6, 4)
var count=1;
var max=1;
var result = new Array();

var startPosition;

for (var i = array.length-1; i>=0; i--) 
{
	 if (i>=1 && array[i]==array[i-1]+1)
	{
		count++;
		
		
	}
	else
	{
	   count=1;

	}
	if (max<count)
	{
	   max=count
	  
	   startPosition=i-1;
	  
	  
	}

}
document.getElementById("task4").innerHTML +="The longest increasing sequence is:</br>"
;
	for (var i = 0; i<max; i++,startPosition++) 
	{
		result[i]=array[startPosition];
		document.getElementById("task4").innerHTML +=result[i]+" ";
	}

}

//task 5
function Task5 ()
{
	var array = new Array (4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 );

    var  number;
    var  exchange;
    var  count=1;
    var  maxCount = 0;
    var element=0;
   for (var i = 0; i < array.length; i++)
            {
                for (var j = i + 1; j < array.length; j++)
                {
                    if (array[i] > array[j])
                    {
                        exchange = array[i];
                        array[i] = array[j];
                        array[j] = exchange;
                    }

                }
            }
    for (var i = 01; i < array.length; i++)
     {
     document.getElementById("task5").innerHTML +=array[i]+" ";
    };
}

//task 6
function Task6 ()
{
	var array = new Array (4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 );

    var  number;
    var  exchange;
    var  count=1;
    var  maxCount = 0;
    var element=0;
   for (var i = 0; i < array.length; i++)
            {
                for (var j = i + 1; j < array.length; j++)
                {
                    if (array[i] > array[j])
                    {
                        exchange = array[i];
                        array[i] = array[j];
                        array[j] = exchange;
                    }

                }
            }
            for (var i = 0; i < array.length-2; i++)
            {
                if (array[i]==array[i+1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count>maxCount)
                {
                    maxCount = count;
                    element = array[i];
                }

            }
            document.getElementById("task6").innerHTML +="The most frequent element is:"+element+" - " +maxCount+"times";
}




//task 7
function Task7 ()
{
   			var array = new Array (5,2,4,3,6,1,7,8);
            var number = 4;
            var exchange;
            var min = 0;
            var max = array.length - 1;
            var mid = (min + max) / 2;

            for (var i = 0; i < array.length; i++)
            {
                for (var j = i + 1; j < array.length-1; j++)
                {
                    if (array[i] > array[j])
                    {
                        exchange = array[i];
                        array[i] = array[j];
                        array[j] = exchange;
                    }
                }
            }          
            while( mid < array.length)
            {
                if (array[mid] > number)
                {
                    max = mid;
                    mid = (max + min) / 2;
                    continue;
                   
                }
                else if (array[mid] < number)
                {
                    min = mid ;
                    mid = (min + max) / 2;
                }
                if (array[mid]==number)
                {
		document.getElementById("task7").innerHTML +=mid+" ";

                  break;
                }
            }

}

