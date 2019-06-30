using LolAutoRecorder.CommonLibrary.Exceptions;
using LolAutoRecorder.CommonLibrary.Interfaces;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;

namespace LolAutoRecorder.CommonLibrary.Processors
{
    public class WindowModeMonitor : IWindowModeMonitor
    {
        private const string LeagueClientProcessName = "League of Legends";
        private const int MONITOR_DEFAULTTOPRIMARY = 1;
        private readonly IRetryPolicy _retryPolicy;

        protected delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        public WindowModeMonitor(IRetryPolicy retryPolicy)
        {
            _retryPolicy = retryPolicy ?? throw new ArgumentNullException(nameof(retryPolicy));
        }

        public enum ShowWindowCommands : int
        {
            Hide = 0,
            Normal = 1,
            Minimized = 2,
            Maximized = 3,
        }

        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        public struct WINDOWPLACEMENT
        {
            public int length;
            public int flags;
            public ShowWindowCommands showCmd;
            public Point ptMinPosition;
            public Point ptMaxPosition;
            public Rectangle rcNormalPosition;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal struct MonitorInfoEx
        {
            public int cbSize;
            public Rect rcMonitor;
            public Rect rcWork;
            public uint dwFlags;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] public string szDeviceName;
        }

        public bool IsForegroundFullScreen()
        {
            return EnumWindows(EnumTheWindows, IntPtr.Zero);
        }

        public WINDOWPLACEMENT GetPlacement(IntPtr hwnd)
        {
            WINDOWPLACEMENT placement = new WINDOWPLACEMENT();
            placement.length = Marshal.SizeOf(placement);
            GetWindowPlacement(hwnd, ref placement);
            return placement;
        }

        private bool EnumTheWindows(IntPtr hWnd, IntPtr lParam)
        {
            var mi = new MonitorInfoEx();
            mi.cbSize = Marshal.SizeOf(mi);

            GetMonitorInfoEx(MonitorFromWindow(hWnd, MONITOR_DEFAULTTOPRIMARY), ref mi);

            Process process =_retryPolicy.Execute(() =>
            {
                return Process.GetProcessesByName(LeagueClientProcessName)?.FirstOrDefault();
            }, proc => proc != null && proc.MainWindowHandle != IntPtr.Zero, maxRetries: 10, delayBetweenRequest: 1000);

            if (process == null || process.MainWindowHandle == IntPtr.Zero) throw new LeagueOfLegendsProcessException($"No League clien process found");
            WINDOWPLACEMENT placement = GetPlacement(process.MainWindowHandle);

            int monitorHeight = mi.rcMonitor.Right - mi.rcMonitor.Left;
            int monitorWidth = mi.rcMonitor.Bottom - mi.rcMonitor.Top;
            int windowHeight = placement.rcNormalPosition.Right - placement.rcNormalPosition.Left;
            int windowWidth = placement.rcNormalPosition.Bottom - placement.rcNormalPosition.Top;

            return windowHeight == monitorHeight && windowWidth == monitorWidth;
        }

        [DllImport("user32.dll")]
        protected static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

        [DllImport("User32")]
        public static extern IntPtr MonitorFromWindow(IntPtr hWnd, int dwFlags);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

        [DllImport("user32", EntryPoint = "GetMonitorInfo", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool GetMonitorInfoEx(IntPtr hMonitor, ref MonitorInfoEx lpmi);
    }
}
