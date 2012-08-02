using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShowAndHideTaskbar
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskbarManager.HideTaskbar();

            Console.WriteLine("The taskbar and startmenu should be hidden now. Press any key to restore them.");
            Console.ReadKey();

            TaskbarManager.ShowTaskbar();

            Console.WriteLine("The taskbar and startmenu have been restored! Press any key to quit...");
            Console.ReadKey();
        }
    }
}
