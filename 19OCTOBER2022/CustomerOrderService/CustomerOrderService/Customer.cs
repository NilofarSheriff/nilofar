using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService
{
    public enum CustomerType
    {
        Basic,
        Premium,
        Gold
    }
    public class Customer
    {
        
            public string CustomerId { get; set; }
            public string CustomerName { get; set; }
            public CustomerType CustomerType { get; set; }

             public List<Customer> CustList { get; set; }

    }
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public decimal Amount { get; set; }
    }
}
