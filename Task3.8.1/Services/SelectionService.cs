using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3._8._1.Abstractions;

namespace Task3._8._1.Services
{
    public class SelectionService : ISelectionService
    {
        private readonly ExternalCommandData _commandData;
        public SelectionService(ExternalCommandData commandData)
        {
            _commandData = commandData;
        }

        public ExternalCommandData CommandData { get; }

        public Wall PickOpening()
        {
            try
            {
                Reference reference = _commandData.Application.ActiveUIDocument.Selection.PickObject(Autodesk.Revit.UI.Selection.ObjectType.Element, new OpeningSelectionFilter());
                Wall familyInstance = _commandData.Application.ActiveUIDocument.Document.GetElement(reference) as Wall;
                return familyInstance;
            }
            catch 
            {
                return null;
            }
           
        }

    }
}
