using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using classlib1;
using ClassLibrary3;

namespace _23September_ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Helper_Products prod = new Helper_Products();
                List<BL_Products> prodlist = new List<BL_Products>();
                prodlist = prod.Getproducts();
                foreach(var product in prodlist)
                {
                    Console.Write(product.Prod_id+" ");
                    Console.Write(product.Product_Name+" ");
                    Console.Write(product.Price);
                    Console.WriteLine();
                    Console.WriteLine();
                   
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            Console.ReadLine();
        }
    }
}
