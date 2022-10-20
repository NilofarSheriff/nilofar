using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }

        public int Age { get; set; }

        public bool IsSeniorCitizen(int Age)
        {
            return Age>=60;
        }
    }
}
