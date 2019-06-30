using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading.Tasks;
using LolAutoRecorder.CommonLibrary.Mappers;
using LolAutoRecorder.CommonLibrary.Interfaces;
using LolAutoRecorder.CommonLibrary.Enums;
using LolAutoRecorder.CommonLibrary.Exceptions;
using LolAutoRecorder.CommonLibrary.Wrappers;

namespace LolAutoRecorder.CommonLibrary.Processors
{
    public class PressKeySimulator : IPressKeySimulator
    {
        const string LeagueClientProcess = "League of Legends";
        private const int VM_RESTORE = 9;
        private readonly IInitializerToUShortMapper _initializerToUShortMapper;
        private readonly IWindowModeMonitor _windowModeMonitor;

        public PressKeySimulator(IInitializerToUShortMapper initializerToUShortMapper, IWindowModeMonitor windowModeMonitor)
        {
            _initializerToUShortMapper = initializerToUShortMapper ?? throw new ArgumentNullException(nameof(initializerToUShortMapper));
            _windowModeMonitor = windowModeMonitor ?? throw new ArgumentNullException(nameof(windowModeMonitor));
        }

        public async Task SendKeystrokeAsync(Initializer initialzer)
        {
            var directInputKeyScan = _initializerToUShortMapper.Map(initialzer);
            Process leagueOfLegendsProcess = Process.GetProcessesByName(LeagueClientProcess).First();
            var recordingProcessHandle = Process.GetCurrentProcess().MainWindowHandle;

            IntPtr foregroundWindow = IntPtr.Zero;
            do
            {
                await Task.Run(async () =>
                {
                    for (int i = 1; i < 10; i++)
                    {
                        WindowModeMonitor.WINDOWPLACEMENT processWindowState = _windowModeMonitor.GetPlacement(leagueOfLegendsProcess.MainWindowHandle);
                        if (processWindowState.showCmd == WindowModeMonitor.ShowWindowCommands.Minimized)
                        {
                            if (!leagueOfLegendsProcess.Responding) throw new LeagueOfLegendsProcessException($"League Client is not responding. ");
                            ShowWindow(leagueOfLegendsProcess.MainWindowHandle, VM_RESTORE);
                            await Task.Delay(5000);
                        }
                        else SetForegroundWindow(leagueOfLegendsProcess.MainWindowHandle);

                        //simulate double-keypress
                        SendInputWrapper.SendKey(directInputKeyScan, press: true);
                        await Task.Delay(10);
                        SendInputWrapper.SendKey(directInputKeyScan, press: false);
                        await Task.Delay(10);
                        SendInputWrapper.SendKey(directInputKeyScan, press: true);
                        await Task.Delay(10);
                        SendInputWrapper.SendKey(directInputKeyScan, press: false);
                        await Task.Delay(10);

                        foregroundWindow = GetForegroundWindow();
                    }
                });
            } while (foregroundWindow != leagueOfLegendsProcess.MainWindowHandle);
        }

        public async Task SendWindowModeCommandAsync()
        {
            bool isFullScreen = _windowModeMonitor.IsForegroundFullScreen();
            Process leagueOfLegendsProcess = Process.GetProcessesByName(LeagueClientProcess).First();

            bool isCurrentFullScreen = isFullScreen;
            do
            {
                await Task.Run(async () =>
                {
                    SetForegroundWindow(leagueOfLegendsProcess.MainWindowHandle);
                    if (isCurrentFullScreen) await Task.Delay(5000);

                    //simulate double-keypress
                    SendInputWrapper.SendKey(_initializerToUShortMapper.Map(Initializer.Alt), press: true);
                    await Task.Delay(10);
                    SendInputWrapper.SendKey(_initializerToUShortMapper.Map(Initializer.Enter), press: true);
                    await Task.Delay(10);
                    SendInputWrapper.SendKey(_initializerToUShortMapper.Map(Initializer.Enter), press: false);
                    await Task.Delay(10); ;
                    SendInputWrapper.SendKey(_initializerToUShortMapper.Map(Initializer.Alt), press: false);
                    await Task.Delay(3000);

                    isCurrentFullScreen = _windowModeMonitor.IsForegroundFullScreen();
                });
            } while (isCurrentFullScreen == isFullScreen);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
    }
}
