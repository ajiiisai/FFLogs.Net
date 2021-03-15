using System;
using System.Linq;
using NUnit.Framework;

namespace FFLogsAPI.Tests
{
    [TestFixture]
    public class BaseUnitTest
    {
        protected FFLogsClient FFLogsClient { get; set; }

        [SetUp]
        public void Init()
        {
            FFLogsClient = new FFLogsClient(Environment.GetEnvironmentVariable("FFLOGS_API_KEY"));
        }

        [TearDown]
        public void Dispose()
        {
            FFLogsClient.Dispose();
        }
    }
}
