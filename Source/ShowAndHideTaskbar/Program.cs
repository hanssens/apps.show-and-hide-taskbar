using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;

namespace ShowAndHideTaskbar
{
    class Program
    {
        static void Main(string[] arguments)
        {
            TaskBarManager manager = null;

            // cast the arguments to lowercase
            var args = arguments.Select(a => a.ToLower());

            // determine the specific implementation, based on the windows type
            /*
            if (args.Contains("-win8"))
                manager = new Windows8TaskBarManager();
            else
                manager = new Windows7TaskBarManager();
             * **************************************************************************************************************************************************************************
            */
            manager = new Windows8TaskBarManager();


            if (args.Contains("-hide")) {
                manager.HideTaskbar();
                return;
            }

            if (args.Contains("-show")) {
                manager.ShowTaskbar();
                return;
            }

            if (args.Contains("-help")) {
                System.Diagnostics.Process.Start(@"https://github.com/Hanssens/Show-and-Hide-Taskbar/");
                return;
            }

            /*
             * No arguments provided. Run the simple demo
             */

            Console.WriteLine("Running Show-And-Hide-Taskbar");
            Console.WriteLine("use -help for more information\r\nuse -hide to hide the taskbar\r\nuse -show to show the taskbar again\r\n\r\n");

            manager.HideTaskbar();

            Console.WriteLine("The taskbar and startmenu should be hidden now. Press any key to restore them.");
            Console.ReadKey();

            manager.ShowTaskbar();

            Console.WriteLine("The taskbar and startmenu have been restored! Press any key to quit...");
            Console.ReadKey();
        }

        static void RunDefault()
        {

        }
    }
}
