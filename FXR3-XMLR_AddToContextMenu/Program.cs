// See https://aka.ms/new-console-template for more information

using Microsoft.Win32;

//get own path
string Path = AppDomain.CurrentDomain.BaseDirectory;
Path = '"' + Path + "FXR3-XMLR.exe" + '"';
Path = Path + " " + '"' + "%1" + '"';

//add registry keys
Registry.SetValue("HKEY_CLASSES_ROOT\\*\\shell\\fxr3-xmlr", "", "FXR3");
Registry.SetValue("HKEY_CLASSES_ROOT\\*\\shell\\fxr3-xmlr\\command", "", Path);