using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Whos_That_Pokemon
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Q1 : ContentPage
	{
        public int correctCount = 0;
        int count = 0;
        public Q1 ()
		{
            InitializeComponent();
        }


        private void Ans1(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Navigation.PushAsync(new Q2(correctCount));
        }

        private void Ans2(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Navigation.PushAsync(new Q2(correctCount));
        }

        private void Ans3(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Navigation.PushAsync(new Q2(++correctCount));
        }

        private void Ans4(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Navigation.PushAsync(new Q2(correctCount));
        }
    }
}