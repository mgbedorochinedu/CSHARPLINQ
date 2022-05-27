// See https://aka.ms/new-console-template for more information
using UI.Models;

Console.WriteLine("Hello, World!");


List<Student> students = new List<Student>();

void Initialize()
{
    students.Add(new Student(101, "James", "Smith"));
    students.Add(new Student(102, "Robert", "Michael"));
    students.Add(new Student(103, "Maria", "Johnson"));
    students.Add(new Student(105, "Emma", "Dalot"));
    students.Add(new Student(106, "Chika", "Smith"));
    students.Add(new Student(107, "Obinna", "Obi"));
    students.Add(new Student(108, "Emeka", "Michael"));
}



//Initializing the fucntion
Initialize();

//Console.WriteLine(" OrderBy Query Syntax:");
////Query Syntax
//IEnumerable<Student> query = from student in students
//                             orderby student.FirstName
//                             select student;

//foreach (Student item in query)
//{
//    Console.WriteLine($"{item.FirstName} {item.LastName}");
//}

//Console.WriteLine(" OrderBy Method Syntax:");
////Method Syntax
//IEnumerable<Student> methodQuery = students.OrderBy(s => s.FirstName);

//foreach (Student item in methodQuery)
//{
//    Console.WriteLine($"{item.FirstName} {item.LastName}");
//}


//.................................................................................................................................................................
//===================================================================================================================================



Console.WriteLine(" OrderByDescending Query Syntax:");
//Query Syntax
IEnumerable<Student> query = from student in students
                             orderby student.FirstName descending
                             select student;

foreach (Student item in query)
{
    Console.WriteLine($"{item.FirstName} {item.LastName}");
}

Console.WriteLine(" OrderByDescending Method Syntax:");
//Method Syntax
IEnumerable<Student> methodQuery = students.OrderByDescending(s => s.FirstName);

foreach (Student item in methodQuery)
{
    Console.WriteLine($"{item.FirstName} {item.LastName}");
}
