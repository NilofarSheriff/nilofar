using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CustomerOrderService;

namespace CustomerOperationServices.Tests
{
    
    [TestFixture(CustomerType.Premium,100)]
    [TestFixture(CustomerType.Basic)]
    public class CustomerOrdersTests
    {
        CustomerType ctype;

        Order O = new Order();

        public CustomerOrdersTests(CustomerType ctype,int amt):this (ctype)
        {
            O.Amount = amt;

        }
    
        public CustomerOrdersTests(CustomerType ctype)
        {
            this.ctype = ctype;
        }
        [TestCase]
        public void TestMethod()
        {
            Assert.IsTrue((ctype == CustomerType.Premium) &&
                (O.Amount>0));
        }

        [TestCase]
        public void TestMethod1()
        {
            Assert.IsTrue(ctype == CustomerType.Basic);
        }
        [TestCase]
        
        public void When_Premium_10percent()
        {
            Customer C = new Customer();

            C.CustomerId ="ABc";
            C.CustomerName = "Nilofar";
            C.CustomerType = CustomerType.Premium;

            Order O = new Order();
            O.OrderId = 1;
            O.ProductId = 23;
            O.ProductQuantity = 30;
            O.Amount = 3000;

            CustomerOrder C1 = new CustomerOrder();
            C1.ApplyDiscount(C,O);
            Assert.AreEqual(O.Amount,2700);
        }

        [TestCase]

        public void When_Gold_20percent()
        {
            Customer C = new Customer();

            C.CustomerId = "xyz";
            C.CustomerName = "Zamruth";
            C.CustomerType = CustomerType.Gold;

            Order O = new Order();
            O.OrderId = 2;
            O.ProductId = 50;
            O.ProductQuantity = 100;
            O.Amount = 5000;

            CustomerOrder C1 = new CustomerOrder();
            C1.ApplyDiscount(C, O);
            Assert.AreEqual(O.Amount, 4000);
        }
        [TestCase]
        public void FetchList()
        {
            Customer C1 = new Customer();
            CustomerOrder C = new CustomerOrder();
            C.GetCustomersList(C1);
            List<Customer> cli = new List<Customer>();
            cli.Add(new Customer
            {
                CustomerId = "abc",
                CustomerName = "nILOFAR"
            });
            cli.Add(new Customer
            {
                CustomerId = "Ac",
                CustomerName = "ZebRa"
            });

            Assert.AreEqual(cli, C1.CustList);
        }

    }
}
