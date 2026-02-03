using Autodesk.Revit.UI;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using Task3._10._1.Abstractions;
using Task3._10._1.Models;

namespace Task3._10._1.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        private readonly IPlacementService _placementService;
        private TreeType _selectedTreeType;
        private int _count;
        private string _statusMessage;

        public MainWindowViewModel(IPlacementService placementService)
        {
            PlaceCommand = new RelayCommand(PlaceFurniture);

            TreeTypes = new ObservableCollection<TreeType>
            {
                TreeType.BirchTree,
                TreeType.AppleTree,
                TreeType.HawthornTree
            };

            _placementService = placementService;
        }

        public ObservableCollection<TreeType> TreeTypes { get; }

        public TreeType SelectedTreeType
        {
            get => _selectedTreeType;
            set => SetProperty(ref _selectedTreeType, value);
        }

        public int Count
        {
            get => _count;
            set => SetProperty(ref _count, value);
        }

        public string StatusMessage
        {
            get => _statusMessage;
            set => SetProperty(ref _statusMessage, value);
        }

        public RelayCommand PlaceCommand { get; }

        private void PlaceFurniture()
        {
            CSharpFunctionalExtensions.Result result = _placementService.Place(SelectedTreeType, Count);
            if (result.IsSuccess)
            {
                StatusMessage = $"Размещено деревьев: {Count} ";
                TaskDialog.Show("Размещение деревьев", StatusMessage);
            }
            else
            {
                StatusMessage = $"Ошибка {result.Error}";
                TaskDialog.Show("Размещение деревьев", result.Error);
            }
        }
    }
}
