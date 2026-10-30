namespace Lab6;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        
        Application.Run(new MainForm());
    }
}
