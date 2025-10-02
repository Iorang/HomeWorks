using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Task2._9._1
{
    class CustomCommands
    {
        public static RoutedCommand ChangeColorCommand { get; set; }

        static CustomCommands()
        {
            InputGestureCollection inputGestureCollection = new InputGestureCollection();
            inputGestureCollection.Add(new KeyGesture(Key.C, ModifierKeys.Control, "Ctrl+C"));
            ChangeColorCommand = new RoutedCommand("ChangeColor", typeof(CustomCommands), inputGestureCollection);
        }

    }
}
