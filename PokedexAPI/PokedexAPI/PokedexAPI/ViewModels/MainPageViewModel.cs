using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Collections.ObjectModel;
using System.Net.Http;
using static PokedexAPI.Models.PokedexModel;
using System.Runtime.CompilerServices;

namespace PokedexAPI.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        public DelegateCommand TestingCommand { get; set; }
        public DelegateCommand GetPokemonCommand { get; set; }
        public DelegateCommand<PokedexItem> NavToMoreInfoPageCommand { get; set; }

        private string _title; // this is only used by the default thing, could probably delete/remove
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _buttonText; 
        public string ButtonText
        {
            get { return _buttonText; }
            set { SetProperty(ref _buttonText, value); }
        }

        private string _pokemonEnteredByUser; //hold the user euntery
        public string PokemonEnteredByUser
        {
            get { return _pokemonEnteredByUser; }
            set { SetProperty(ref _pokemonEnteredByUser, value); }
        }

        private ObservableCollection<PokedexItem> _pokedexCollection = new ObservableCollection<PokedexItem>();
        public ObservableCollection<PokedexItem> PokedexCollection
        {
            get { return _pokedexCollection; }
            set { SetProperty(ref _pokedexCollection, value); }
        }

        INavigationService _navigationService; //provides page navigation for View Models


        public MainPageViewModel(INavigationService navigationService)
        {
            //I think that this section just waits for commands to occur and sends the commands to the appropriate event
            _navigationService = navigationService;

            TestingCommand = new DelegateCommand(TestingFunc);

            GetPokemonCommand = new DelegateCommand(GetPokemon);
            NavToMoreInfoPageCommand = new DelegateCommand<PokedexItem>(NavToMoreInfoPage);
      
        }

        //navigate to new page
        //sends all dta data currently in the model to the new page
        private async void NavToMoreInfoPage(PokedexItem pokedexItem)
        {
            var navParams = new NavigationParameters();
            navParams.Add("PokedexItemInfo", pokedexItem);
            await _navigationService.NavigateAsync("MoreInfoPage", navParams);
        }

        

        internal async void GetPokemon()
        {

            HttpClient client = new HttpClient(); //makes new accesable HTTP client

            //calls website, sending the user entry, website responds and sends back data
            //var uri = new Uri(string.Format( $"http://pokeapi.co/api/v2/pokemon/{PokemonEnteredByUser}/"));

            var uri = new Uri("https://pokeapi.co/api/v2/pokemon/" + PokemonEnteredByUser + "/");


            //THERE IS AN ERROR HERE WHERE THE APP BREAKS FOR NO REASON I DON'T KNOW HOW TO FIX IT
            //I looked into the data the API is sendiong me and have decided to abandon this project and work on a different API
            //This pokemon one give a LOT of useless information that is far too comp[icated to display
            var response = await client.GetAsync(uri);

            
            PokedexItem PokedexData = null;
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                PokedexData = PokedexItem.FromJson(content);
            }
            PokedexCollection.Add(PokedexData); //adds recived data to collection
        }

        private async void NavToNewPage()
        {
            var navParams = new NavigationParameters();
            navParams.Add("NavFromPage", "MainPageViewModel");
            await _navigationService.NavigateAsync("SamplePageForNavigation", navParams);
        }





        private void TestingFunc()
        {
            PokedexItem PokedexData = null;
            
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
