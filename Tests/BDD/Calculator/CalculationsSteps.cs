using RestSharp;
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
        private List<CalculationProperty> _properties;

        [Given(@"I create a new property (.*), (.*), (.*)")]
        public void GivenICreateANewProperty(string p0, string p1, string p2)
        {
            var _request = new HttpRequestWrapper()
                        .SetMethod(Method.POST)
                        .SetResourse("/api/calculations/calculateTotalAmount")
                        .AddJsonContent(_property);

            _restResponse = new RestResponse();
            _restResponse = _request.Execute();
            _statusCode = _restResponse.StatusCode;

        }
    }
}
