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
        private HttpStatusCode _statusCode;

        [Given(@"I request to check the application status")]
        public void GivenICreateANewProperty()
        {
            var request = new HttpRequestWrapper()
                .SetMethod(Method.GET)
                .SetResourse("/api/health");

            _restResponse = new RestResponse();
            _restResponse = request.Execute();
            _statusCode = _restResponse.StatusCode;

            ScenarioContext.Current.Add("StatusCode", _statusCode);
        }

        [Then(@"the system should return (.*)")]
        public void ThenTheSystemShouldReturn(HttpStatusCode statusCode)
        {
            _statusCode = ScenarioContext.Current.Get<HttpStatusCode>("StatusCode");

            Assert.AreEqual(_statusCode, statusCode);
        }
    }
}
