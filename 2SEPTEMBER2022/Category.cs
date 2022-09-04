using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1sepclasslib
{
    public class Category
    {
        private int _catid;

        public int Catid
        {
            get { return _catid; }
            set { _catid = value; }
        }

        private string _Catname;

        public string Catname
        {
            get { return _Catname; }
            set { _Catname = value; }
        }

        private string _catdesc;

        public string Catdesc
        {
            get { return _catdesc; }
            set { _catdesc = value; }
        }

        private List<Product> _productslist;

        public List<Product> Productslist
        {
            get { return _productslist; }
            set { _productslist = value; }
        }
        public static int count;
        public void AddCategory(Category Cat)
        {
            

            Console.WriteLine("Enter the category id");
            int a = int.Parse(Console.ReadLine());
            Cat.Catid = a;
            Console.WriteLine("Enter the Category Name");
            string cname = Console.ReadLine();
            Cat.Catname = cname;
            Console.WriteLine("Enter the Category Description");
            string cdes = Console.ReadLine();
            Cat.Catdesc = cdes;
            Console.WriteLine("The Category is added");
            Console.WriteLine("************************************************");
            if (Cat.Catname == "Beverages")
            {
                Console.WriteLine("Write the number of products to assign inside the category Beverages");
                int n = int.Parse(Console.ReadLine());
                Product[] product = new Product[n];
                Cat.Productslist = new List<Product>();
                for (int i = 0; i < n; i++)
                {
                    product[i] = new Product();
                    product[i].AddProduct(product[i], Cat);
                    Cat.Productslist.Add(product[i]);

                }
                DisplayDetails(Cat);





            }
            else if (Cat.Catname == "Snacks")
            {
                Console.WriteLine("Write the number of products to assign inside the category Snacks");
                int n = int.Parse(Console.ReadLine());
                Product[] product = new Product[n];
                Cat.Productslist = new List<Product>();
                for (int i = 0; i < n; i++)
                {
                    product[i] = new Product();
                    product[i].AddProduct(product[i], Cat);
                    Cat.Productslist.Add(product[i]);

                }
                DisplayDetails(Cat);






            }
        }
        void DisplayDetails(Category cat)
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine();

            Console.WriteLine("Category ID : " + cat.Catid);
            Console.WriteLine("Category Name : " + cat.Catname);
            Console.WriteLine("Category Description : " + cat.Catdesc);
            Console.WriteLine("==============================================================================");
            foreach (var item in cat.Productslist)
            {

                Console.WriteLine("Product Id :" + item.Productid);
                Console.WriteLine("Product Name :" + item.Productname);
                Console.WriteLine("Product QtySold :" + item.Qtysold);
                Console.WriteLine("Product Unitprice :" + item.Unitprice);
                Console.WriteLine("Product Unitof Measure :" + item.UnitofMeasure);
                Console.WriteLine("Product Quantity in Hand :" + item.Qtyinhand);
                Console.WriteLine("Product Reorder Level :" + item.Reorderlevel);
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }


        

 
}

	

