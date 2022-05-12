// See https://aka.ms/new-console-template for more information

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
var query = from n in numbersLinq
            where n < 3
            select n;
//Step 3: Excuting the query
foreach (int number in query)
{
    Console.WriteLine(number);
}

//........................................................................................................




































