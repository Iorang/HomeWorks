using Autodesk.Revit.DB;
using System;
using System.Windows.Media.Animation;
using Task3._8._1.Abstractions;
using Task3._8._1.Models;

namespace Task3._8._1.Services
{
    public class GeometryService : IGeometryService
    {

        public WallInfo GetOpeningInfo(Wall wall, double limit)
        {
            double wallHeight = GetWallHeight(wall);
            double wallWidth = UnitUtils.ConvertFromInternalUnits(wall.Width, DisplayUnitType.DUT_METERS);
            double wallThikness = GetWallThikness(wall);
            double wallArea = GetWallArea(wall);
            double wallVolume = GetWallVolume(wallArea, wallThikness);


            return new WallInfo()
            {
                Name = wall.WallType.FamilyName,
                Type = wall.WallType.Name,
                Lenght = wallWidth,
                Height = wallHeight,
                Thikness = wallThikness,
                Area = wallArea,
                Volume = wallVolume,
                IsCorrect = wallHeight < limit
            };
        }

        private double GetWallHeight(Wall opening)
        {
            double maxZ = GetMaxZ(opening);
            double minZ = GetMinZ(opening);

            return UnitUtils.ConvertFromInternalUnits(maxZ - minZ, DisplayUnitType.DUT_METERS);
        }

        private double GetMaxZ(Element element)
        {
            var box = element.get_BoundingBox(null);
            return box.Max.Z;
        }
        private double GetMinZ(Element element)
        {
            var box = element.get_BoundingBox(null);
            return box.Min.Z;
        }

        private double GetWallThikness(Wall wall)
        {
            Parameter lengthParam = wall.get_Parameter(BuiltInParameter.CURVE_ELEM_LENGTH);
            double wallLength = lengthParam.AsDouble();

            return UnitUtils.ConvertFromInternalUnits(wallLength, DisplayUnitType.DUT_METERS);
        }

        private double GetWallArea(Wall wall)
        {
            Parameter lengthParam = wall.get_Parameter(BuiltInParameter.HOST_AREA_COMPUTED);
            double wallLength = lengthParam.AsDouble();

            return UnitUtils.ConvertFromInternalUnits(wallLength, DisplayUnitType.DUT_SQUARE_METERS);
        }
        private double GetWallVolume(double wallArea, double wallThikness)
        {
            double wallVolume = wallArea * wallThikness;
            return wallVolume;
        }
    }
}
