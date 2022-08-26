using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hrlibrary;

namespace _26August
{
    public class _26AugustEx2
    {
        static void Main(string[] args)
        {
            Student[] student1 = new Student[2];
            for(int i = 0; i < student1.Length; i++)
            {
                student1[i] = new Student();
                Console.WriteLine("Enter the rollnumber");
                student1[i].Rollno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name");
                student1[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Student Marks");
                student1[i].Marks = Convert.ToInt32(Console.ReadLine());
                student1[i].acceptdetails(student1[i].Rollno, student1[i].Name, student1[i].Marks);
                Console.WriteLine("*************************************************");
                student1[i].displaydetails();
                Console.ReadLine();
            }
        }
    }
}
