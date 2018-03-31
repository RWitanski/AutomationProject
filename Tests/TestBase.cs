namespace Tests
{
    using TechTalk.SpecFlow;
    using TestFramework;

    public class TestBase
    {
        [BeforeScenario]
        public void Init()
        {
            //var a = Configuration.Instance.ServiceUrl;
        }
    }
}