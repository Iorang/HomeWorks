using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using Task3._8._1.Abstractions;
using Task3._8._1.Services;
using Task3._8._1.ViewModels;
using Task3._8._1.Views;

namespace Task3._8._1
{
    [Transaction(TransactionMode.Manual)]
    public class Cmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            ServiceCollection services = new ServiceCollection();

            services.AddSingleton<ExternalCommandData>(commandData);
            services.AddSingleton<ISelectionService, SelectionService>();
            services.AddSingleton<IGeometryService, GeometryService>();
            services.AddSingleton<MainWindowViewModel, MainWindowViewModel>();
            services.AddSingleton<MainWindow, MainWindow>();
            var provider = services.BuildServiceProvider();

            var mainWindow = provider.GetRequiredService<MainWindow>();

            mainWindow.Show();

            return Result.Succeeded;
        }
    }
}
