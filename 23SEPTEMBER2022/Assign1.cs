using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using classlib1;

namespace _23September_ADO
{
    internal class Assign1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the product id to search the product");

                BL_Products prod = new BL_Products();
                prod.Prod_id = Convert.ToInt32(Console.ReadLine());
                string connectstring = "Data Source=LAPTOP-KUI0108O;Initial Catalog=Northwind;Integrated Security=True";
                SqlConnection cn = new SqlConnection(connectstring);
                SqlCommand cmd = new SqlCommand("Select * from Products where ProductID = " + prod.Prod_id, cn);
                cn.Open();
                
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("Prod Id : " + dr[0]);
                        Console.WriteLine("Product Name : " + dr[1]);
                        Console.WriteLine("Category Id : " + dr[4]);
                        Console.WriteLine("Price : " + dr[5]);
                    }

                }
                else
                {
                    Console.WriteLine("No Valid Records Found..Check Product Id Again");
                }
                
                
                cn.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
