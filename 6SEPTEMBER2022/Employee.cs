using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Employee : person
    {
        public override void Work()
        {
            Console.WriteLine("This person is a employee");
        }
    }

    public class Manager : person
    {
        public override void Work()
        {
            Console.WriteLine("This person is a Manager");
        }
    }

    public class Clerk: person
    {
        public override void Work()
        {
            Console.WriteLine("This person is a Clerk");
        }
    }


}
