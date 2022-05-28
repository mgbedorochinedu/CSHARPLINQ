using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPLINQ
{

        public class Student
        {
            public Student(int studentId, string firstName, string lastName, int CourseId)
            {
                this.StudentId = studentId;
                this.FirstName = firstName;
                this.LastName = lastName;
                 this.CourseId = CourseId;
            }

            public int StudentId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int CourseId { get; set; }

        }

    public class EngineeringStudent : Student
    {
        public EngineeringStudent(int studentId, string firstName, string lastName, int CourseId)
            : base(studentId, firstName, lastName, CourseId)
        {
        }
    }

    public class MedicalStudent : Student
    {
        public MedicalStudent(int studentId, string firstName, string lastName, int CourseId)
            : base(studentId, firstName, lastName, CourseId)
        {
        }
    }

}

