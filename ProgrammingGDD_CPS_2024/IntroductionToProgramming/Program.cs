//Task 10c
var numbers = new List<int>();

for (var i = 0; i < 4; i++)
{
    Console.WriteLine("Enter a number");

    numbers.Add(int.Parse(Console.ReadLine()));
}

var sum = 0;

foreach (var number in numbers)
    sum += number;

var average = sum / (double)numbers.Count;

Console.WriteLine($"The sum is {sum} and average is {average}");


//Task 10b
//var numbers = new int[4];

//for (var i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("Enter a number");

//    numbers[i] = int.Parse(Console.ReadLine());
//}

//var sum = 0;

//for (var i = 0; i < numbers.Length; i++)
//    sum += numbers[i];

//var average = sum / (double)numbers.Length;

//Console.WriteLine($"The sum is {sum} and average is {average}");


//Task 8
//Console.WriteLine("Enter the first side of the triangle");
//var a = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter the second side of the triangle");
//var b = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter the third side of the triangle");
//var c = double.Parse(Console.ReadLine());

//var perimeter = a + b + c;

//var p = perimeter / 2;

//var area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

//Console.WriteLine($"Area is {area} and perimeter is {perimeter}");

//Task 6,7 - HOMEWORK

//Task 5
//Console.WriteLine("Enter the radius");

//var radius = double.Parse(Console.ReadLine());

//var area = Math.PI * radius * radius;

//Console.WriteLine($"The area is {area}");

//Task 4
//Console.WriteLine("What is your name?");

//string name = Console.ReadLine();

//Console.WriteLine($"Hello {name}");

//Task 3d
//string name = "Marcin";
//Console.WriteLine($"Hello {name}");

//Task 3c
//string name = "Marcin";
//Console.WriteLine(string.Format("Hello {0}", name));

//Task 3b
//string name = "Marcin";
//Console.WriteLine("Hello " + name);

//Task 3a
//string name = "Marcin";

//Console.Write("Hello ");
//Console.WriteLine(name);

//Task 2
//string name = "Marcin";

//Console.WriteLine(name);

//Task 1
//Console.WriteLine("Hello");
