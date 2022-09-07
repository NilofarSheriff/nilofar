using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlib
{
	public delegate void displaydel(Product p);
    public class Product
    {
		private int _productid;

		public int ProductId
		{
			get { return _productid; }
			set { _productid = value; }
		}

		private string _productname;

		public string  ProductName
		{
			get { return _productname; }
			set { _productname = value; }
		}

        public void displaydetails(Product product)
        {
            Console.WriteLine("Product Id: "+product.ProductId);
            Console.WriteLine("Product Name: " + product.ProductName);
        }



    }
}
