using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Task2._4_1
{
    internal class CustomButton : Button
    {
        public static readonly DependencyProperty IsToggledProperty =
            DependencyProperty.Register("IsToggled", typeof(bool), typeof(CustomButton), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.None, OnClickColorChanged));

        public bool IsToggled
        {
            get => (bool)GetValue(IsToggledProperty);
            set => SetValue(IsToggledProperty, value);
        }

        private static void OnClickColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var button = (CustomButton)d;
            bool newValue = (bool)e.NewValue;

            if (newValue == true)
            {
                button.Content = "ON";
                button.Background = Brushes.Green;
            }
            else
            {
                button.Content = "OFF";
                button.Background = Brushes.Red;
            }
        }

        public CustomButton()
        {
            Content = "Кликни меня";

            Click += (sender, e) =>
            {
                IsToggled = IsToggled == true ? false : true;   
            };
        }
    }
}