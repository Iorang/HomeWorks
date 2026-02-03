using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._9._1.Abstractions
{
    public interface ISelectionService
    {
        FamilyInstance PickFamilyInstance();
    }
}
