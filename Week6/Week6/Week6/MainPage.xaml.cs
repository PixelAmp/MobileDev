using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Week6
{
	public partial class MainPage : ContentPage
	{
        //Public Dictionary
        Dictionary<string, Color> nameToColor = new Dictionary<string, Color>()
        {
            { "Aqua", Color.Aqua }, { "BlanchedAlmond", Color.BlanchedAlmond },
            { "Gray", Color.Gray }, { "Green", Color.Green },
            { "Lime", Color.Lime }, { "Maroon", Color.Maroon },
            { "Navy", Color.Navy }, { "Olive", Color.Olive },
            { "Purple", Color.Purple }, { "Red", Color.Red },
            { "Silver", Color.Silver }, { "Teal", Color.Teal },
            { "White", Color.White }, { "Yellow", Color.Yellow }
        };

        public MainPage()
		{
			InitializeComponent();
            PopulatePicker();
		}

        public void PopulatePicker()
        {
            foreach (var item in nameToColor)
            {
                SamplePicker.Items.Add(item.Key);
            }
            
            SamplePicker.SelectedIndex = 0;

            SetBackground();
                    
        }

        void Handle_NavigateToMapSample(object sender, System.EventArgs e)
        {
            //Navigation.PushAsync(new MapSamplePage());
        }

        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Code to handle user making index changes in picker
            SetBackground();
        }

        void SetBackground()
        {
            //string colorName = SamplePicker.Items[SamplePicker.SelectedIndex];
            //PageThing.BackgroundColor = nameToColor[colorName];
            
            //does the same as above, but just in one line
            PageThing.BackgroundColor = nameToColor[SamplePicker.Items[SamplePicker.SelectedIndex]];
        }
    }
}
