using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Week7
{

    //find out how to change the resource dictionary items
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void DetailClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            
        }
        private void TitleClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;


        }
        private void BGClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;

            
        }
    }
}
