using Lol_AutoRecorder.Providers;
using Lol_AutoRecorder.Wrappers;
using Moq;
using Ninject.Extensions.Logging;
using NUnit.Framework;

namespace LolAutoRecorder.UnitTests
{
    public class PlayerIdProviderTests
    {
        //TODO: write it properly
        [Test]
        public void Test()
        {
            const string leagueOfLegendsPath = "E:/LeagueOfLol/Game";
            var provider = new PlayerIdProvider(new InputOutputWrapper(), Mock.Of<ILogger>());
            provider.Provide(leagueOfLegendsPath, "Leona");
        }
    }
}
