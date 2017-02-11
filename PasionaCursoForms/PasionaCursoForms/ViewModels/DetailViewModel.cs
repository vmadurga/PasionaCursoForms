using System.Windows.Input;
using PasionaCursoForms.DependencyService;
using PasionaCursoForms.Models;
using PasionaCursoForms.Pages;
using PasionaCursoForms.ViewModels.Base;
using Xamarin.Forms;

namespace PasionaCursoForms.ViewModels
{
    public class DetailViewModel : BaseViewModel
    {
        private readonly Page _currentPage;
        public DetailViewModel(DetailPage detailPage, Result selectedModel)
        {
            _currentPage = detailPage;
            DetailModel = selectedModel;
        }

        private Result _detailModel;
        public Result DetailModel
        {
            get { return _detailModel; }
            set
            {
                _detailModel = value;
                OnPropertyChanged();
            }
        }

        private ICommand _sendEmailCommand;
        public ICommand SendEmailCommand => _sendEmailCommand ?? (_sendEmailCommand = new Command(SendEmailCommandExecute));

        private void SendEmailCommandExecute()
        {
            Xamarin.Forms.DependencyService.Get<IEmailService>().SendEmail("hola@hola");
        }
    }
}
