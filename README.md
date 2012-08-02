Show and Hide Taskbar for Windows
=====================

This simple code sample demonstrates the **showing and hiding of the taskbar and start menu** in Windows, using C# (and some nasty Win32 api's). Oh, and it also includes a handy command line utility, if you're just not into code today.

There are several reasons why you could want this. I thought of some:

1. Your app *really* needs to run fullscreen;
2. You want to [goat your collegue's pc](http://www.codinghorror.com/blog/2007/11/dont-forget-to-lock-your-computer.html)

Have fun! Regards,

   Juliën Hanssens @ [hanssens.com](http://hanssens.com)

### Instructions for using the code
Using the `TaskbarManager()` class available in the project, you can easily show/hide the taskbar and startmenu using the following static commands:
* `TaskbarManager.ShowTaskbar();`
* `TaskbarManager.HideTaskbar();`

Easy as cake. 


### Instructions for using the application
Of course, if you're not the smallest bit interested in using the code, you can always simply use the **ShowAndHideTaskbar.exe** application itself. Here's how:

* Running `ShowAndHideTaskbar.exe` from the command line demonstrates the working in a simple command line application
* use `-hide` to hide the taskbar
* use `-show` to show the taskbar
* use `-help` for more information (redirecting to the README file)

