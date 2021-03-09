using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FolderFormatter.Domain.Interfaces;
using FolderFormatter.Domain.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace FolderFormatter
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IConfiguration, ConfigurationProvider>();
            ServiceProvider = services.BuildServiceProvider();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new FolderFormatterForm());
        }
    }
}
