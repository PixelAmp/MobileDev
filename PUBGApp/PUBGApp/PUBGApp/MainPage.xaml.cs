using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PUBGApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Click(object sender, EventArgs e)
        {
            
            var button = (Button)sender;
            button.Text = $"Good for you! Add me on steam @Pixel Amp!";

        }
    }
}
