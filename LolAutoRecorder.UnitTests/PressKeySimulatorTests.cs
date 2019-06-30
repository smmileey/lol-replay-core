using LolAutoRecorder.CommonLibrary.Enums;
using LolAutoRecorder.CommonLibrary.Mappers;
using LolAutoRecorder.CommonLibrary.Processors;
using Moq;
using Ninject.Extensions.Logging;
using NUnit.Framework;
using System.Threading.Tasks;

namespace LolAutoRecorder.UnitTests
{
    public class PressKeySimulatorTests
    {
        /// <summary>
        /// This is not really a unit-test, rather an automation test. It's just for testing focusing on a player.
        /// </summary>
        /// <returns></returns>
        [Test, Ignore(reason: "debug purposes")]
        public async Task FocusTest()
        {
            var pressKeySimulator = new PressKeySimulator(new InitializerToUShortMapper(), new WindowModeMonitor(new RetryPolicy(Mock.Of<ILogger>())));
            await pressKeySimulator.SendKeystrokeAsync(Initializer.Four);
        }

        /// <summary>
        /// This is not really a unit-test, rather an automation test. It's just for testing focusing on a player.
        /// </summary>
        /// <returns></returns>
        [Test, Ignore(reason: "debug purposes")]
        public async Task WindowModeTest()
        {
            await Task.Delay(5000);
            var pressKeySimulator = new PressKeySimulator(new InitializerToUShortMapper(), new WindowModeMonitor(new RetryPolicy(Mock.Of<ILogger>())));
            await pressKeySimulator.SendWindowModeCommandAsync();
        }

        /// <summary>
        /// This is not really a unit-test, rather an automation test. It's just for testing focusing on a player.
        /// </summary>
        /// <returns></returns>
        [Test, Ignore(reason: "debug purposes")]
        public async Task ForceWindowFocusTest()
        {
            var pressKeySimulator = new PressKeySimulator(new InitializerToUShortMapper(), new WindowModeMonitor(new RetryPolicy(Mock.Of<ILogger>())));
            await Task.Delay(2000);
            await pressKeySimulator.SendKeystrokeAsync(Initializer.Four);
        }
    }
}
