using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3._9._1.Abstractions;

namespace Task3._9._1.Services
{
    public class SectionService : ISectionService
    {
        private readonly ExternalCommandData _commandData;


        public SectionService(
            ExternalCommandData commandData)
        {
            _commandData = commandData;
        }

        public bool CreateSection(
            FamilyInstance instance,
            double widthOffsetMm,
            double depthOffsetMm,
            double heightOffsetMm,
            string sectionName)
        {
            var doc = _commandData.Application.ActiveUIDocument.Document;

            var bbox = instance.get_BoundingBox(null);

            if (bbox == null)
            {
                return false;
            }

            var center = (bbox.Min + bbox.Max) / 2;
            var size = bbox.Max - bbox.Min;

            Transform transform = Transform.CreateTranslation(XYZ.Zero);
            transform.Origin = center;

            var widthOffset = UnitUtils.ConvertToInternalUnits(widthOffsetMm, DisplayUnitType.DUT_MILLIMETERS);
            var depthOffset = UnitUtils.ConvertToInternalUnits(depthOffsetMm, DisplayUnitType.DUT_MILLIMETERS);
            var heightOffset = UnitUtils.ConvertToInternalUnits(heightOffsetMm, DisplayUnitType.DUT_MILLIMETERS);

            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    transform.BasisX = (XYZ.BasisZ.CrossProduct(XYZ.BasisY)).Normalize();
                    transform.BasisY = XYZ.BasisZ;
                    transform.BasisZ = XYZ.BasisY;
                }
                else if (i == 1)
                {
                    transform.BasisX = (XYZ.BasisY.CrossProduct(XYZ.BasisZ)).Normalize();
                    transform.BasisY = XYZ.BasisZ;
                    transform.BasisZ = -XYZ.BasisY;
                    
                }
                else if (i == 2)
                {
                    transform.BasisX = (XYZ.BasisZ.CrossProduct(XYZ.BasisX)).Normalize();
                    transform.BasisY = XYZ.BasisZ;
                    transform.BasisZ = XYZ.BasisX;
                }
                else
                {
                    transform.BasisX = (XYZ.BasisX.CrossProduct(XYZ.BasisZ)).Normalize();
                    transform.BasisY = XYZ.BasisZ;
                    transform.BasisZ = -XYZ.BasisX; 
                }

                var sectionBox = new BoundingBoxXYZ();

                if (i == 0 || i == 1)
                {
                    sectionBox.Transform = transform;
                    sectionBox.Min = new XYZ(-size.X / 2 - widthOffset, -size.Z / 2 - depthOffset, -size.Y / 2 - heightOffset);
                    sectionBox.Max = new XYZ(size.X / 2 + widthOffset, size.Z / 2 + depthOffset, size.Y / 2 + heightOffset);
                }
                else
                {
                    sectionBox.Transform = transform;
                    sectionBox.Min = new XYZ(-size.Y / 2 - widthOffset, -size.Z / 2 - depthOffset, -size.X / 2 - heightOffset);
                    sectionBox.Max = new XYZ(size.Y / 2 + widthOffset, size.Z / 2 + depthOffset, size.X / 2 + heightOffset);
                }
                

                var viewType = new FilteredElementCollector(doc)
                    .OfClass(typeof(ViewFamilyType))
                    .OfType<ViewFamilyType>()
                    .FirstOrDefault(x => x.ViewFamily == ViewFamily.Section);

                if (viewType == null)
                {
                    return false;
                }

                try
                {
                    using (var transaction = new Transaction(doc, "VisualizeTransform"))
                    {
                        transaction.Start();
                        var viewSection = ViewSection.CreateSection(doc, viewType.Id, sectionBox);
                        viewSection.Name = sectionName + $"{i+1}";

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
                return true;
            
        }
       
    }
}
