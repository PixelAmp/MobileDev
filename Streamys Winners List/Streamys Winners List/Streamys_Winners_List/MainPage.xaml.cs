using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Streamys_Winners_List
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            PopulateListView();//calls function
        }

        private void PopulateListView()
        {
            //array/list that is can be filled with the prebuilt cells and filled in
            var listOfItems = new ObservableCollection<ImageCellTemplate>()
            {
                new ImageCellTemplate() //1
                {
                    IconSource = ImageSource.FromFile("SP7Icon.png"),
                    ImageText = "SugarPine 7",
                    DetailText = "Show of the year",
                    URL = "https://www.youtube.com/channel/UCEY0yxj6QxG4RBVRSe5orig",
                },

                new ImageCellTemplate() //2
                {
                    IconSource = ImageSource.FromFile("DLIcon.png"),
                    ImageText = "Dolan Twins",
                    DetailText = "Creator of the year",
                    URL = "https://www.youtube.com/user/TheDolanTwins",
                },

                new ImageCellTemplate() //3
                {
                    IconSource = ImageSource.FromFile("RLIcon.png"),
                    ImageText = "Rhett & Link’s Buddy System",
                    DetailText = "Comedy Series",
                    URL = "https://www.youtube.com/playlist?list=PLJ49NV73ttruI9rFSL0xrqHzZjJmdH219",
                },

                new ImageCellTemplate() //4
                {
                    IconSource = ImageSource.FromFile("Icon.png"),
                    ImageText = "Worth It*",
                    DetailText = "Food *(Should have been Binging with Babish)",
                    URL = "https://www.youtube.com/playlist?list=PL5vtqDuUM1DmXwYYAQcyUwtcalp_SesZD",
                },

                new ImageCellTemplate() //5
                {
                    IconSource = ImageSource.FromFile("YTIcon.png"),
                    ImageText = "The Young Turks*",
                    DetailText = "News and Culture *(Should have Been The Philip DeFranco Show)",
                    URL = "https://www.youtube.com/user/TheYoungTurks",
                },

                new ImageCellTemplate() //6
                {
                    IconSource = ImageSource.FromFile("VEIcon.png"),
                    ImageText = "Veritasium",
                    DetailText = "Scienece and Education",
                    URL = "https://www.youtube.com/user/1veritasium",
                },

                new ImageCellTemplate() //7
                {
                    IconSource = ImageSource.FromFile("POIcon.png"),
                    ImageText = "Poppy",
                    DetailText = "Breakthrough Artist",
                    URL = "https://www.youtube.com/user/thatPoppyTV",
                },

                new ImageCellTemplate() //8
                {
                    IconSource = ImageSource.FromFile("CNIcon.png"),
                    ImageText = "Casey Neistat",
                    DetailText = "Cinematography",
                    URL = "https://www.youtube.com/user/caseyneistat",
                },

                new ImageCellTemplate() //9
                {
                    IconSource = ImageSource.FromFile("DSIcon.png"),
                    ImageText = "DeStorm Power (“Caught”)",
                    DetailText = "Writing",
                    URL = "https://www.youtube.com/playlist?list=PLU9snlkp5CiyLEeBx5WM72esFhqwoJ1JW",
                },

                new ImageCellTemplate() //10
                {
                    IconSource = ImageSource.FromFile("COIcon.png"),
                    ImageText = "Corridor",
                    DetailText = "Visual and Special Effects",
                    URL = "https://www.youtube.com/user/CorridorDigital",
                },

            };

            WebsiteListView.ItemsSource = listOfItems; //fills list view with newly filled array
        }

        void Handle_NavigateToUrl(object sender, System.EventArgs e)
        {
            var listViewItem = (MenuItem)sender;
            var url = (string)listViewItem.CommandParameter;
            Device.OpenUri(new Uri(url));
        }
    }
}
