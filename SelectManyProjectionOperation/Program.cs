// See https://aka.ms/new-console-template for more information
using UI.Models;

Console.WriteLine("Hello, World!");


Console.WriteLine("LINQ SELECT MANY PROJECTION OPERATION:");
//LINQ SELECT MANY PROJECTION OPERATION

List<Student> students = new List<Student>();

void Initialize()
{
    students.Add(new Student(101, "James", "Smith"));
    students.Add(new Student(102, "Robert", "Michael"));
    //students.Add(new Student(103, "Maria", "Johnson"));
    //students.Add(new Student(104, "David", "Smith"));
    //students.Add(new Student(105, "Emma", "Dalot"));
    //students.Add(new Student(106, "Chika", "Smith"));
    //students.Add(new Student(107, "Obinna", "Obi"));
    //students.Add(new Student(108, "Emeka", "Michael"));
}

Initialize();




Console.WriteLine("Query Syntax:");
//Query Syntax
var query = from student in students
            from a in student.FirstName.ToArray()
            select a;

foreach (var item in query)
{
    Console.WriteLine(item);
}


Console.WriteLine("...............................................................................");


Console.WriteLine("Method Syntax:");
//Method Syntax
var method = students.SelectMany(student => student.FirstName.ToArray(), (students, a) => (a));

foreach (var item in method)
{
    Console.WriteLine(item);
}

