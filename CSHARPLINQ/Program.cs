// See https://aka.ms/new-console-template for more information
using CSHARPLINQ;
using CSHARPLINQ.Model;

//SECTION ONE:
//......................................................................................................

//Console.WriteLine("Using Existing .Net Features!");

//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

//foreach (int number in numbers)
//{
//    if(number < 3)
//    Console.WriteLine(number);
//}


//....................................................................................................

//Console.WriteLine("Using Query LINQ Syntax");

////Step 1: Getting data source
//List<int> numbersLinq = new List<int> { 1, 2, 3, 4, 5, 6 };

////Step 2: Writing query
//IEnumerable<int> query = from n in numbersLinq   //Part 1: Data Source
//            where n < 3                          //Part 2: Filter
//            select n;                            //Part 3: Select
////Step 3: Excuting the query
//foreach (int number in query)
//{
//    Console.WriteLine(number);
//}

//........................................................................................................


//Problem Statements: Section One

//// Write a simple C# program to declare a list of integer values, followed by a simple LINQ query to check for even numbers, and finally print them to the console.
//Console.WriteLine("Even Number Solutions");
//List<int> inputs = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

//IEnumerable<int> queryNumber = from n in inputs
//                               where n % 2 == 0
//                               select n;

//foreach(int evenNumber in queryNumber)
//{
//    Console.WriteLine(evenNumber);
//}

//======================================================================================================================

//SELECT MANY PROJECTION OPERATION
//Console.WriteLine("LINQ SELECT MANY PROJECTION OPERATION:");
////LINQ SELECT MANY PROJECTION OPERATION

//List<Student> students = new List<Student>();

//void Initialize()
//{
//    students.Add(new Student(101, "James", "Smith"));
//    students.Add(new Student(102, "Robert", "Michael"));
//    //students.Add(new Student(103, "Maria", "Johnson"));
//    //students.Add(new Student(104, "David", "Smith"));
//    //students.Add(new Student(105, "Emma", "Dalot"));
//    //students.Add(new Student(106, "Chika", "Smith"));
//    //students.Add(new Student(107, "Obinna", "Obi"));
//    //students.Add(new Student(108, "Emeka", "Michael"));
//}

//Initialize();




//Console.WriteLine("Query Syntax:");
////Query Syntax
//var query = from student in students
//            from a in student.FirstName.ToArray()
//            select a;

//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}


//Console.WriteLine("...............................................................................");


//Console.WriteLine("Method Syntax:");
////Method Syntax
//var method = students.SelectMany(student => student.FirstName.ToArray(), (students, a) => (a));

//foreach (var item in method)
//{
//    Console.WriteLine(item);
//}

//=============================================================================================================






//=======================================================================================
//JOIN OPERATIONS  ======================================================================
//=======================================================================================




List<Student> students = new List<Student>();
List<Course> courses = new List<Course>();

void Initialize()
{
    students.Add(new Student(101, "James", "Smith", 1));
    students.Add(new Student(102, "Robert", "Michael", 2));
    students.Add(new Student(103, "Maria", "Johnson", 3));
    students.Add(new Student(104, "David", "Smith", 1));
    students.Add(new Student(105, "Emma", "Dalot", 2));
    students.Add(new Student(106, "Chika", "Smith", 3));
    students.Add(new Student(107, "Obinna", "Obi", 1));
    students.Add(new Student(108, "Emeka", "Michael", 2));

    courses.Add(new Course(1, "Computer Scrience"));
    courses.Add(new Course(2, "Psychology"));
    courses.Add(new Course(3, "Accounting"));
     

}


Initialize();




Console.WriteLine("Query Syntax:");
//Query Syntax
var query = from student in students
            join course in courses
            on student.CourseId equals course.CourseId
            select new {student.StudentId, student.FirstName, course.CourseName };

foreach (var item in query)
{
    Console.WriteLine($"{item.StudentId} - {item.FirstName} - {item.CourseName}");
}


Console.WriteLine("==========================================================================================");

//==========================================================================================


Console.WriteLine("Method Syntax:");
//Method Syntax
var method = students.Join(courses, student => student.CourseId,
    course => course.CourseId,
    (s, c) => new { s.StudentId, s.FirstName, c.CourseName });

foreach (var item in method)
{
    Console.WriteLine($"{item.StudentId} - {item.FirstName} - {item.CourseName}");
}



























