using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using _19October_StudentEnrollmentService;

namespace StudentEnrollmentService.Tests
{
    [TestFixture]
    public class Test
    {
        [TestCase]
        public void Checking_Fees_Paid()
        {
            EnrollStudent Check = new EnrollStudent();
            Student s = new Student();
            s.Rollno = 2018104001;
            s.Name = "Aarthi";
            s.course = CourseName.DotNet;
            Enrollment e = new Enrollment();
            e.EnrollNo = 1;
            e.Fees = Check.fees(e,s);
            bool ans = Check.Enrollstud(e, s);
            Assert.AreEqual(ans,true);
        }


    }
}
