using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;


namespace Week4_Test
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
            var listOfItems = new ObservableCollection<ImageCellItem>() 
            {
                new ImageCellItem()
                {
                    IconSource = ImageSource.FromFile("EscapePlanetIcon.png"),
                    ImageText = "Escape the Planet",
                    DetailText = "GOTY 10/10"

                },

                new ImageCellItem()
                {
                    IconSource = ImageSource.FromFile("RollABallRaplhIcon.png"),
                    ImageText = "Roll A Ball Ralph",
                    DetailText = "Masterful Remaster"
                },
            };

            SampleList.ItemsSource = listOfItems; //fills list view with newly filled array


            //ToDo make a URL thing in the template and in this file so that it will go to it on click/tap
        }
    }



	
}
