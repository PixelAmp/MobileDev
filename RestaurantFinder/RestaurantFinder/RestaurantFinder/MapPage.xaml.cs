using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;//use maps commands

namespace RestaurantFinder
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MapPage : ContentPage
	{

        public string Name;
        public string Detail;
        public float Longi;
        public float Lati;

        public MapPage(MainPage.RestData LData)
		{
			InitializeComponent ();
            //initialize values with passed struct
            Name = LData.Name;
            Detail = LData.Detail;
            Longi = LData.Longi;
            Lati = LData.Lati;
            
            var initialMapLocation = MapSpan.FromCenterAndRadius (new Position(Longi, Lati), Distance.FromMiles(1));

            RestMap.MoveToRegion(initialMapLocation);
            
            PlaceAMarker();
        }

        private void PlaceAMarker() //adds a pin
        {
            var position = new Position(Longi, Lati); // Latitude, Longitude
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = Name,
                Address = Detail
            };
            
            RestMap.Pins.Add(pin);
        }

        void Handle_C2Street(object sender, System.EventArgs e)
        {
            RestMap.MapType = MapType.Street;
        }
        void Handle_C2Sat(object sender, System.EventArgs e)
        {
            RestMap.MapType = MapType.Satellite;
        }
        void Handle_C2Hybrid(object sender, System.EventArgs e)
        {
            RestMap.MapType = MapType.Hybrid;
        }


    }
}