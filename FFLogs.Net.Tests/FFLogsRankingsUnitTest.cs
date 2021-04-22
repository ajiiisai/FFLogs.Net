using System.Linq;
using System.Threading.Tasks;
using FFLogs.Net.Models.Helpers;
using FFLogs.Net.Models.Rankings;
using NUnit.Framework;

namespace FFLogs.Net.Tests
{
    public class FFLogsRankingsUnitTest : BaseUnitTest
    {
        [Test]
        public async Task GetEncounterRankingsAsync()
        {
            EncounterRankings result = await FFLogsClient.GetEncounterRankingsAsync(69);
            
            Assert.AreEqual(5.2, result.Rankings.FirstOrDefault()?.Patch);
        }
        
        [Test]
        public async Task GetCharacterRankingsAsync()
        {
            CharacterRankings[] result = await FFLogsClient.GetCharacterRankingsAsync("Ferro Maljin", NorthAmerica.Primal.Excalibur);
            
            Assert.AreEqual("Ferro Maljin", result.FirstOrDefault()?.CharacterName);
            Assert.AreEqual(11455076, result.FirstOrDefault()?.CharacterId);
            Assert.AreEqual("Excalibur", result.FirstOrDefault()?.Server);
        }
    }
}