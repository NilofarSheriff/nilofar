using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CustomerOrderService
{
    public class CustomerOrder
    {
        public void ApplyDiscount(Customer customer, Order order)
        {
            if (customer.CustomerType == CustomerType.Premium)
            {
                order.Amount = order.Amount - ((order.Amount * 10) / 100);
            }
            else if (customer.CustomerType == CustomerType.Gold)
            {
                order.Amount = order.Amount - ((order.Amount * 20) / 100);
            }
        }

        public void GetCustomersList(Customer c1)
        {
            string ConnectionString = @"Data Source=LAPTOP-KUI0108O;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection con  = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("select* from Customers ", con);
            con.Open();
            List<Customer> clist = new List<Customer>();
            
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                  
                    Customer customer = new Customer();
                    customer.CustomerId = dr[1].ToString();
                    customer.CustomerName = dr[2].ToString();
                    clist.Add(customer);
    

                }
                c1.CustList = clist;

            }
            con.Close();
            con.Dispose();
            
        }
    }
}
