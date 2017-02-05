using PasionaCursoForms.ViewModels;
using Xamarin.Forms;

namespace PasionaCursoForms.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new MainViewModel(this);
            InitializeComponent();
        }
    }
}
