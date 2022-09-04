using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1sepclasslib;

namespace _2September
{
    internal class _2SeptemberExno1
    {
       static void Main(string[] args)
        {
            #region LOSTCODE
            //Product product = new Product();
            //product.Productid = 1;
            //product.Productname = "Tea";
            //product.Qtysold = 3;
            //product.Unitprice = 10;
            //product.UnitofMeasure = "litre";
            //product.Qtyinhand = 10;
            //product.Reorderlevel = 15;

            //Product product1 = new Product();
            //product1.Productid = 2;
            //product1.Productname = "Coffee";
            //product1.Qtysold = 4;
            //product1.Unitprice = 15;
            //product1.UnitofMeasure = "litre";
            //product1.Qtyinhand = 15;
            //product1.Reorderlevel = 25;

            //Product product2 = new Product();
            //product2.Productid = 3;
            //product2.Productname = "Coke";
            //product2.Qtysold = 15;
            //product2.Unitprice = 20;
            //product2.UnitofMeasure = "litre";
            //product2.Qtyinhand = 50;
            //product2.Reorderlevel = 50;

            //Product product4 = new Product();
            //product4.Productid = 4;
            //product4.Productname = "Samosa";
            //product4.Qtysold = 14;
            //product4.Unitprice = 5;
            //product4.UnitofMeasure = "grams";
            //product4.Qtyinhand = 50;
            //product4.Reorderlevel = 25;

            //Product product5 = new Product();
            //product5.Productid = 5;
            //product5.Productname = "Popcorn";
            //product5.Qtysold = 12;
            //product5.Unitprice = 50;
            //product5.UnitofMeasure = "grams";
            //product5.Qtyinhand = 30;
            //product5.Reorderlevel = 15;

            //Product product6 = new Product();
            //product6.Productid = 6;
            //product6.Productname = "Maaza";
            //product6.Qtysold = 25;
            //product6.Unitprice = 10;
            //product6.UnitofMeasure = "litre";
            //product6.Qtyinhand = 35;
            //product6.Reorderlevel = 55;

            //Category Cat = new Category();
            //Cat.Catid = 1;
            //Cat.Catname = "Beverages";
            //Cat.Catdesc = "The quantity which can be measured in litres will come under Beverages";
            //Cat.Productslist = new List<Product>();
            //Cat.Productslist.Add(product);
            //Cat.Productslist.Add(product1);
            //Cat.Productslist.Add(product2);
            //Cat.Productslist.Add(product4);

            //Category Cat2 = new Category();
            //Cat2.Catid = 2;
            //Cat2.Catname = "Snacks";
            //Cat2.Catdesc = "The quantity which can be measured in grams will come under Snacks";
            //Cat2.Productslist = new List<Product>();
            //Cat2.Productslist.Add(product5);
            //Cat2.Productslist.Add(product6);

            //Cat.AddCategory(Cat);


            //Console.WriteLine("Category ID : " + Cat.Catid);
            //Console.WriteLine("Category Name : " + Cat.Catname);
            //Console.WriteLine("Category Description : " + Cat.Catdesc);
            //Console.WriteLine("==============================================================================");


            //foreach (var item in Cat.Productslist)
            //{

            //    Console.WriteLine("Product Id :" + item.Productid);
            //    Console.WriteLine("Product Name :" + item.Productname);
            //    Console.WriteLine("Product QtySold :" + item.Qtysold);
            //    Console.WriteLine("Product Unitprice :" + item.Unitprice);
            //    Console.WriteLine("Product Unitof Measure :" + item.UnitofMeasure);
            //    Console.WriteLine("Product Quantity in Hand :" + item.Qtyinhand);
            //    Console.WriteLine("Product Reorder Level :" + item.Reorderlevel);
            //    Console.WriteLine();
            //    Console.WriteLine();

            //}

            //Console.WriteLine("**********************************************************************************************");
            //Console.WriteLine();

            //Console.WriteLine("Category ID : " + Cat2.Catid);
            //Console.WriteLine("Category Name : " + Cat2.Catname);
            //Console.WriteLine("Category Description : " + Cat2.Catdesc);
            //Console.WriteLine("==============================================================================");
            //foreach (var item in Cat2.Productslist)
            //{

            //    Console.WriteLine("Product Id :" + item.Productid);
            //    Console.WriteLine("Product Name :" + item.Productname);
            //    Console.WriteLine("Product QtySold :" + item.Qtysold);
            //    Console.WriteLine("Product Unitprice :" + item.Unitprice);
            //    Console.WriteLine("Product Unitof Measure :" + item.UnitofMeasure);
            //    Console.WriteLine("Product Quantity in Hand :" + item.Qtyinhand);
            //    Console.WriteLine("Product Reorder Level :" + item.Reorderlevel);
            //    Console.WriteLine();
            //    Console.WriteLine();

            #endregion

           

           
            Console.WriteLine("Enter the option");
            Console.WriteLine("1.Add Beverages \n 2.Add Snacks \n ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    {
                        Category cat1 = new Category();
                        cat1.AddCategory(cat1);

                        break;
                    }
                case 2:
                    {
                        Category cat2 = new Category();
                        cat2.AddCategory(cat2);
                        break;
                    }
            }

            Product product1 = new Product(1, "coffee");
            Category.count++;
            Console.WriteLine("Product ID :" + product1.Productid);
            Console.WriteLine("Product Name :" + product1.Productname);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("The total products added are " + Category.count);

           
            
            
            Console.ReadLine();



        }

        






    }
    
}
