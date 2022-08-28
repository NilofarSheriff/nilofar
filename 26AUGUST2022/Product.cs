﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hrlibrary
{
    public class Product
    {
        public string pname;

        public string ProductName
        {
            get { return pname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("ProductName cannot be null");
                }
                else
                {
                    pname = value;
                }

            }
        }

        public int pid;

        public int ProductID
        {
            get { return pid; }
            set
            {
                if (value != 0)
                {
                    pid = value;

                }
                else
                {

                    Console.WriteLine("ProductID cannot be zero or null");
                }
            }
        }

        public int price;

        public int ProductPrice
        {
            get { return price; }
            set
            {
                if (value != 0)
                {
                    price = value;

                }
                else
                {

                    Console.WriteLine("ProductPrice cannot be zero or null");
                }
            }
        }

        public void AcceptProductData(int pid, string pname, int price)
        {
            ProductID = pid;
            ProductName = pname;
            ProductPrice = price;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("ProductID : " + ProductID);
            Console.WriteLine("ProductName : " + ProductName);
            Console.WriteLine("ProductPrice : " + ProductPrice);
            Console.WriteLine("-----------------------------");

        }
    }


}
