using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPLINQ.Model
{
    public class Course
    {
        public Course(int courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }

    }
}
