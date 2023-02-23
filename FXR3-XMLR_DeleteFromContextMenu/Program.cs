// See https://aka.ms/new-console-template for more information
using Microsoft.Win32;

Registry.ClassesRoot.DeleteSubKeyTree(@"*\shell\fxr3-xmlr");