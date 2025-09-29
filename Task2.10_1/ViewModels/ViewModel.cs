using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Task2._10_1.Models;

namespace Task2._10_1.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string _username;

        private const string _isSuccessMessage = "Успешный вход! Добро пожаловать!";
        private const string _notSuccessMessage = "Введите учетные данные!";

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyCnanged();
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyCnanged();
            }
        }

        private string _statusMessage = _notSuccessMessage;
        public string StatusMessage
        {
            get => _statusMessage;
            set
            {
                _statusMessage = value;
                OnPropertyCnanged();
            }
        }

        private bool _isSuccess = false;
        public bool IsSuccess
        {
            get => _isSuccess;
            set
            {
                _isSuccess = value;
                OnPropertyCnanged();
            }
        }
        public ICommand LoginCommand { get; }

        public ViewModel()
        {
            LoginCommand = new RelayCommand(OnLoginCommandExecute, CanLoginCommandExecute);
        }


        private bool CanLoginCommandExecute(object? parameter) => !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);

        private void OnLoginCommandExecute(object? parameter)
        {
            if (AuthModel.Authenticate(Username, Password))
            {
                StatusMessage = _isSuccessMessage;
                IsSuccess = true;
            }
            else
            {
                StatusMessage = _notSuccessMessage;
                IsSuccess = false;
            }
        }
        private void OnPropertyCnanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
