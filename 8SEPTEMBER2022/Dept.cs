using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public delegate void EmployeeOperations(List<Employee> emplist);
	
    public class Dept
    {
        
        private int _deptno;

		public int DeptNo
		{
			get { return _deptno; }
			set { _deptno = value; }
		}

		private string _deptname;

		public string DeptName
		{
			get { return _deptname; }
			set { _deptname = value; }
		}

		private string _location;

		public string Location
		{
			get { return _location; }
			set { _location = value; }
		}

		private List<Employee> _emplist;

		public List<Employee> EmpList
		{
			get { return _emplist; }
			set {
				if (_emplist.Capacity < 10)
				{
                    _emplist = value;
                }
				else
				{
					Console.WriteLine("The list is Full");
				}
				
			}

			
		}

        public void displaydetails(List<Employee> emplist)
        {
			
            foreach(var item in emplist)
			{
				if (string.IsNullOrEmpty(item.Manager))
				{
					Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This Employee don't have a Reporting Manager");
					Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Employee ID : " + item.EmpId);
                    Console.WriteLine("Employee Name : " + item.EmpName);
                    Console.WriteLine("Employee Dept No : " + item.DeptNo);
                    Console.WriteLine("Employee Salary : " + item.Salary);
                    Console.WriteLine("Employee Reporting Manager : " + item.Manager);
                    Console.WriteLine("********************************************");

                }
				else
				{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This Employee has a Reporting Manager");
					Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Employee ID : " + item.EmpId);
                    Console.WriteLine("Employee Name : " + item.EmpName);
                    Console.WriteLine("Employee Dept No : " + item.DeptNo);
                    Console.WriteLine("Employee Salary : " + item.Salary);
                    Console.WriteLine("Employee Reporting Manager : " + item.Manager);
                    Console.WriteLine("********************************************");
                }
                
            }

        }

		










    }
}
