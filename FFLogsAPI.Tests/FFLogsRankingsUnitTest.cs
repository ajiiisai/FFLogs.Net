using System.Linq;
using System.Threading.Tasks;
using FFLogsAPI.Models.Helpers;
using NUnit.Framework;

namespace FFLogsAPI.Tests
{
    public class FFLogsRankingsUnitTest : BaseUnitTest
    {
        [Test]
        public async Task GetEncounterRankingsAsync()
        {
            var result = await FFLogsClient.GetEncounterRankingsAsync(69);
            
            Assert.AreEqual(5.2, result.Rankings.FirstOrDefault()?.Patch);
        }
        
        [Test]
        public async Task GetCharacterRankingsAsync()
        {
            var result = await FFLogsClient.GetCharacterRankingsAsync("Ame Aghalair", Server.Europe.Chaos.Ragnarok);
            
            Assert.AreEqual("Ame Aghalair", result.FirstOrDefault()?.CharacterName);
            Assert.AreEqual(420577, result.FirstOrDefault()?.CharacterId);
            Assert.AreEqual("Ragnarok", result.FirstOrDefault()?.Server);
        }
    }
}