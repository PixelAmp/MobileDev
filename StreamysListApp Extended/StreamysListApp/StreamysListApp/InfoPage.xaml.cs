using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StreamysListApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InfoPage : ContentPage
	{
        string url;
        public InfoPage(ImageCellTemplate CellInfo)
        {
            InitializeComponent();
            BindingContext = CellInfo;
            url = CellInfo.URL;
        }

        void NavigateToChannel(object sender, System.EventArgs e) => Device.OpenUri(new Uri(url));
    }
}