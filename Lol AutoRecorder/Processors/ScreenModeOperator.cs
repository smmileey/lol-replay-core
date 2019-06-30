using Lol_AutoRecorder.Enums;
using Lol_AutoRecorder.Interfaces;
using LolAutoRecorder.CommonLibrary.Interfaces;
using Ninject.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Lol_AutoRecorder.Processors
{
    public class ScreenModeOperator : IScreenModeOperator
    {
        private readonly IWindowModeMonitor _windowModeMonitor;
        private readonly IPressKeySimulator _pressKeySimulator;
        private readonly ILogger _logger;

        public ScreenModeOperator(IWindowModeMonitor windowModeMonitor, IPressKeySimulator pressKeySimulator, ILogger logger)
        {
            _windowModeMonitor = windowModeMonitor ?? throw new ArgumentNullException(nameof(windowModeMonitor));
            _pressKeySimulator = pressKeySimulator ?? throw new ArgumentNullException(nameof(pressKeySimulator));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task UpdateScreenMode(ScreenMode screenMode)
        {
            if (ShouldUpdateScreenMode(screenMode))
            {
                _logger.Debug($"Screen mode change to: {screenMode.ToString()}");
                await _pressKeySimulator.SendWindowModeCommandAsync();
                await Task.Delay(2000);
            }
        }

        private bool ShouldUpdateScreenMode(ScreenMode screenMode)
        {
            bool isFullScreen = _windowModeMonitor.IsForegroundFullScreen();
            return screenMode == ScreenMode.FullScreen && !isFullScreen || screenMode == ScreenMode.WindowMode && isFullScreen;
        }
    }
}
