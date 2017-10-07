using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

//[assembly: XamlCompilation (XamlCpmpilationOptions.Compile)]

namespace Week6
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			//MainPage = new Week6.MainPage();
            MainPage = new NavigationPage(new Week6.MainPage());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
