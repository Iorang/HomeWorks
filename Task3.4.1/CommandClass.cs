using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Visual;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._4._1
{
    [Transaction(TransactionMode.Manual)]
    public class CommandClass : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiApp = commandData.Application;
            Application application = uiApp.Application;
            UIDocument uiDoc = uiApp.ActiveUIDocument;
            Document doc = uiDoc.Document;

            FilteredElementCollector filteredElementCollector = new FilteredElementCollector(doc);
            var walls = filteredElementCollector
                .OfClass(typeof(Wall))
                .OfType<Wall>()
                .ToList();

            int numberOfWalls = walls.Count;

            if (numberOfWalls == 0)
            {
                TaskDialog.Show("Ошибка", $"В проекте нет стен");
                return Result.Succeeded;
            }

            using (Transaction t = new Transaction(doc, "Изменены комментарии"))
            {
                double maxLenght = 0;
                Wall maxLenghtWall = null;
                double minLenght = 0;
                Wall minLenghtWall = null;

                t.Start();
                foreach (var wall in walls)
                {
                    Parameter parameter = wall.get_Parameter(BuiltInParameter.CURVE_ELEM_LENGTH);
                    double length = parameter.AsDouble();
                    double lenghtMM = UnitUtils.ConvertFromInternalUnits(length, DisplayUnitType.DUT_MILLIMETERS);

                    if (lenghtMM > maxLenght)
                    {
                        maxLenght = lenghtMM;
                        maxLenghtWall = wall;
                    }

                    if (lenghtMM < minLenght || minLenght == 0)
                    {
                        minLenght = lenghtMM;
                        minLenghtWall = wall;
                    }

                    Parameter parameter1 = wall.LookupParameter("Комментарии");
                    parameter1.Set(string.Empty);
                }

                Parameter parameter2 = maxLenghtWall.LookupParameter("Комментарии");
                parameter2.Set("Самая длинная стена");

                Parameter parameter3 = minLenghtWall.LookupParameter("Комментарии");
                parameter3.Set("Самая короткая стена");

                t.Commit();

                TaskDialog.Show("Готово", $"Количество стен в проекте = {numberOfWalls}");
            }
            return Result.Succeeded;
        }
    }
}
