using System;
using NUnit.Framework;

namespace FFLogs.Net.Tests
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
