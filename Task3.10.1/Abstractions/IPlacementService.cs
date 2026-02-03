using CSharpFunctionalExtensions;
using Task3._10._1.Models;

namespace Task3._10._1.Abstractions
{
    public interface IPlacementService
    {
        Result Place(TreeType selectedFurnitureType, int count);
    }
}
