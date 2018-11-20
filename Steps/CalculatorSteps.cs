using EAWinAppDriverTest.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EAWinAppDriverTest.Steps
{
    [Binding]
    public class CalculatorSteps
    {

        CalcPage calcPage = new CalcPage();

        [Given(@"I open the application")]
        public void GivenIOpenTheApplication()
        {
            //ScenarioContext.Current.Pending();
        }

        [Given(@"I click following numbers")]
        public void GivenIClickFollowingNumbers(Table table)
        {
            calcPage.ClickFollowingNumber(table);
        }

        [Given(@"I perform Addition operation")]
        public void GivenIPerformAdditionOperation()
        {
            calcPage.ClickPlus();
        }

        [Given(@"I click Equals")]
        public void GivenIClickEquals()
        {
            calcPage.ClickEquals();
        }

        [Then(@"I should see the result as (.*)")]
        public void ThenIShouldSeeTheResultAs(int result)
        {
            var actual = calcPage.GetHistory();
            //string formatResult = $"Display is {result}";
            Assert.That(actual, Is.EqualTo(result.ToString()), "Result is not correct");
        }

    }
}
