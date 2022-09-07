using Classlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _7September
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region ex1and2
            //Ex1 firstex = new Ex1();
            //Console.WriteLine("Enter the string to find the length");
            //string str = Console.ReadLine();
            //findlength find = new findlength(firstex.lengthstring);
            //find(str);
            //find = new findlength(firstex.Greetuser);
            //find(str);
            //Console.ReadLine(); 
            #endregion

            #region Ex3
            //Ex3 ex3 = new Ex3();
            //Console.WriteLine("Enter A value to perform arithmetic operations");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter B value to perform arithmetic operations");
            //int b = int.Parse(Console.ReadLine());
            //arithmeticdel[] del = new arithmeticdel[3] { ex3.add, ex3.Sub, ex3.Mul };
            //arithmeticdel del1 = (arithmeticdel)MulticastDelegate.Combine(del);
            //del1(a, b);

            //Console.ReadLine(); 
            #endregion

            #region Ex4
            //Product product = new Product();
            //product.ProductId = 101;
            //product.ProductName = "Laptop";
            //displaydel del = new displaydel(product.displaydetails);
            //del(product);
            //Console.ReadLine(); 
            #endregion

            #region Ex5
            //Employee employee = new Employee();
            //employee.EmpId = 2522916;
            //employee.EmpName = "Nilofar Mohamed Khalaq Sheriff";
            //employee.JoiningDate = new DateTime(2012, 06, 24);
            //yearsdel del = new yearsdel(employee.calyrsofexp);
            //del(employee.JoiningDate);
            //Console.ReadLine();
            #endregion

            #region Ex6
            //Ex6 ex = new Ex6();
            //Console.WriteLine("Enter first string");
            //string a = Console.ReadLine();
            //Console.WriteLine("Enter Second string");
            //string b = Console.ReadLine();
            //concatdel del = new concatdel(ex.concattwostr);
            //del(a, b);
            //Console.ReadLine(); 
            #endregion

            #region Ex7
            Ex7 ex7 = new Ex7();
            Console.WriteLine("Write a string to convert first letter to upper case");
            string a = Console.ReadLine();
            strfirst del = new strfirst(ex7.strcap);
            del(a);
            Console.ReadLine(); 
            #endregion




        }
    }
}
