using _19October_StudentEnrollmentService;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollmentService.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestMethod1()
        {
            //Act  
            StubExtensionManager stub = new StubExtensionManager();
            FileChecker checker = new FileChecker(stub);

            //Action  
            bool IsTrueFile = checker.CheckFile("myFile.whatever");

            //Assert  
            Assert.AreEqual(true, IsTrueFile);
        }
    }
}
