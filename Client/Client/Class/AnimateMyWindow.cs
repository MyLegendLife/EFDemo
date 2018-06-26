using System;
using System.Runtime.InteropServices;

namespace LoadManage
{
    public static class AnimateMyWindow
    {
        [DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr whnd, int dwtime, int dwflag);

        public static bool ShowWindowForAnimate(IntPtr handle, int times, int dwflag)
        {
            return AnimateWindow(handle, times, dwflag);
        }

        //==================================================================================

        [StructLayout(LayoutKind.Sequential)]
        struct LASTINPUTINFO
        {
            [MarshalAs(UnmanagedType.U4)]
            public int cbSize;
            [MarshalAs(UnmanagedType.U4)]
            public uint dwTime;
        }

        [DllImport("user32.dll")]
        static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        public static long GetLastInputTime()
        {
            LASTINPUTINFO vLastInputInfo = new LASTINPUTINFO();
            vLastInputInfo.cbSize = Marshal.SizeOf(vLastInputInfo);
            if (!GetLastInputInfo(ref vLastInputInfo)) return 0;
            return Environment.TickCount - (long)vLastInputInfo.dwTime;
        } 
    }
}
