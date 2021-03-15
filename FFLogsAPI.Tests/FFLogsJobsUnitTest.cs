using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FFLogsAPI.Tests
{
    public class FFLogsJobsUnitTest : BaseUnitTest
    {
        [Test]
        public async Task GetJobsAsync()
        {
            var result = await FFLogsClient.GetJobsAsync();
            Assert.AreEqual(1, result.FirstOrDefault()?.Id);
            Assert.AreEqual(3, result.FirstOrDefault(x=> x.Name == "Black Mage")?.Id);
            Assert.AreEqual("Astrologian", result.FirstOrDefault()?.Name);
        }
    }
}