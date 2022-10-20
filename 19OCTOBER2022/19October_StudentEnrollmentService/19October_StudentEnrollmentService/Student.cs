using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19October_StudentEnrollmentService
{
    public enum CourseName
    {
        AIML,
        DotNet,
        Java,
        Null
    }
    public class Student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public CourseName course { get; set; }

    }
}
