using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._5._1
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
            
            try
            {
                IList<Reference> refs = uiDoc.Selection.PickObjects(ObjectType.Element, new Filter(), "Выберете элемент");
                List<FamilyInstance> selectedElements = new List<FamilyInstance>();

                foreach (var r in refs)
                {
                    Element element = doc.GetElement(r);
                    selectedElements.Add((FamilyInstance)element);
                }

                Dictionary<string, int> categoryDictionary = new Dictionary<string, int>();

                int numbersOfElements = selectedElements.Count;

                foreach (Element element in selectedElements)
                {
                    Category category = element.Category;
                    if (category != null)
                    {
                        string categoryName = category.Name;

                        if (categoryDictionary.ContainsKey(categoryName))
                        {
                            categoryDictionary[categoryName]++;
                        }
                        else
                        {
                            categoryDictionary[categoryName] = 1;
                        }
                    }
                }

                string statisticsMessage = $"Общее количество элементов: {numbersOfElements}\n";

                foreach (var category in categoryDictionary)
                {
                    statisticsMessage += $"{category.Key}: {category.Value}\n";
                }


                TaskDialog.Show("Итог", $"{statisticsMessage}");
            }
            catch
            {
                TaskDialog.Show("Итог", $"Элементы не выбраны");
            }
            return Result.Succeeded;
        }
    }
}
