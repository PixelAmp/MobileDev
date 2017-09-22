using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Whos_That_Pokemon
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void StartClick(object sender, EventArgs e)
        {

            var button = (Button)sender;
            button.Text = $"Lets Play!";
            
            Navigation.PushAsync(new Q1());
        }

    }
}
