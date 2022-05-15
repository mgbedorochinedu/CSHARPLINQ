// See https://aka.ms/new-console-template for more information
using UI.Models;




//LINQ filtering Operator - Where
static void LinqWhere()
{
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


    //Initializing the fucntion
    Initialize();

    Console.WriteLine("Printing Query Syntax:");
    //Query Syntax
    IEnumerable<Student> query = from student in students
                                 where student.LastName.Equals("Smith")
                                 select student;

    foreach (Student item in query)
    {
        Console.WriteLine($"{item.FirstName} {item.LastName}");
    }

    Console.WriteLine("Printing Method Syntax:");
    //Method Syntax
    IEnumerable<Student> methodQuery = students.Where(x => x.LastName.Equals("Michael"));

    foreach (Student item in methodQuery)
    {
        Console.WriteLine($"{item.FirstName} {item.LastName}");
    }

}




//LINQ filtering Operator - OfType

List<Student> students = new List<Student>();

void Initialize()
{
    students.Add(new EngineeringStudent(101, "James", "Smith"));
    students.Add(new EngineeringStudent(102, "Robert", "Michael"));
    students.Add(new EngineeringStudent(103, "Maria", "Johnson"));
    students.Add(new EngineeringStudent(104, "David", "Smith"));
    students.Add(new MedicalStudent(105, "Emma", "Dalot"));
    students.Add(new MedicalStudent(106, "Chika", "Smith"));
    students.Add(new MedicalStudent(107, "Obinna", "Obi"));
    students.Add(new MedicalStudent(108, "Emeka", "Michael"));
}

Initialize();

IEnumerable<EngineeringStudent> engStudents = students.OfType<EngineeringStudent>();

foreach (EngineeringStudent item in engStudents)
{
    Console.WriteLine($"{item.FirstName} {item.LastName}");
}

//...........................................................................................................



















