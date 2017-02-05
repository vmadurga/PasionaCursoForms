using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using PasionaCursoForms.ViewModels.Base;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using PasionaCursoForms.Models;
using PasionaCursoForms.Pages;

namespace PasionaCursoForms.ViewModels
{
    public class SearchViewModel : BaseViewModel
    {
        private readonly Page _currentPage;

        public SearchViewModel(Page currentPage)
        {
            _currentPage = currentPage;
        }

        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Result> _searchList;
        public ObservableCollection<Result> SearchList
        {
            get { return _searchList; }
            set
            {
                _searchList = value;
                OnPropertyChanged();
            }
        }

        private ICommand _searchCommand;
        public ICommand SearchCommand => _searchCommand ?? (_searchCommand = new Command(SearchCommandExecute));

        private async void SearchCommandExecute()
        {
            try
            {
                string searchUrl = $"https://itunes.apple.com/search?term={SearchText}&entity=software&limit=20";
                var client = new HttpClient();
                var response = await client.GetAsync(searchUrl);
                var stringContent = await response.Content.ReadAsStringAsync();
                var listModel = JsonConvert.DeserializeObject<SearchResponseModel>(stringContent);
                SearchList = new ObservableCollection<Result>(listModel.Results);
            }
            catch (Exception ex)
            {
                await _currentPage.DisplayAlert("Error", "Ha ocurrido un error al realizar la búsqueda", "Aceptar");
            }
        }

        public async void OpenDetail(Result selectedItem)
        {
            await _currentPage.Navigation.PushAsync(new DetailPage(selectedItem));
        }

    }
}
