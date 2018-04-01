using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using TechTalk.SpecFlow;
using Tests.Helpers;
using Tests.Model.Entities;

namespace Tests.BDD.Calculator
{
    [Binding]
    public class CalculationsSteps
    {
        private IRestResponse _restResponse;
        private CalculationProperty _property;
        private HttpStatusCode _statusCode;

        [Given(@"I create a new property (.*), (.*), (.*)")]
        public void GivenICreateANewProperty(int principal, int percentageRate, int years)
        {
            var _header = new Dictionary<string, string>();
            _header.Add("ApiKey", "100");

            _property = new CalculationProperty()
            {
                Principal = principal,
                PercentageRate = percentageRate,
                Years = years
            };

            var _request = new HttpRequestWrapper()
                        .AddHeaders(_header)
                        .SetMethod(Method.POST)
                        .SetResourse("/api/calculations/calculateTotalAmount")
                        .AddJsonContent(_property);

            _restResponse = new RestResponse();
            _restResponse = _request.Execute();
            _statusCode = _restResponse.StatusCode;

            ScenarioContext.Current.Add("StatusCode", _statusCode);
            ScenarioContext.Current.Add("Content", _restResponse.Content);
            ScenarioContext.Current.Add("Prop", _property);
        }

        [Then(@"the calculation should return (.*)")]
       public void ThenTheCalculationShouldReturn(string expectedResult)
        {
            var _calcResult = ScenarioContext.Current.Get<string>("Content");

            Assert.AreEqual(_calcResult, expectedResult);
        }


        [Given(@"I create calculation request with unathorized ApiKey")]
        public void GivenICreateCalculationPropertyWithUnathorizedApiKey()
        {
            var _header = new Dictionary<string, string>();
            _header.Add("ApiKey", "99");

            _property = new CalculationProperty()
            {
                Principal = 1000,
                PercentageRate = 2,
                Years = 5
            };

            var _request = new HttpRequestWrapper()
                        .AddHeaders(_header)
                        .SetMethod(Method.POST)
                        .SetResourse("/api/calculations/calculateTotalAmount")
                        .AddJsonContent(_property);

            _restResponse = new RestResponse();
            _restResponse = _request.Execute();
            _statusCode = _restResponse.StatusCode;

            ScenarioContext.Current.Add("StatusCode", _statusCode);
        }


        [Given(@"I create empty property")]
        public void GivenICreateEmptyProperty()
        {
            var _header = new Dictionary<string, string>();
            _header.Add("ApiKey", "100");

            _property = null;

            var _request = new HttpRequestWrapper()
                        .AddHeaders(_header)
                        .SetMethod(Method.POST)
                        .SetResourse("/api/calculations/calculateTotalAmount")
                        .AddJsonContent(_property);

            _restResponse = new RestResponse();
            _restResponse = _request.Execute();
            _statusCode = _restResponse.StatusCode;

            ScenarioContext.Current.Add("StatusCode", _statusCode);
        }
    }
}
