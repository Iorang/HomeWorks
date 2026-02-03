using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Plumbing;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Application = Autodesk.Revit.ApplicationServices.Application;

namespace Task3._6._1
{

    [Transaction(TransactionMode.Manual)]
    public class CommandClass : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uiDoc = commandData.Application.ActiveUIDocument;
            Document doc = uiDoc.Document;
            var selectedIds = uiDoc.Selection.GetElementIds();
            if (selectedIds.Count != 2)
            {
                TaskDialog.Show("Ошибка", "Выберите 2 параллельные стены");
                return Result.Failed;
            }
            Wall wall1 = uiDoc.Document.GetElement(selectedIds.First()) as Wall;
            Wall wall2 = uiDoc.Document.GetElement(selectedIds.Last()) as Wall;
            if (wall1 == null || wall2 == null)
            {
                TaskDialog.Show("Ошибка", "Выберите именно стены");
                return Result.Failed;
            }
            XYZ direction1 = GetWallDirection(wall1);
            XYZ direction2 = GetWallDirection(wall2);
            double dotProduct = direction1.DotProduct(direction2);
            double tolerance = 0.001;

            if (Math.Abs(Math.Abs(dotProduct) - 1) < tolerance)
            {

                XYZ firstWallMiddlePoint = GetWallMiddlePoint(wall1);
                XYZ secondWallMiddlePoint = GetWallMiddlePoint(wall2);

                XYZ vectorBetweenTheCenters = (secondWallMiddlePoint - firstWallMiddlePoint);
                XYZ normalVector = wall1.Orientation.Normalize();

                double distance = Math.Abs(vectorBetweenTheCenters.DotProduct(normalVector));
                double distanceMM = UnitUtils.ConvertFromInternalUnits(distance, DisplayUnitType.DUT_MILLIMETERS);

                TaskDialog.Show("Результат", $"Расстояние между стенами: {distanceMM}мм");
            }
            else
            {
                TaskDialog.Show("Результат", "стены не ПАРАЛЛЕЛЬНЫ");
            }

            return Result.Succeeded;
        }
        private XYZ GetWallDirection(Element wall)
        {
            LocationCurve location = wall.Location as LocationCurve;
            if (location == null) return null;
            Curve curve = location.Curve;
            XYZ start = curve.GetEndPoint(0);
            XYZ end = curve.GetEndPoint(1);
            return (end - start).Normalize();
        }
        private XYZ GetWallMiddlePoint(Element wall)
        {
            LocationCurve location = wall.Location as LocationCurve;
            if (location == null) return null;
            Curve curve = location.Curve;
            XYZ start = curve.GetEndPoint(0);
            XYZ end = curve.GetEndPoint(1);
            XYZ middle = (start + end) / 2;
            return middle;
        }

    }

}
