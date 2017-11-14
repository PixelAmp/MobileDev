using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Net.Http;
using static TMDb_API_app.Models.TMDbMovieModel; //hold model for movie
using System.Runtime.CompilerServices;
using static TMDb_API_app.Models.TMDbSearchModel; //holds movie's id to use to search for the movie



namespace TMDb_API_app.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        public DelegateCommand SearchMovieCommand { get; set; }
        public DelegateCommand<MovieItem> NavToMoreInfoPageCommand { get; set; }
        public DelegateCommand<MovieItem> DeleteCellCommand { get; set; }

        private string _title; // this is only used by the default thing, could probably delete/remove
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _buttonText; //button used to add the name of the place
        public string ButtonText
        {
            get { return _buttonText; }
            set { SetProperty(ref _buttonText, value); }
        }

        private string _movieEnteredByUser; //hold the user euntery
        public string MovieEnteredByUser
        {
            get { return _movieEnteredByUser; }
            set { SetProperty(ref _movieEnteredByUser, value); }
        }

        //holds all the movies that have been searched
        private ObservableCollection<MovieItem> _movieCollection = new ObservableCollection<MovieItem>();
        public ObservableCollection<MovieItem> MovieCollection
        {
            get { return _movieCollection; }
            set { SetProperty(ref _movieCollection, value); }
        }

        INavigationService _navigationService; //provides page navigation for View Models


        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
                     
            SearchMovieCommand = new DelegateCommand(GetMovieID);
            NavToMoreInfoPageCommand = new DelegateCommand<MovieItem>(NavToMoreInfoPage);
            DeleteCellCommand = new DelegateCommand<MovieItem>(Handle_Delete_Cell);
        }

        //navigate to new page, passing the data of the current paramiter
        private async void NavToMoreInfoPage(MovieItem movieItem)
        {
            var navParams = new NavigationParameters();
            navParams.Add("MovieItemInfo", movieItem);
            await _navigationService.NavigateAsync("MoreInfoPage", navParams);
        }

        void Handle_Delete_Cell(MovieItem movieItem)
        {
            MovieCollection.Remove(movieItem);
        }

        //uses Search API and gets ID of the first result, then sends it to the Movie API
        internal async void GetMovieID()
        {
            HttpClient client = new HttpClient();
            var uri = new Uri(string.Format($"https://api.themoviedb.org/3/search/movie?api_key=145877ef7a4418f79d855ef763fa0698&language=en-US&query={MovieEnteredByUser}&page=1&include_adult=false"));
            var response = await client.GetAsync(uri);

            SearchItem SearchData = null;

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                SearchData = SearchItem.FromJson(content);

                //IDThing = SearchData.Results[0].ID;

                //sends movie ID along to next function
                GetMovieInfo(SearchData.Results[0].ID); 
            }
        }

        //gets the Movie ID from the search function and retrives the data from the 
        internal async void GetMovieInfo(int MovieID)
        {
            HttpClient client = new HttpClient(); 
            var uri = new Uri(string.Format($"https://api.themoviedb.org/3/movie/{MovieID}?language=en-US&api_key=145877ef7a4418f79d855ef763fa0698"));
            
            var response = await client.GetAsync(uri);

            MovieItem MovieData = null;

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                MovieData = MovieItem.FromJson(content);
            }
           MovieCollection.Add(MovieData);
        }

       

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }
    }
}
