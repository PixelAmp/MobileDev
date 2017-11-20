using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

//everything below this was added from the example app
using System.Collections.ObjectModel;
using System.Net.Http;
using static LearnWeatherAPI.Models.WeatherItemModel;
using System.Runtime.CompilerServices;

namespace LearnWeatherAPI.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        public DelegateCommand NavToNewPageCommand { get; set; }
        public DelegateCommand GetWeatherForLocationCommand { get; set; } 
        public DelegateCommand<WeatherItem> NavToMoreInfoPageCommand { get; set; }

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

        private string _locationEnteredByUser; //hold the user euntery
        public string LocationEnteredByUser
        {
            get { return _locationEnteredByUser; }
            set { SetProperty(ref _locationEnteredByUser, value); }
        }

        //list of weather locations
        private ObservableCollection<WeatherItem> _weatherCollection = new ObservableCollection<WeatherItem>();
        public ObservableCollection<WeatherItem> WeatherCollection
        {
            get { return _weatherCollection; }
            set { SetProperty(ref _weatherCollection, value); }
        }

        INavigationService _navigationService; //provides page navigation for View Models

        
        public MainPageViewModel(INavigationService navigationService)
        {
            //I think that this section just waits for commands to occur and sends the commands to the appropriate event
            _navigationService = navigationService;

            NavToNewPageCommand = new DelegateCommand(NavToNewPage);
            GetWeatherForLocationCommand = new DelegateCommand(GetWeatherForLocation);
            NavToMoreInfoPageCommand = new DelegateCommand<WeatherItem>(NavToMoreInfoPage);

            //Title = "Xamarin Forms Application + Prism";
            //ButtonText = "Add Name";

        }

        //navigate to new page
        //Don't know what this does right now...
        private async void NavToMoreInfoPage(WeatherItem weatherItem)
        {
            var navParams = new NavigationParameters();
            navParams.Add("WeatherItemInfo", weatherItem);
            await _navigationService.NavigateAsync("MoreInfoPage", navParams);
        }
        
        internal async void GetWeatherForLocation()
        {
            //need Microsoft.Net.Http to use HTTP (and maybe Microsoft.BCL.Build if you're having issues like me)

            HttpClient client = new HttpClient(); //makes new accesable HTTP client

            var uri = new Uri( //gets the URI from openweather
                string.Format(
                    $"http://api.openweathermap.org/data/2.5/weather?q={LocationEnteredByUser}&units=imperial&APPID=" + $"5da8d96113a5c72f1f9836c3c84a6351"));
            var response = await client.GetAsync(uri);

            WeatherItem weatherData = null;
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                weatherData = WeatherItem.FromJson(content);
            }
            WeatherCollection.Add(weatherData);
        }

        private async void NavToNewPage()
        {
            var navParams = new NavigationParameters();
            navParams.Add("NavFromPage", "MainPageViewModel");
            await _navigationService.NavigateAsync("SamplePageForNavigation", navParams);
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
