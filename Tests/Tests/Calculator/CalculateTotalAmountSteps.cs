using System;
using TechTalk.SpecFlow;

namespace Tests.Tests.Calculator
{
    [Binding]
    public class CalculateTotalAmountSteps : TestBase
    {
        [Given(@"I create a new property \((.*),(.*),(.*),(.*),(.*)\)")]
        public void GivenICreateANewProperty(string p0, string p1, string p2, string p3, string p4)
        {
            ScenarioContext.Current.Pending();
        }

        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
