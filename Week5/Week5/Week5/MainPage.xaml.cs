using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel; //needed for obsevable object

namespace Week5
{
    public partial class MainPage : ContentPage
    {
        //public so that it can be modified whithout overwriting
        public ObservableCollection<ListTemplate> listOfItems = new ObservableCollection<ListTemplate>();

        public MainPage()
        {
            InitializeComponent();
            PopulateListView();
        }

        void PopulateListView()
        {
            //adds individual template
            //listOfItems.Add(new ListTemplate()

            //array/list that is can be filled with the prebuilt cells and filled in
            listOfItems = new ObservableCollection<ListTemplate>()
            {
                new ListTemplate()
                {
                    IconSource = ImageSource.FromFile("Icon.jpg"),
                    ImageText = "SugarPine 7",
                    DetailText = "Show of the year",
                    URL = "https://www.youtube.com/channel/UCEY0yxj6QxG4RBVRSe5orig",
                },

                new ListTemplate()
                {
                    IconSource = ImageSource.FromFile("Icon.jpg"),
                    ImageText = "Casey Neistat",
                    DetailText = "Person of the Year",
                    URL = "https://www.youtube.com/channel/UCEY0yxj6QxG4RBVRSe5orig",
                },
            };

            Week5List.ItemsSource = listOfItems; //fills list view with newly filled array
        }

        void Handle_NavigateToUrl(object sender, System.EventArgs e)
        {
            //opens browser
            var listViewItem = (MenuItem)sender;
            var url = (string)listViewItem.CommandParameter;
            Device.OpenUri(new Uri(url));

        }

        void Handle_Delete_Cell(object sender, System.EventArgs e)
        {
            MenuItem Item = (MenuItem)sender;
            listOfItems.Remove((ListTemplate)Item.BindingContext);
        }


        void Handle_Refresh(object sender, System.EventArgs e)
        {
            //adds template
            listOfItems.Add(new ListTemplate()
            {
                IconSource = ImageSource.FromFile("Icon.jpg"),
                ImageText = "SugarPine 7",
                DetailText = "Show of the year",
                URL = "https://www.youtube.com/channel/UCEY0yxj6QxG4RBVRSe5orig",
            }
            );
            Week5List.ItemsSource = listOfItems; //fills list view with newly filled array
            Week5List.IsRefreshing = false;
        }

        //goes to info page, grabbing the name from templae
        void Handle_To_Info(object sender, System.EventArgs e)
        {
            /*
            var listViewItem = (MenuItem)sender;
            var Name = (string)listViewItem.ImageText;
            Navigation.PushAsync(new InfoPage(Name));
            */
            Navigation.PushAsync(new InfoPage());
        }
        //TO DO: Pass info from mainpage to the info page to display a bunch of stuff

    }
}
