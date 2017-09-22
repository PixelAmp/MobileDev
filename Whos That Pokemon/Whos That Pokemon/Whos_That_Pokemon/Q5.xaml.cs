using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Whos_That_Pokemon
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Q5 : ContentPage
	{
		public Q5 ()
		{
			InitializeComponent ();
		}
        private void Ans1(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Navigation.PushAsync(new ResultsPage());
        }

        private void Ans2(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Navigation.PushAsync(new ResultsPage());
        }

        private void Ans3(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Navigation.PushAsync(new ResultsPage());
        }

        private void Ans4(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Navigation.PushAsync(new ResultsPage());
        }
    }
}