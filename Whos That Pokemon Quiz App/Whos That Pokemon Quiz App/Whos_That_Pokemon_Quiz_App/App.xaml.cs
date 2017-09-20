using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Whos_That_Pokemon_Quiz_App
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new Whos_That_Pokemon_Quiz_App.MainPage();
		}


        private void Start(object sender, EventArgs e)
        {

            var button = (Button)sender;
            button.Text = $"Good for you! Add me on steam @Pixel Amp!";

        }

    }
}
