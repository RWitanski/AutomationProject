namespace Tests
{
    using TechTalk.SpecFlow;

    public class TestBase
    {
        [BeforeScenario]
        public void Init()
        {
            ScenarioContext.Current.Clear();
        }

        [AfterScenario]
        public void Close()
        {
            ScenarioContext.Current.Clear();
        }
    }
}