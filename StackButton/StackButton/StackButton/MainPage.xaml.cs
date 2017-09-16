using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StackButton
{
	public partial class MainPage : ContentPage
	{
        int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}

        private void YesClick(object sender, EventArgs e)
        {
            count++;
            var button = (Button)sender;
            button.Text = $"Click count: {count}";
        }

        private void NoClick(object sender, EventArgs e)
        {
            count++;
            var button = (Button)sender;
            button.Text = $"Click count: {count}";
        }



    }
}
