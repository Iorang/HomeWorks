using Microsoft.Extensions.DependencyInjection;
using RxBim.Di;
using Task3._10._1.Abstractions;
using Task3._10._1.Services;
using Task3._10._1.ViewModels;
using Task3._10._1.Views;

namespace Task3._10._1
{
    public class Config : ICommandConfiguration
    {
        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<IPlacementService, PlacementService>();
            services.AddSingleton<MainWindowViewModel, MainWindowViewModel>();
            services.AddSingleton<MainWindow, MainWindow>();
        }
    }
}
