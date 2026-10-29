using CinemaApp.Infra;

namespace CinemaApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ConfigureDI.Configure();
            ApplicationConfiguration.Initialize();
            Application.Run(new FormPrincipal());
        }
    }
}