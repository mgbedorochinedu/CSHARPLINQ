namespace UI.Models;
public class Student
{
    public Student(int studentId, string firstName, string lastName)
    {
        StudentId = studentId;
        FirstName = firstName;
        LastName = lastName;
    }

    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}

public class EngineeringStudent : Student
{
    public EngineeringStudent(int studentId, string firstName, string lastName) 
        : base(studentId, firstName, lastName)
    {
    }
}

public class MedicalStudent : Student
{
    public MedicalStudent(int studentId, string firstName, string lastName) 
        : base(studentId, firstName, lastName)
    {
    }
}
