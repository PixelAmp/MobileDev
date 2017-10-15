using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RestaurantFinder
{
    public partial class MainPage : ContentPage
    {
        public struct RestData
        {
            public string Name;
            public string Detail;
            public float Longi;
            public float Lati;
        }

        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_NavigateToMap(object sender, System.EventArgs e)
        {
            RestData LData; //makes a struct to hold info
            var btn = (Button)sender;
            string LName = btn.Text;//Grabs button's name      

            //have to initialize all the valies so that I can pass the struct
            LData.Name = LName;
            LData.Detail = "";
            LData.Longi = 0f;
            LData.Lati = 0f;

            switch (LName)
            {
                case "Two Brothers from Italy":
                    LData.Detail = "591 Grand Ave, San Marcos, CA 92078";
                    LData.Longi = 33.1364535f;
                    LData.Lati = -117.1798027f;
                    break;
                case "Hungry Bear Deli":                    
                    LData.Detail = "2205 S. Melrose Drive 103, Vista, CA 92081";
                    LData.Longi = 33.1463885f;
                    LData.Lati = -117.2439337f;
                    break;
                case "Tacos Alex":                   
                    LData.Detail = "250 W Mission Rd, San Marcos, CA 92069";
                    LData.Longi = 33.1463885f;
                    LData.Lati = -117.2439337f;
                    break;
                case "Leucadia Pizzeria":
                    LData.Detail = "2215 S Melrose Dr Suite 105, Vista, CA 92081";
                    LData.Longi = 33.1477438f;
                    LData.Lati = -117.2400472f;
                    break;
                case "Hyuga Sushi":
                    LData.Detail = "844 W San Marcos Blvd, San Marcos, CA 92078";
                    LData.Longi = 33.1365568f;
                    LData.Lati = -117.1857679f;
                    break;
            }

            Navigation.PushAsync(new MapPage(LData));
        }
    }
}
