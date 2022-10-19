using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1
{
    public class Product
    {
        public int ProductId { get; set; }
        public int Qty { get; set; }

        public int addtocart(Product P)
        {
            List<Product> prodlist = new List<Product>();
             
            if (P.ProductId!=0 && P.Qty > 0)
            {
                prodlist.Add(P);
            }
            return prodlist.Count;

        }
        
    }
}
