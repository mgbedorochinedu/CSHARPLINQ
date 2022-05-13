// See https://aka.ms/new-console-template for more information

//SECTION ONE:
//......................................................................................................

Console.WriteLine("Using Existing .Net Features!");

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

foreach (int number in numbers)
{
    if(number < 3)
    Console.WriteLine(number);
}


//....................................................................................................

Console.WriteLine("Using LINQ");

//Step 1: Getting data source
List<int> numbersLinq = new List<int> { 1, 2, 3, 4, 5, 6 };

//Step 2: Writing query
IEnumerable<int> query = from n in numbersLinq   //Part 1: Data Source
            where n < 3                          //Part 2: Filter
            select n;                            //Part 3: Select
//Step 3: Excuting the query
foreach (int number in query)
{
    Console.WriteLine(number);
}

//........................................................................................................


//Problem Statements:

// Write a simple C# program to declare a list of integer values, followed by a simple LINQ query to check for even numbers, and finally print them to the console.
Console.WriteLine("Even Number Solutions");
List<int> inputs = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

IEnumerable<int> queryNumber = from n in inputs
                               where n % 2 == 0
                               select n;

foreach(int evenNumber in queryNumber)
{
    Console.WriteLine(evenNumber);
}

//..................................................................................................
































