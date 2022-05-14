// See https://aka.ms/new-console-template for more information


//Difference between Query and Method Syntax
Console.WriteLine("Difference between Query and Method Syntax");


//SECTION TWO:
//Query Syntax
Console.WriteLine("Using Query LINQ Syntax");

List<int> numbersQuery= new List<int> { 1, 2, 3, 4, 5, 6 };

IEnumerable<int> query = from n in numbersQuery                 //Part 1: Data Source
                         where n < 3                          //Part 2: Filter
                         select n;                            //Part 3: Select

foreach (int number in query)
{
    Console.WriteLine(number);
}

//.............................................................................................................


//Method Syntax
Console.WriteLine("Using LINQ Method Syntax");

List<int> numbersMethod = new List<int> { 1, 2, 3, 4, 5, 6 };

IEnumerable<int> method = numbersMethod.Where(i => i < 3);

foreach (int number in method)
{
    Console.WriteLine(number);
}

//.....................................................................................................
Console.WriteLine("Section Two: Problem Solving");
//Problem Statements:

//Write a simple C# program to declare a list of integer numbers, followed by writing queries using both query and method syntax to calculate their square (num * num), and finally print them to the console.

//Method Syntax 
Console.WriteLine("Method Syntax:");
List<int> assNumsMethod = new List<int> { 1, 2, 3, 4, 5};

IEnumerable<int> assMethod = assNumsMethod.Select(n => (n * n));

foreach (int number in assMethod)
{
    Console.WriteLine(number);
}

//.....................................................................................................................
Console.WriteLine("Query Syntax:");
//Query Syntax

List<int> assNumsQuery = new List<int> { 1, 2, 3, 4, 5 };

IEnumerable<int> assQuery = from n in assNumsQuery
                            select n * n;
foreach(int number in assQuery)
{
    Console.WriteLine(number);
}





