using GitHubUserFetch.Service;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Net.Http.Headers;

namespace GitHubUserFetch
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var host = Host.CreateDefaultBuilder()
                     .ConfigureAppConfiguration((context, builder) =>
                     {

                     })
                     .ConfigureServices((context, services) =>
                     {
                         services.AddTransient<Form, MainForm>();
                         services.AddScoped<IGitHubAPIService, GitHubAPIService>();

                         services.AddHttpClient();

                         services.AddHttpClient("GitHub", httpClient =>
                         {
                             httpClient.BaseAddress = new Uri("https://api.github.com/");

                             // using Microsoft.Net.Http.Headers;
                             // The GitHub API requires two headers.
                             httpClient.DefaultRequestHeaders.Add(
                                 HeaderNames.Accept, "application/vnd.github.v3+json");
                             httpClient.DefaultRequestHeaders.Add(
                                 HeaderNames.UserAgent, "HttpRequestsSample");
                         });
                     })
                     .ConfigureLogging(logging =>
                     {
                            // Add other loggers...
                    })
                     .Build();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = host.Services;
            var mainForm = services.GetRequiredService<Form>();

            Application.Run(mainForm);

            //Application.Run(new MainForm());
        }
    }
}