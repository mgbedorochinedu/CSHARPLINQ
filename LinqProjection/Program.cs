// See https://aka.ms/new-console-template for more information
using UI.Models;

Console.WriteLine("Projection Operation:");


////Projection Operation

//List<Student> students = new List<Student>();

//void Initialize()
//{
//    students.Add(new Student(101, "James", "Smith"));
//    students.Add(new Student(102, "Robert", "Michael"));
//    students.Add(new Student(103, "Maria", "Johnson"));
//    students.Add(new Student(104, "David", "Smith"));
//    students.Add(new Student(105, "Emma", "Dalot"));
//    students.Add(new Student(106, "Chika", "Smith"));
//    students.Add(new Student(107, "Obinna", "Obi"));
//    students.Add(new Student(108, "Emeka", "Michael"));
//}

//Initialize();




//Console.WriteLine("Query Syntax:");
////Query Syntax
//var query = from student in students
//                              select (student.StudentId, student.LastName);

//foreach (var item in query)
//{
//    Console.WriteLine($"{item.StudentId} {item.LastName}");
//}


//Console.WriteLine("...............................................................................");


//Console.WriteLine("Method Syntax:");
////Method Syntax
//IEnumerable<Student> method = students.Select(student => student);

//foreach (Student item in method)
//{
//    Console.WriteLine($"{item.FirstName} {item.LastName}");
//}




Console.WriteLine("LINQ SELECT ANNONYMOUS:");
//LINQ SELECT ANNONYMOUS

List<Student> students = new List<Student>();

void Initialize()
{
    students.Add(new Student(101, "James", "Smith"));
    students.Add(new Student(102, "Robert", "Michael"));
    students.Add(new Student(103, "Maria", "Johnson"));
    students.Add(new Student(104, "David", "Smith"));
    students.Add(new Student(105, "Emma", "Dalot"));
    students.Add(new Student(106, "Chika", "Smith"));
    students.Add(new Student(107, "Obinna", "Obi"));
    students.Add(new Student(108, "Emeka", "Michael"));
}

Initialize();




Console.WriteLine("Query Syntax:");
//Query Syntax
var query = from student in students
            select new
            {
                Id = student.StudentId,
                Name = student.FirstName + student.LastName
            };

foreach (var item in query)
{
    Console.WriteLine($"{item.Id} {item.Name}");
}


Console.WriteLine("...............................................................................");


Console.WriteLine("Method Syntax:");
//Method Syntax
var method = students.Select(student => new  {
    Id = student.StudentId,
    Name = student.FirstName + student.LastName
});

foreach (var item in method)
{
    Console.WriteLine($"{item.Id} {item.Name}");
}



