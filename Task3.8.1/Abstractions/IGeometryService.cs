using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3._8._1.Models;

namespace Task3._8._1.Abstractions
{
    public interface IGeometryService
    {
        WallInfo GetOpeningInfo(Wall opening, double limit);
    }
}
