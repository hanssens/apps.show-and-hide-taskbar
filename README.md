# Show and Hide Taskbar for Windows
by [@jhanssens](https://twitter.com/jhanssens)

## In A Nutshell

### Introduction

This simple code sample demonstrates the **showing and hiding of the taskbar and start menu** in Windows, using C# (and some nasty Win32 api's). Oh, and it also includes a handy command line utility, if you're just not into code today.

There are several reasons why you could want this. I thought of some:

1. Your app *really* needs to run fullscreen;
2. You want to [goat your collegue's pc](http://www.codinghorror.com/blog/2007/11/dont-forget-to-lock-your-computer.html)

### Getting Started (

### Instructions - using it in your code
Using the **TaskbarManager()** class available in the project, you can easily show/hide the taskbar and startmenu using the following static commands:

* `TaskbarManager.ShowTaskbar();`
* `TaskbarManager.HideTaskbar();`

Easy as cake. 

### Instructions - using the command line app

Of course, if you're not the smallest bit interested in using the code, you can always simply use the **ShowAndHideTaskbar.exe** application itself. Here's how:

* Running `ShowAndHideTaskbar.exe` from the command line demonstrates the working in a simple command line application
* use `-hide` to hide the taskbar
* use `-show` to show the taskbar
* use `-help` for more information (redirecting to the README file)

## Revisions

**3 Jan, 2014**

* Updated to work on Windows 8/8.1
* Fix for [issue #1](https://github.com/hanssens/show-and-hide-taskbar/issues/1)

** 2 Aug, 2012**

* Initial publication

