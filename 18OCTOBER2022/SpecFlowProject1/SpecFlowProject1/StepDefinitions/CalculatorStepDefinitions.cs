using FluentAssertions;
using NUnit.Framework;

namespace SpecFlowProject1.StepDefinitions

{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        CalculatorFunctions cal = new CalculatorFunctions();
        private int Res_ult;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            cal.FirstNumber=number;
            
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            cal.SecondNumber=number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Res_ult = cal.Add();
            
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(result, Res_ult);
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            Res_ult = cal.Sub();

        }

        [Then("the output should be (.*)")]
        public void ThenTheOutputShouldBe(int result)
        {
            Assert.AreEqual(result, Res_ult);
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            Res_ult = cal.Multiply();

        }

        [Then("the answer should be (.*)")]
        public void ThenTheAnswerShouldBe(int result)
        {
            Assert.AreEqual(result, Res_ult);
        }

        [When("the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            Res_ult = cal.Divison();

        }

        [Then("the divans should be (.*)")]
        public void ThenTheDivansShouldBe(int result)
        {
            Assert.AreEqual(result, Res_ult);
        }

        [When("the square rooted of the number")]
        public void WhenTheSquareRootedOfTheNumber()
        {
            Res_ult = cal.Sqrt();

        }

        [Then("the ans should be (.*)")]
        public void ThenTheAnsShouldBe(int result)
        {
            Assert.AreEqual(result, Res_ult);
        }

        LoginPage La = new LoginPage();
        private string? ans;

        [Given("the username is (.*)")]
        public void GivenTheUsernameis(string uname)
        {
            La.Username = uname;
            
        }

        [Given("the password is (.*)")]
        public void GivenThePasswordIs(string Pass)
        {
            La.Password = Pass;
            
        }



        [When("they logging in")]
        public void WhenTheyLoggingIn()
        {
            ans = La.Login();

        }

        [Then("the string should be (.*)")]
        public void ThenTheStringShouldBe(string result)
        {
            Assert.AreEqual(result, ans);
        }


    }
}