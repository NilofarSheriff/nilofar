using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1sepclasslib
{
	public class Product
	{
		private int _productid;

		public int Productid
		{
			get { return _productid; }
			set { _productid = value; }
		}

		private string _productname;

		public string Productname
		{
			get { return _productname; }
			set { _productname = value; }
		}

		private int _qtysold;

		public int Qtysold
		{
			get { return _qtysold; }
			set { _qtysold = value; }
		}

		private int _unitprice;

		public int Unitprice
		{
			get { return _unitprice; }
			set { _unitprice = value; }
		}

		private string _unitofmeasure;

		public string UnitofMeasure
		{
			get { return _unitofmeasure; }
			set { _unitofmeasure = value; }
		}
		private int _qtyinhand;

		public int Qtyinhand
		{
			get { return _qtyinhand; }
			set { _qtyinhand = value; }
		}

		private int _reorderlevel;

		public int Reorderlevel
		{
			get { return _reorderlevel; }
			set { _reorderlevel = value; }


		}

		public Product()
		{

		}

		public Product(int Pid, string Pname){
			_productid = Pid;
			_productname = Pname;


         }
        

		public void AddProduct(Product pro, Category Cat)
		{

			    Category.count++;
			    Console.WriteLine("Enter the Product Id");
                int id = int.Parse(Console.ReadLine());
				pro.Productid = id;
                Console.WriteLine("Enter the Product Name");
                string name = Console.ReadLine();
				pro.Productname = name;
                Console.WriteLine("Enter the amount of quantity sold");
                int qty = int.Parse(Console.ReadLine());
				pro.Qtysold = qty;
                Console.WriteLine("Enter the amount of Unit price of the quantity");
                int price = int.Parse(Console.ReadLine());
				pro.Unitprice = price;
                Console.WriteLine("Enter the amount Unit of Measure like grams or litre");
                string meas = Console.ReadLine();
				pro.UnitofMeasure = meas;
                Console.WriteLine("Enter the amount of quantity in hand");
                int hand = int.Parse(Console.ReadLine());
				pro.Qtyinhand = hand;
                Console.WriteLine("Enter the Reorder level");
                int lvl = int.Parse(Console.ReadLine());
				pro.Reorderlevel = lvl;
                Console.WriteLine("The Product is added");
			    Console.WriteLine();
                Console.WriteLine();
			











        }





	}
}
