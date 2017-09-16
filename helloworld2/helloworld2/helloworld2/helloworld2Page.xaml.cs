using Xamarin.Forms;

using System;
using System.Threading.Tasks;
using System.Threading;

namespace helloworld2
{
    public partial class helloworld2Page : ContentPage
    {

        public Label MyLabel { get; private set; }
        private int _time = 0;

        public helloworld2Page()
        {
            InitializeComponent();

            string text2 = "table 2 is the best in the world";

                
            MyLabel = new Label()
            {
                Text = text2,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Aqua,
                TextColor = Color.BlanchedAlmond
            };
            //Content = MyLabel;

            var button = new Button()
            {
                BackgroundColor = Color.BlanchedAlmond,

            };
            button.Text = "Press Me!";
            button.Clicked += Button_Clicked;

            var layout = new StackLayout();
            Content = layout;
            layout.Children.Add(button);
            layout.Children.Add(MyLabel);


            Timer timer = new Timer((variable) => {
                Device.BeginInvokeOnMainThread(() => {
                    MyLabel.Text = text2 + "\n" + (_time++).ToString();
                }); 
            }, null, 0, 1000);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Content = MyLabel;
        }
    }
}
