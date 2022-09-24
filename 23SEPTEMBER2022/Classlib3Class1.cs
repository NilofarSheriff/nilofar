using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classlib1;
using ClassLibrary2;

namespace ClassLibrary3
{
    public class Helper_Products
    {
        public List<BL_Products> Getproducts()
        {
            List<BL_Products> Productslist = new List<BL_Products>();
            DalProducts dal = new DalProducts();
            Productslist =  dal.showAllProducts();
            return Productslist;
        }
        
    }
}
