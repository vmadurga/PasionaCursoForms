using PasionaCursoForms.Models;
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

        private void SearchListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var currentViewModel = BindingContext as SearchViewModel;
            currentViewModel?.OpenDetail(e.SelectedItem as Result);
        }
    }
}
