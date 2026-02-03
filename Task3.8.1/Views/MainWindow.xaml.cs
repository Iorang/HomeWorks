using System.Windows;
using Task3._8._1.ViewModels;

namespace Task3._8._1.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainWindowViewModel mainWindowViewModel)
        {
            this.DataContext = mainWindowViewModel;
            InitializeComponent();
        }
    }
}
