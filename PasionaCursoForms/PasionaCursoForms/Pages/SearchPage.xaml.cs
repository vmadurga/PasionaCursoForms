using PasionaCursoForms.ViewModels;
using Xamarin.Forms;

namespace PasionaCursoForms.Pages
{
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            BindingContext = new SearchViewModel(this);
            InitializeComponent();
        }
    }
}
