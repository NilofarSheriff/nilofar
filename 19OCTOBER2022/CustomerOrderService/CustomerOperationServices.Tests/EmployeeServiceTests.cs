using CustomerOrderService;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOperationServices.Tests
{
    [TestFixture]
    public class EmployeeServiceTests
    {
        [TestCase(16,ExpectedResult =false)]
        [TestCase(65, ExpectedResult = true)]
        [TestCase(36, ExpectedResult = false)]
        [TestCase(87, ExpectedResult = true)]

        public bool GetAge(int age)
        {
            Employee emp = new Employee();
            emp.EmployeeID = 1;
            emp.FirstName = "Nilofar";
            emp.Age = age;
           bool ans =  emp.IsSeniorCitizen(emp.Age);
            return ans;

        }
       
        
    }
}
