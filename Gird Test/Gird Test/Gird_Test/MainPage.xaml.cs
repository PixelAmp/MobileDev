using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Gird_Test
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void RollClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Navigation.PushAsync(new RollInfo());
        }

        private void EscapeClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Navigation.PushAsync(new EscapeInfo());
        }
    }
}
