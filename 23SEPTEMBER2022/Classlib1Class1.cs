using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlib1
{
    public class BL_Products

    {
		//public int Prod_id { get; set; }
		private int _prodid;

		public int Prod_id
		{
			get { return _prodid; }
			set
			{

				if (value!= 0)
				{
					_prodid = value;
				}
				else
				{
					throw new Exception("Product id is not valid");

				}
			}

		}


		private string _productname;

		public string Product_Name
		{
			get { return _productname; }
			set
			{
				if ((value.Length > 40) || string.IsNullOrEmpty(value))
				{
					throw new Exception("Not valid Product..Please check");
				}
				else
				{
					_productname = value;
				}
			}
		}


		public double Price { get; set; }


	}
}
