using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26August
{
    public class _26AugustEx1
    {
        static void Main(string[] args)
        {
            Student[] student1 = new Student[2];
            for(int i = 0; i < student1.Length; i++)
            {
                student1[i] = new Student();
                Console.WriteLine("Enter the rollnumber");
                student1[i].Rollno=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name");
                student1[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Student Marks");
                student1[i].Marks= Convert.ToInt32(Console.ReadLine());
                student1[i].acceptdetails(student1[i].Rollno, student1[i].Name, student1[i].Marks);
                Console.WriteLine("*************************************************");
                student1[i].displaydetails();
                Console.ReadLine();
            }
            

        }

        
    }

    public struct Student
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
            set {
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
