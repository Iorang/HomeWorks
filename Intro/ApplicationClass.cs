using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Intro
{
    
    [Transaction(TransactionMode.Manual)]
    public class ApplicationClass : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            application.CreateRibbonTab("ПИК-Привет");
            var panel = application.CreateRibbonPanel("ПИК-Привет","Общее");
            var button = new PushButtonData(
                "Hello",
                "Привет",
                "C:\\Users\\StoneWindow\\AppData\\Roaming\\Autodesk\\Revit\\Addins\\2019\\LevelsProperty\\LevelsProperty.dll",
                "Revit.SDK.Samples.LevelsProperty.CS.Command"
                );

            BitmapImage bitmapImage = new BitmapImage(new Uri("C:\\Users\\StoneWindow\\AppData\\Roaming\\Autodesk\\Revit\\Addins\\2019\\Test\\Images\\Apple.png", UriKind.Absolute));

            button.LargeImage =bitmapImage;

            panel.AddItem(button);

            return Result.Succeeded;
        }
    }
}
