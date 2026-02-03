using Autodesk.Revit.Attributes;
using Microsoft.Extensions.DependencyInjection;
using RxBim.Command.Revit;
using RxBim.Shared;
using System;
using Task3._10._1.Views;

namespace Task3._10._1
{
    [Transaction(TransactionMode.Manual)]
    public class Cmd : RxBimCommand
    {
         public PluginResult ExecuteCommand(IServiceProvider provider)
        {
            var mainWindow = provider.GetRequiredService<MainWindow>();
            mainWindow.ShowDialog();
            return PluginResult.Succeeded;
        }
    }
}
