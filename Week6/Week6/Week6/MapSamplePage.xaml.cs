using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
//using Xamarin.Forms.Maps;
//using Xamarin.Forms.Xaml;

namespace Week6
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class MapSamplePage : ContentPage
    {
        public MapSamplePage()
        {
            InitializeComponent();


            InitializeComponent();

            var initialMapLocation = MapSpan.FromCenterAndRadius
                                            (new Position(33.1307785, -117.1601826)
                                             , Distance.FromMiles(1));

            MySampleMap.MoveToRegion(initialMapLocation);


            PlaceAMarker();
        }

        private void PlaceAMarker()
        {
            var position = new Position(33.1307785, -117.1601826); // Latitude, Longitude
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "custom pin",
                Address = "custom detail info"
            };


            MySampleMap.Pins.Add(pin);
        }
    }
}