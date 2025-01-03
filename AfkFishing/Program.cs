using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;

class Program
{
    [DllImport("user32.dll")]

    public static extern int GetAsyncKeyState(Int32 i);

    private int KEY1 = 46;
    private int KEY2 = 44;
    static void Main(string[] args)
    {
        string command = $@"/C E:\Steam\steam.exe -applaunch 3146520";


        if (!IsProgamRunning())
        {
            MessageBox.Show(
                "Webfishing is not running! The program will launch the game for you now. Restart this program once webfishing starts!",
                String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            StartGame(command);
        }

        while (IsProgamRunning())
        {
            Console.WriteLine("yeah");
        }
    }

    static bool IsProgamRunning()
    {
        return Process.GetProcessesByName("webfishing").Length > 0;
    }

    static Process StartGame(string command)
    {
        return Process.Start("CMD.exe", command);
    }

    static void Keybind()
    {
        while (true)
        {
            // Thread.Sleep(5);
            // int keyState1 = GetAsyncKeyState(KEY1);
        }
    }
    

}