using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Week9Prism.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {

        //binding properties

        
        public DelegateCommand ButtonClickedCommand //bind command
        {
            get;
            set;
        }

        private string _title; //bind string
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _ButtonText; //bind string
        public string ButtonText
        {
            get { return _ButtonText; }
            set { SetProperty(ref _ButtonText, value); }
        }


        private Color _ButtonColor; //bind color as a string
        public Color ButtonColor
        {
            get { return _ButtonColor; }
            set { SetProperty(ref _ButtonColor, value); }
        }

        private int _ClickCount; //bind string
        public int ClickCount
        {
            get { return _ClickCount; }
            set { SetProperty(ref _ClickCount, value); }
        }

        /*
        private bool _shouldShowLabel; 
        public bool shouldShowLabel
        {
            get { return _shouldShowLabel};
            set { return    }
        }
        */

        public MainPageViewModel()
        {
            ButtonClickedCommand = new DelegateCommand (ButtonClicked);
            
        }

        private void ButtonClicked()
        {
            if (ClickCount%2 == 0)
            {
                ButtonColor = Color.Pink;
            }

            else
            {
                ButtonColor = Color.Maroon;
            }

            ClickCount++;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";

            ButtonText = "Click Me PLZ";
            ButtonColor = Color.Blue;
            ClickCount = 0;
        }
    }
}
