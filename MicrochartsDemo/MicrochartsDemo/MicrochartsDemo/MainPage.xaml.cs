using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace MicrochartsDemo
{
    
    public partial class MainPage : ContentPage
    {
        ///*
        List<Microcharts.Entry> entries = new List<Microcharts.Entry>
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
        //*/


        /*
        protected override void OnAppearing()
        {
            var entries = new[]
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

            var chart = new BarChart() { Entries = entries };
            //var chart2 = new LineChart() { Entries = entries };
            this.chartView.Chart = chart;
        }
        /*

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
