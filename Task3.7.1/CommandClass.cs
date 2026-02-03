using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._7._1
{
    [Transaction(TransactionMode.Manual)]
    public class CommandClass : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uiDoc = commandData.Application.ActiveUIDocument;
            Document doc = uiDoc.Document;

            try
            {
                bool elementIsSelected = false;

                while (!elementIsSelected)
                {
                    var element = doc.GetElement(uiDoc.Selection.PickObject(ObjectType.Element));
                    Options options = new Options();

                    var solids = element
                    .get_Geometry(options)
                    .Where(g => g is Solid)
                    .OfType<Solid>()
                    .ToList();

                    if (solids.Count > 0)
                    {
                        int numberOfFaces = 0;
                        int numberOfEdges = 0;
                        double allEdgesLenght = 0;
                        double totalVolume = 0;
                        double totalArea = 0;
                        foreach (var solid in solids)
                        {
                            totalVolume += solid.Volume;
                            totalArea += solid.SurfaceArea;
                            numberOfFaces += solid.Faces.Size;
                            numberOfEdges += solid.Edges.Size;

                            foreach (Edge edge in solid.Edges)
                            {
                                allEdgesLenght += edge.ApproximateLength;
                            }
                        }
                        double allEdgesLenghtMM = UnitUtils.ConvertFromInternalUnits(allEdgesLenght, DisplayUnitType.DUT_METERS);
                        double totalVolumeMM = UnitUtils.ConvertFromInternalUnits(totalVolume, DisplayUnitType.DUT_CUBIC_METERS);
                        double totalAreaMM = UnitUtils.ConvertFromInternalUnits(totalArea, DisplayUnitType.DUT_SQUARE_METERS);

                        TaskDialog.Show("Анализ солидов",
                        $"Суммарный объем всех солидов: {totalVolumeMM} м\u00B3\n" +
                        $"Суммарная площадь поверхности всех солидов: {totalAreaMM} м\u00B2\n" +
                        $"Количество граней: {numberOfFaces}\n" +
                        $"Количество ребер: {numberOfEdges}\n" +
                        $"Суммарная длина ребер: {allEdgesLenghtMM} м");

                        elementIsSelected = true;
                    }
                    else
                    {
                        TaskDialog.Show("Ошибка", " Выберете системное семейство");
                    }
                }
            }
            catch (Exception)
            {

                TaskDialog.Show("Ошибка", "Экземпляр семейства не выбран");
            }

            return Result.Succeeded;
        }
    }
}
