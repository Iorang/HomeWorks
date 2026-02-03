using Autodesk.Revit.DB;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Task3._8._1.Abstractions;
using Task3._8._1.Models;
using Task3._8._1.Services;

namespace Task3._8._1.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly ISelectionService _selectionService;

        private readonly IGeometryService _geometryService;

        public MainWindowViewModel(ISelectionService selectionService, IGeometryService geometryService)
        {
            CalcOpening = new RelayCommand(OnCalcOpeningExecute);
            _selectionService = selectionService;
            _geometryService = geometryService;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region Свойства
       
        private WallInfo _wallinfo;
        public WallInfo WallInfo
        {
            get => _wallinfo;
            set
            {
                _wallinfo = value;
                OnPropertyChanged();
            }
        }

        private double _limit = 1;
        public double Limit
        {
            get => _limit;
            set
            {
                _limit = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Команды и методы для команд
        public ICommand CalcOpening { get; }

        private void OnCalcOpeningExecute(object parameter)
        {
            Wall wall = _selectionService.PickOpening();
            if (wall == null)
                return;

            WallInfo = _geometryService.GetOpeningInfo(wall, Limit);

        }
        #endregion
         
    }
}
