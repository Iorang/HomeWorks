using System.Collections.ObjectModel;
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

namespace Task2._8_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> Products { get;} = new ObservableCollection<Product>();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Products.Add(new Product()
            {
                Name = "Яблоко",
                Price = 25.99M,
                ImagePath = "",
                Category = ProductCategory.Eat
            });

            Products.Add(new Product()
            {
                Name = "Холодильник",
                Price = 49999.99M,
                ImagePath = "",
                Category = ProductCategory.Appliances
            });
            
            Products.Add(new Product()
            {
                Name = "Банан",
                Price = 42.99M,
                ImagePath = "",
                Category = ProductCategory.Eat
            });
        }
    }
}