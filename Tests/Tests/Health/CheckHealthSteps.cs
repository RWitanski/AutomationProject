namespace Tests.Tests.Health
{
    using NUnit.Framework;
    using RestSharp;
    using System.Net;
    using TechTalk.SpecFlow;
    using Helpers;

    [Binding]
    public class CheckHealthSteps
    {
        private IRestResponse _restResponse;
       // private Property _property;
        private HttpStatusCode _statusCode;
        //private List<Property> _properties;

        [Given(@"I request to check the application status")]
        public void GivenICreateANewProperty()
        {
            var request = new HttpRequestWrapper()
                .SetMethod(Method.GET)
                .SetResourse("/api/health");

            _restResponse = new RestResponse();
            _restResponse = request.Execute();
            _statusCode = _restResponse.StatusCode;
        }

        [Then(@"the system should return (.*)")]
        public void ThenTheSystemShouldReturn(HttpStatusCode statusCode)
        {
            Assert.AreEqual(_restResponse.StatusCode, statusCode);
        }
    }
}
