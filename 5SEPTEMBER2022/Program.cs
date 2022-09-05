using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;

namespace _5September
{
    internal class Program
    {
        static public int cartcount;

        
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Carts :");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of books to add in one Cart");
            int n = int.Parse(Console.ReadLine());
            Book[] book = new Book[n];
            List<Cart> carts = new List<Cart>();
            
            for (int i = 0; i < s; i++)
            {
                Cart cart = new Cart();
                cartcount++;
                Console.WriteLine("Enter the customer ID");
                cart.CustomerId = int.Parse(Console.ReadLine());
                cart.AddToCart(cart.CustomerId, book);
                carts.Add(cart);
                
            }
            
            foreach (Cart cart in carts)
            {

                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine("The customer ID is : " +cart.CustomerId );
                cart.DisplayDetails(cart, book);
                carts cartsnew = new carts();
                cartsnew.Deletecart(cart);


            }

            Console.BackgroundColor=ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;


            Console.WriteLine("The number of carts added is {0} and total number of books added are {1}",cartcount ,Cart.count);


            
            Console.ReadLine();

        }

        
    }
}
