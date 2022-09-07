using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlib
{
	public delegate void yearsdel(DateTime d);
    public class Employee
    {
		private int _empid;

		public int EmpId
		{
			get { return _empid; }
			set { _empid = value; }
		}

		private string _empname;

		public string EmpName
		{
			get { return _empname; }
			set { _empname = value; }
		}


		private DateTime Joiningdate;

		public DateTime JoiningDate
		{
			get { return Joiningdate; }
			set { Joiningdate = value; }
		}

		public void calyrsofexp(DateTime d)
		{
			int yearsofexp = (DateTime.Now.Year-d.Year);
			Console.WriteLine("The total year of Service is " +yearsofexp);
		}
	}
}
