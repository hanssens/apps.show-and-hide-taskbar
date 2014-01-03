using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShowAndHideTaskbar
{
    public abstract class TaskBarManager
    {
        #region -- WIN32 Shizzle

        protected const int CONST_SHOW = 5;
        protected const int CONST_HIDE = 0;

        protected delegate bool EnumThreadProc(IntPtr hwnd, IntPtr lParam);

        [DllImport("user32.dll")]
        protected static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        protected static extern bool EnumThreadWindows(int threadId, EnumThreadProc pfnEnum, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        protected static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        protected static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);

        [DllImport("user32.dll")]
        protected static extern int ShowWindow(IntPtr hwnd, int nCmdShow);

        #endregion

        /// <summary>
        /// Shows the taskbar and startmenu.
        /// </summary>
        public void ShowTaskbar()
        {
            ToggleVisibility(true);
        }

        /// <summary>
        /// Hides the taskbar and startmenu.
        /// </summary>
        public void HideTaskbar()
        {
            ToggleVisibility(false);
        }

        protected abstract void ToggleVisibility(bool visible);
    }

    public class Windows7TaskBarManager : TaskBarManager
    {
        protected override void ToggleVisibility(bool visible)
        {
            // Find the taskbar window
            var taskbar = FindWindow("Shell_TrayWnd", null);

            // Find the startmenu window
            var startmenu = FindWindowEx(taskbar, IntPtr.Zero, "Button", "Start");

            if (startmenu == IntPtr.Zero)
            {
                // ... sometimes, like Windows 7, just finding 'Button' would suffice
                startmenu = FindWindow("Button", null);
            }

            // Show or hide both containers
            ShowWindow(taskbar, visible ? CONST_SHOW : CONST_HIDE);
            ShowWindow(startmenu, visible ? CONST_SHOW : CONST_HIDE);
        }
    }

    public class Windows8TaskBarManager : TaskBarManager
    {
        protected override void ToggleVisibility(bool visible)
        {
            // Find the taskbar window
            var taskbar = FindWindow("Shell_TrayWnd", "");

            // Show or hide the container
            ShowWindow(taskbar, visible ? CONST_SHOW : CONST_HIDE);

            //var offset = new IntPtr(0);
            //var hWnd = new IntPtr(0);
            //while (hWnd == IntPtr.Zero)
            //{
            //    hWnd = FindWindowEx(offset, hWnd, "Shell_TrayWnd", "");
            //    ShowWindow(hWnd, (visible) ? CONST_SHOW : CONST_HIDE);
            //}
        }
    }
}
