namespace Tests.Tests.Calculator
{
    using RestSharp;
    using System.Collections.Generic;
    using System.Net;
    using TechTalk.SpecFlow;
    using Model.Entities;
    using global::Tests.Helpers;

    [Binding]
    public class CalculateTotalAmountSteps : TestBase
    {
        private IRestResponse _restResponse;        
        private HttpStatusCode _statusCode;
        private CalculationProperty _property;
        private List<CalculationProperty> _properties;


        [Given(@"I create a new property \((.*),(.*),(.*)\)")]
        public void GivenICreateANewProperty(int principal, int percentageRate, int years)
        {
            _property = new CalculationProperty()
            {
                Principal = principal,
                PercentageRate = percentageRate,
                Years = years
            };

            var request = new HttpRequestWrapper()
                            .SetMethod(Method.POST)
                            .SetResourse("/api/calculations/calculateTotalAmount")
                            .AddJsonContent(_property);

            _restResponse = new RestResponse();
            _restResponse = request.Execute();
            _statusCode = _restResponse.StatusCode;

            ScenarioContext.Current.Add("Pro", _property);
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
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
