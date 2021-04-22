using System.Linq;
using System.Threading.Tasks;
using FFLogs.Net.Models.Classes;
using NUnit.Framework;

namespace FFLogs.Net.Tests
{
    public class FFLogsJobsUnitTest : BaseUnitTest
    {
        [Test]
        public async Task GetJobsAsync()
        {
            Job[] result = await FFLogsClient.GetJobsAsync();
            Assert.AreEqual(1, result.FirstOrDefault()?.Id);
            Assert.AreEqual(3, result.FirstOrDefault(x=> x.Name == "Black Mage")?.Id);
            Assert.AreEqual("Astrologian", result.FirstOrDefault()?.Name);
        }
    }
}