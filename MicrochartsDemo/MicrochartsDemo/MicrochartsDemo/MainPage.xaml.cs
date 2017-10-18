using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Entry = Microcharts.Entry;

namespace MicrochartsDemo
{
    public partial class MainPage : ContentPage
    {
        List<Entry> entries = new List<Entry>
        {
            new Entry(200)
            {
                Label = "January",
                ValueLabel = "200",
                FillColor = SKColor.Parse("#266489")
            },


            new Entry(400)
            {
                Label = "February",
                ValueLabel = "400",
                FillColor = SKColor.Parse("#68B9C0")
            },
            new Entry(-100)
            {
                Label = "March",
                ValueLabel = "-100",
                FillColor = SKColor.Parse("#90D585")
            }

        };
        void butts()
        {
            var entries = new[]
    {
                new Entry(200)
                {
                    Label = "January",
                    ValueLabel = "200",
                    FillColor = SKColor.Parse("#266489")
                }
            };

            var chart = new BarChart() { Entries = entries };
        }


        public MainPage()
        {
            InitializeComponent();
        }
    }
}
