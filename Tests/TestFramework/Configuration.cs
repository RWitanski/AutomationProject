using NUnit.Framework;
using System;

namespace TestFramework
{
    public class Configuration
    {
        private static Configuration _instance;

        public Uri ServiceUrl { get; private set; }

        private Configuration()
        {
            ServiceUrl = new Uri(TestContext.Parameters["ServiceUrl"]);
        }

        public static Configuration Instance => _instance ?? (_instance = new Configuration());
    }
}
