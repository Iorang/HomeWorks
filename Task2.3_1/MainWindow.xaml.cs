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

namespace Task2._3_1
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (PersonalDataCheckBox.IsChecked == false)
            {
                MessageBox.Show("Необходимо согласие на обработку персональных данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var selectedCourses = CoursesListBox.SelectedItems.Cast<ListBoxItem>().Select(item => item.Content.ToString()).ToList();

            string message = 
                $"Форма сохранена!\n\n" + 
                $"Имя студента: {NameTextBox.Text}\n" + 
                $"Выбранные курсы: {string.Join(", ", selectedCourses)}\n" + 
                $"Согласие на обработку персональных данных: {(PersonalDataCheckBox.IsChecked == true ? "Да" : "Нет")}";

            MessageBox.Show(message, "Успешно", MessageBoxButton.OK, MessageBoxImage.Information); 
        }
    }
}