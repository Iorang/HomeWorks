using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;

namespace Task3._9._1.Services
{
    public class FamilyInstanceSelectionFilter : ISelectionFilter
    {
        public bool AllowElement(Element elem)
        {
            if (!(elem is FamilyInstance fi))
                return false;
            return true;
        }

        public bool AllowReference(Reference reference, XYZ position) => false;
    }
}
