using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _23August
{
    internal class _23AugustEx5
    {
        static void Main(string[] args)
        {
            Employee[] emp=new Employee[4];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter the Employee number");
                int empno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Employee Name");
               string ename = (Console.ReadLine());
                Console.WriteLine("Enter the Employee Salary");
               int sal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Department number");
                int deptno = Convert.ToInt32(Console.ReadLine());
                emp[i].acceptdata(empno,ename,sal,deptno);
            }

            for (int i = 0; i < 2; i++)
            {
                emp[i].displaydata();
            }
            Console.Read();
            

        }
        struct Employee
        {
            public int empno;
            public string ename;
            public int sal;
            public int deptno;

            public void acceptdata(int Empno, string Empname, int salary, int Deptno)
            {
                this.empno = Empno;
                this.ename = Empname;
                this.sal = salary;
                this.deptno = Deptno;

            }

            public void displaydata()
            {
                Console.WriteLine("***********************************************************");
                Console.WriteLine("The Entered details are");
                Console.WriteLine("Employe number : " + empno);
                Console.WriteLine("Employe name : " + ename);
                Console.WriteLine("Employe salary : " + sal);
                Console.WriteLine("Employe deptno : " + deptno);
            }
        }


    }
}
