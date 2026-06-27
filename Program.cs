namespace TrabajoLaboratorio;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        
        bool demoMode = args.Length > 0 && args[0] == "--demo";
        Application.Run(new Form1(demoMode));
    }    
}