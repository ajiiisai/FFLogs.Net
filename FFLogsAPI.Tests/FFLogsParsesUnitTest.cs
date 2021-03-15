using System.Linq;
using System.Threading.Tasks;
using FFLogsAPI.Models.Helpers;
using NUnit.Framework;

namespace FFLogsAPI.Tests
{
    public class FFLogsParsesUnitTest : BaseUnitTest
    {
        [Test]
        public async Task GetCharacterParsesAsync()
        {
            var result = await FFLogsClient.GetCharacterParsesAsync("Ame Aghalair", Server.Europe.Chaos.Ragnarok);
            
            Assert.AreEqual("Ame Aghalair", result.FirstOrDefault()?.CharacterName);
            Assert.AreEqual(420577, result.FirstOrDefault()?.CharacterId);
            Assert.AreEqual("Ragnarok", result.FirstOrDefault()?.Server);
        }
    }
}