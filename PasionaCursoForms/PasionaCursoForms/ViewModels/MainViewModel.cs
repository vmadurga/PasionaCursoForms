using System.Windows.Input;
using PasionaCursoForms.Pages;
using PasionaCursoForms.ViewModels.Base;
using Xamarin.Forms;

namespace PasionaCursoForms.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly Page _currentPage;
        public MainViewModel(Page mainPage)
        {
            _currentPage = mainPage;
        }

        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        private ICommand _loginCommand;
        public ICommand LoginCommand => _loginCommand ?? (_loginCommand = new Command(LoginCommandExecute));

        private async void LoginCommandExecute()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                await _currentPage.DisplayAlert("Error", "Complete los campos", "Aceptar");
            }
            else
            {
                await _currentPage.Navigation.PushAsync(new SearchPage());
            }
        }
    }
}
