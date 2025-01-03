using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        if (!IsProgamRunning()) 
        {
            
        }
    }

    static bool IsProgamRunning()
    {
        return Process.GetProcessesByName("webfishing").Length > 0;
    }
}