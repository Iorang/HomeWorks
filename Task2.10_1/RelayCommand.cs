
using System.Windows.Input;

namespace Task2._10_1
{
    public class RelayCommand : ICommand
    {
        private Action<object?> _execute;
        private Func<object?, bool> _canExecute;

        public event EventHandler? CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }
        public RelayCommand(Action<object?> execute, Func<object?, bool> canExecute)
        {
            _canExecute = canExecute;
            _execute = execute;
        }

        public bool CanExecute(object? parameter) => _canExecute(parameter);


        public void Execute(object? parameter) => _execute(parameter);

    }
}
