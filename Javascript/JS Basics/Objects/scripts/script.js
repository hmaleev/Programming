//task 1
function Task1 ()
{
    var pointA = {
        coordinateX: 1, coordinateY: 1
    };
    var pointB = {
        coordinateX: 2, coordinateY: 1
    };
    var pointC = {
        coordinateX: 2, coordinateY: 4
    };
    var lineAB = {
        pointA: pointA,
        pointB: pointB
    };
    var lineAC = {
        pointA: pointA,
        pointC: pointC
    };
    var lineBC = {
        pointB: pointB,
        pointC: pointC
    };
        
function DistanceBetweenTwoPoints(pointA,pointB)
{
	return Math.sqrt(Math.pow((pointA.coordinateX-pointB.coordinateX),2) +Math.pow((pointA.coordinateY-pointB.coordinateY),2)) 
}
function CreationOfTriangle(LineA, LineB, LineC) {
    if ((LineA < LineB + LineC) && (LineB < LineA + LineC) && (LineC < LineA + LineB)) {
        return true;
    }
    else {
        return false;
    }
}


document.getElementById("task1").innerHTML += "The distance between points B and C is: " + DistanceBetweenTwoPoints(pointB, pointC) + "</br>";
var createTriangle = CreationOfTriangle(lineAB, lineAC, lineBC);

if (createTriangle == true) {
    document.getElementById("task1").innerHTML += "These lines can create a triangle";
}
else {
    document.getElementById("task1").innerHTML += "These lines can not create a triangle";
}

}

//task2
function Task2 ()
{
	var arr = [1,2,1,4,1,3,4,1,111,3,2,1,"1"];
	var newArr = new Array();
	var number=1;
	for (var i = 0,j=0; i <arr.length; i++)
	{

		if (arr[i]===number)
		{
			continue;
		}
		else
		{
			newArr[j]=arr[i];
			j++;
		};
	};
	document.getElementById("task2").innerHTML=newArr;
}
		

//task 3
function Task3 ()
{

}

//task 4
function Task4 ()
{

}


//task 5
function Task5 ()
{
    var persons = [
  { firstname: "Gosho", lastname: "Petrov", age: 32 },
  { firstname: "Bay", lastname: "Ivan", age: 38 },
  { firstname: "Gosho", lastname: "Georgiev", age: 42 },
  { firstname: "Ivan", lastname: "Ivanov", age: 18 }, ];
    var minAge=persons[0].age;
    var index=0;
    for (var i = 0; i < persons.length; i++)
    {
        if (persons[i].age<minAge)
        {
            minAge=persons[i].age;
          
            index=i;
        }
    }
    document.getElementById("task5").innerHTML = "The youngest person is: "+ persons[index].firstname + " " + persons[index].lastname;
}


//task 6
function Task6 ()
{

}
