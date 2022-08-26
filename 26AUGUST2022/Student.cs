using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrlibrary
{
    public class Student
    {
        public int _Rollno;


        public int Rollno
        {
            get { return _Rollno; }
            set
            {
                try
                {
                    if (value != 0)
                    {
                        _Rollno = value;
                    }
                    else
                    {
                        throw new ArgumentNullException();

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
        }
        public int _Marks;
        public int Marks { get; set; }



        public string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                try
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        _Name = value;
                    }
                    else
                    {
                        throw new ArgumentNullException();

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }


        public void acceptdetails(int roll, string sname, int Marks)
        {
            this.Rollno = roll;
            this.Name = sname;
            this.Marks = Marks;

        }

        public void displaydetails()
        {
            Console.WriteLine(Rollno);
            Console.WriteLine(Name);
            Console.WriteLine(Marks);
        }


    }
}
