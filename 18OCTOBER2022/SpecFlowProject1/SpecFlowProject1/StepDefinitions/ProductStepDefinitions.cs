using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    
    [Binding]
    public class ProductStepDefinitions
    {
        Product p = new Product();
        private int pl;
        

        

        

       

        [Given(@"the Product Id as (.*)")]
        public void GivenTheProductIdAs(int p0)
        {
            p.ProductId = p0;
        }

        [Given(@"the qty (.*)")]
        public void GivenTheQty(int p0)
        {
            p.Qty = p0;
        }

        [When(@"they added to list")]
        public void WhenTheyAddedToList()
        {
            pl = p.addtocart(p);
        }

        [Then(@"Product list should be added (.*)")]
        public void ThenProductListShouldBeAdded(int p0)
        {
            Assert.AreEqual(pl, p0);
        }

    }
}
