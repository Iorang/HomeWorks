using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task2._1_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, RoutedEventArgs e)
        {
            int actualWidth = (int)MainGrid.ActualWidth;
            int actualHeight = (int)MainGrid.ActualHeight;

            int leftMargin = new Random().Next(0, actualWidth - (int)ElusiveButton.ActualWidth);
            int topMargin = new Random().Next(0, actualHeight - (int)ElusiveButton.ActualHeight);


            ElusiveButton.Margin = new Thickness(leftMargin, topMargin, 0, 0);
        }
    }
}