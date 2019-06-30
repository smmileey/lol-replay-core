using System;
using static LolAutoRecorder.CommonLibrary.Processors.WindowModeMonitor;

namespace LolAutoRecorder.CommonLibrary.Interfaces
{
    public interface IWindowModeMonitor
    {
        bool IsForegroundFullScreen();

        WINDOWPLACEMENT GetPlacement(IntPtr hwnd);
    }
}