using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23August
{
    internal class _23AugustEx4
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.acceptdata(01,"Nilofar",100000000,03);
            emp.displaydata();
            Console.ReadLine();




        }
        struct Employee
        {
            public int empno;
            public string ename;
            public int sal;
            public int deptno;

            public void acceptdata(int Empno, string Empname, int salary, int Deptno)
            {
                empno = Empno;
                ename = Empname;
                sal   = salary;
                deptno = Deptno;

            }

            public void displaydata()
            {
                Console.WriteLine("The Entered details are");
                Console.WriteLine("Employe number : " + empno);
                Console.WriteLine("Employe name : " + ename);
                Console.WriteLine("Employe salary : " + sal);
                Console.WriteLine("Employe deptno : " + deptno);
            }
        }

    }
}
