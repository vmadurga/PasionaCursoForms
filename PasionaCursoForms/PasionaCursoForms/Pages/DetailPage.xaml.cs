using PasionaCursoForms.Models;
using PasionaCursoForms.ViewModels;
using Xamarin.Forms;

namespace PasionaCursoForms.Pages
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Result selectedModel)
        {
            BindingContext = new DetailViewModel(this, selectedModel);
            InitializeComponent();
        }
    }
}
