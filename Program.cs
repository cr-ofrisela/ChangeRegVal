
using Microsoft.Win32;

string keyAsDateTime = DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss");
string executableFile = Environment.GetCommandLineArgs()[0];//System.Reflection.Assembly.GetExecutingAssembly().Location;
Console.WriteLine("Setting registry value:\r\nKey=HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run\\" + keyAsDateTime + "\r\nValue=" + executableFile);
RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
key.SetValue(keyAsDateTime, executableFile);
key.Close();

Console.WriteLine("Press any key to exit...");
Console.ReadKey();