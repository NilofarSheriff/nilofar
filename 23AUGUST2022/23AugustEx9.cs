using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23August
{
    internal class _23AugustEx9
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();
            Console.WriteLine("enter Employee number");
            employee.Emp_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Department number");
            employee.Dept_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name");
            employee.Employee_name = Console.ReadLine();

            Console.WriteLine("***************************The details are**********************************");
            Console.WriteLine("employee Name : " + employee.Emp_no);
            Console.WriteLine("employee Dept no :" + employee.Dept_no);
            Console.WriteLine("employee Ename: "+ employee.Employee_name);

            Console.ReadLine();
            
        }

        struct Employee
        {
            int empno;
            public int Emp_no
            {
                set
                {
                    if (value==0)
                    {
                        Console.WriteLine("Employee number cannot be zero");

                        return;

                    }
                    else
                    {
                        empno = value;
                    }
                }
                get
                {

                    return empno;

                }
            }
            
            int deptno;

            public int Dept_no
            {
                set
                {
                    if (value==0)
                    {
                        Console.WriteLine("Department number cannot be zero");
                        return;

                    }
                    else
                    {
                        deptno = value;
                    }
                }
                get
                {

                    return deptno;

                }
            }

            string ename;
           

            public string Employee_name
            {
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("Name cannot be null or empty");
                        return;


                    }
                    else
                    {
                        ename = value;
                    }
                }
                get
                {

                    return ename;

                }


            }

        }

    }

}