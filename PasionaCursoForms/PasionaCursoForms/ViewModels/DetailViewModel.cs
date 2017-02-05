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
    }
}
