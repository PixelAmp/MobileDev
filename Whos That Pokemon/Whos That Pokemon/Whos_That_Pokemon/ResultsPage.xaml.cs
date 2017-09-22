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
	public partial class ResultsPage : ContentPage
	{
		public ResultsPage (int correctCount)
		{
			InitializeComponent ();
            dataOutput.Text = (correctCount).ToString();
		}

	}
}