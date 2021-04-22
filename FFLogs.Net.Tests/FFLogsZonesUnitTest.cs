using System.Linq;
using System.Threading.Tasks;
using FFLogs.Net.Models.Zones;
using NUnit.Framework;

namespace FFLogs.Net.Tests
{
    public class FFLogsZonesUnitTest : BaseUnitTest
    {
        [Test]
        public async Task GetZonesAsync()
        {
            Zone[] result = await FFLogsClient.GetZonesAsync();
            
            Assert.AreEqual("Eden's Verse", result
                .FirstOrDefault(x=>x.Id == 33)?.Name);
            Assert.AreEqual("Ramuh", result
                .FirstOrDefault(x=>x.Id == 33)?.Encounters
                .FirstOrDefault(x=>x.Id == 69)?.Name);
            Assert.AreEqual("Standard Comps", result
                .FirstOrDefault(x=>x.Id == 33)?.Partitions
                .FirstOrDefault(x=>x.Default == true)?.Name);
        }
    }
}