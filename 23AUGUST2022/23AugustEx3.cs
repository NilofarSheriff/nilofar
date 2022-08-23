using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23August
{
    internal class _23AugustEx3
    {
        static void Main(string[] args)
        {
            Employee _employee1;
           

            Console.WriteLine("Enter the Employee number");
            _employee1.empno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name");
            _employee1.ename = (Console.ReadLine());
            Console.WriteLine("Enter the Employee Salary");
            _employee1.sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Department number");
            _employee1.deptno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*****************************************************");
            Console.WriteLine("The Entered details are");
            Console.WriteLine("Employe name : "+ _employee1.empno);
            Console.WriteLine("Employe number : " + _employee1.ename);
            Console.WriteLine("Employe salary : " + _employee1.sal);
            Console.WriteLine("Employe deptno : " + _employee1.deptno);

            Console.ReadLine();
        }
    }

    struct Employee
    {
        public int empno;
        public string ename;
        public int sal;
        public int deptno;
    }
}
