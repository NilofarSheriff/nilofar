using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19October_StudentEnrollmentService
{
    public class EnrollStudent
    {
        public decimal fees(Enrollment E, Student S)
        {
            E.Fees = 0;
            if (S.course == CourseName.Java)
            {
                E.Fees = 4500;
            }
            else if (S.course == CourseName.AIML)
            {
                E.Fees = 4800;
            }
            else if (S.course == CourseName.DotNet)
            {
                E.Fees = 8000;
            }
            return E.Fees;
        }
        public bool Enrollstud(Enrollment E,Student S)
        {
            bool flag = false;
            

            if (E.Fees > 0)
            {
                flag = true;
              
            }
            return flag;
        }
    }
}
