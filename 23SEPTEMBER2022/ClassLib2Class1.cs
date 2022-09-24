using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using classlib1;


namespace ClassLibrary2
{
    public class DalProducts
    {
        public List<BL_Products> showAllProducts()
        {
            string connectstring = "Data Source=LAPTOP-KUI0108O;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connectstring);
            SqlCommand cmd = new SqlCommand("select* from Products",cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<BL_Products> prodlist = new List<BL_Products>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    BL_Products prod = new BL_Products();
                    prod.Prod_id = Convert.ToInt32(dr[0]);
                    prod.Product_Name = dr[1].ToString();
                    prod.Price = Convert.ToDouble(dr[5]);
                    prodlist.Add(prod);

                }

            }
            else
            {
                Console.WriteLine("No Records Found");
            }
            cn.Close();
            
            return prodlist;


        }
        
            
            
            
            
            
            
    }
}
