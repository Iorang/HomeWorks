using Autodesk.Revit.DB;
using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using Task3._10._1.Abstractions;
using Task3._10._1.Models;

namespace Task3._10._1.Services
{
    public class PlacementService : IPlacementService
    {
        private readonly Document _document;

        public PlacementService(Document document)
        {
            _document = document;
        }

        public Result Place(TreeType treeType, int count)
        {
            return Validate(count)
                .Bind(() => FindFamily(treeType))
                .Bind(s => PlaceInstances(s, count));
        }

        private Result Validate(int count)
        {
            if (count < 0)
                return Result.Failure("Количество должно быть больше 0");
            return Result.Success();
        }

        private Result<FamilySymbol> FindFamily(TreeType treeType)
        {
            string furnutureName = string.Empty;
            switch (treeType)
            {
                case TreeType.BirchTree:
                    furnutureName = "Береза";
                    break;
                case TreeType.AppleTree:
                    furnutureName = "Дикая яблоня";
                    break;
                case TreeType.HawthornTree:
                    furnutureName = "Боярышник";
                    break;
            }

            FamilySymbol familySymbol = new FilteredElementCollector(_document)
                .OfCategory(BuiltInCategory.OST_Planting)
                .OfClass(typeof(FamilySymbol))
                .OfType<FamilySymbol>()
                .Where(x => x.Name.Contains(furnutureName))
                .FirstOrDefault();

            if (familySymbol == null)
                return Result.Failure<FamilySymbol>("Не найден типоразмер для размещения");

            return familySymbol;
        }

        private Result PlaceInstances(FamilySymbol familySymbol, int count)
        {
            try
            {
                double step = UnitUtils.ConvertToInternalUnits(2, DisplayUnitType.DUT_METERS);
                var points = new List<XYZ>();

                int gridSize = (int)Math.Ceiling(Math.Sqrt(count));

                for (int i = 0; i < gridSize; i++)
                {
                    for (int j = 0; j < gridSize; j++)
                    {
                        int index = i * gridSize + j;

                        if (index < count)
                        {
                            double x = j * step;
                            double y = i * step;
                            points.Add(new XYZ(x, y, 0));
                        }
                    }
                }

                var level = new FilteredElementCollector(_document)
                    .OfClass(typeof(Level))
                    .OfType<Level>()
                    .OrderBy(l => l.Elevation)
                    .FirstOrDefault();

                if (level == null)
                    return Result.Failure("Не удалось определить уровень для размещения");

                using (Transaction transaction = new Transaction(_document, "Размещение деревьев"))
                {
                    transaction.Start();

                    if (!familySymbol.IsActive)
                    {
                        familySymbol.Activate();
                    }

                    foreach (var point in points)
                    {
                        _document.Create.NewFamilyInstance(
                            point,
                            familySymbol,
                            level,
                            Autodesk.Revit.DB.Structure.StructuralType.NonStructural);
                    }
                    transaction.Commit();
                }
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure(ex.Message);
            }
        }
    }
}
