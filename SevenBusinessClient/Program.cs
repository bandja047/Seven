using Microsoft.Extensions.DependencyInjection;

namespace SevenBusinessClient
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var serviceProvider = new ServiceCollection()
                .AddSingleton<HttpClient>(new HttpClient { BaseAddress = new Uri("https://localhost:44332/api/") })
                .AddSingleton<MainForm>()
                .AddTransient<DataArticleView>()
                .BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var form = serviceProvider.GetRequiredService<MainForm>();
            Application.Run(form);
           /* ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());*/
        }
    }
}