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
        public InfoPage(ImageCellTemplate CellInfo)
        {
            InitializeComponent();
            BindingContext = CellInfo;
        }

	}
}