﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Xamarin.Forms.Xaml;
using static TMDb_API_app.Models.TMDbMovieModel;

namespace TMDb_API_app.ViewModels
{
    public class MoreInfoPageViewModel : BindableBase, INavigatedAware
    {
		INavigationService _navigationService;

		public DelegateCommand GoBackCommand { get; set; }

        private MovieItem _movieItem;
        public MovieItem MovieItem
        {
            get { return _movieItem; }
            set { SetProperty(ref _movieItem, value); }
        }

        public MoreInfoPageViewModel(INavigationService navigationService)
        {
			_navigationService = navigationService;

			GoBackCommand = new DelegateCommand(GoBack);
		}

		private void GoBack()
		{
			_navigationService.GoBackAsync();
		}

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("MovieItemInfo"))
            {
                MovieItem = (MovieItem)parameters["MovieItemInfo"];
            }
        }
    }
}
