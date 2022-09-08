using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
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

        private int _deptno;

        public int DeptNo
        {
            get { return _deptno; }
            set { _deptno = value; }
        }

        private int _salary;

		public int Salary
		{
			get { return _salary; }
			set { _salary = value; }
		}

		private string _manager;

		public string Manager
		{
			get { return _manager; }
			set { _manager = value; }
		}



	}
}
