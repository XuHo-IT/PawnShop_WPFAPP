using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using System.Configuration;
using System.Data;
using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;

        protected override void OnStartup(StartupEventArgs e)
        {
            // Set up configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Set up dependency injection
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection, configuration);
            serviceProvider = serviceCollection.BuildServiceProvider();

            base.OnStartup(e);

            // Resolve and show LoginWindow
            //var liquidate = serviceProvider.GetService<Liquidate>();
            //if (liquidate != null)
            //{
            //    liquidate.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Failed to load Liquidate Window.");
            //}
        }

        private void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(configuration); // Register IConfiguration
            services.AddSingleton<IPawnContractRepository, PawnContractRepository>();
            services.AddTransient<Liquidate>(); // Register LoginWindow for DI
            
        }
    }
}
