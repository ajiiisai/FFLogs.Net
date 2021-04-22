using System.Linq;
using System.Threading.Tasks;
using FFLogs.Net.Models.Helpers;
using FFLogs.Net.Models.Parses;
using NUnit.Framework;

namespace FFLogs.Net.Tests
{
    public class FFLogsParsesUnitTest : BaseUnitTest
    {
        [Test]
        public async Task GetCharacterParsesAsync()
        {
            Parses[] result = await FFLogsClient.GetCharacterParsesAsync("Ferro Maljin", NorthAmerica.Primal.Excalibur);
            
            Assert.AreEqual("Ferro Maljin", result.FirstOrDefault()?.CharacterName);
            Assert.AreEqual(11455076, result.FirstOrDefault()?.CharacterId);
            Assert.AreEqual("Excalibur", result.FirstOrDefault()?.Server);
        }
        [Test]
        public async Task GetCharacterParsesAsyncWithOptions()
        {
            Parses[] result = await FFLogsClient.GetCharacterParsesAsync("夜叉散华", China.MaoXiaoPang.ZiShuiZhanQiao, new ParsesOptions { Zone = "37"});

            Assert.AreEqual("夜叉散华", result.FirstOrDefault()?.CharacterName);
            Assert.AreEqual(13630211, result.FirstOrDefault()?.CharacterId);
            Assert.AreEqual("紫水栈桥", result.FirstOrDefault()?.Server);
        }
    }
}