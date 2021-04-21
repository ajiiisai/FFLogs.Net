using System.Linq;
using System.Threading.Tasks;
using FFLogs.Net.Models.Helpers;
using NUnit.Framework;

namespace FFLogs.Net.Tests
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
        [Test]
        public async Task GetCharacterParsesAsyncWithOptions()
        {
            var result = await FFLogsClient.GetCharacterParsesAsync("夜叉散华", China.MaoXiaoPang.ZiShuiZhanQiao,new Models.Parses.ParsesOptions {  Zone = "37"});

            Assert.AreEqual("夜叉散华", result.FirstOrDefault()?.CharacterName);
            Assert.AreEqual(13630211, result.FirstOrDefault()?.CharacterId);
            Assert.AreEqual("紫水栈桥", result.FirstOrDefault()?.Server);
        }
    }
}