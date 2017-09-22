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
	public partial class Q3 : ContentPage
	{
        public int newCount;
		public Q3 (int oldCount)
		{
			InitializeComponent ();
            newCount = oldCount;
		}
        private void Ans1(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Navigation.PushAsync(new Q4(newCount));
        }

        private void Ans2(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Navigation.PushAsync(new Q4(newCount));
        }

        private void Ans3(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Navigation.PushAsync(new Q4(newCount));
        }

        private void Ans4(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Navigation.PushAsync(new Q4(++newCount));
        }
    }
}