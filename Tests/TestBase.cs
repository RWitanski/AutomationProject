using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class TestBase
    {
        private readonly Uri siteUri = new Uri("http://localhost:56326/swagger/ui/index#/");
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
