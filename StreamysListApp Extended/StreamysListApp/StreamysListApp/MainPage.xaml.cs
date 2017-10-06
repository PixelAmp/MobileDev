using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel; //needed for obsevable object

namespace StreamysListApp
{
    public partial class MainPage : ContentPage
    {
        //public so that it can be modified whithout overwriting
        public ObservableCollection<ImageCellTemplate> listOfItems = new ObservableCollection<ImageCellTemplate>();

        public MainPage()
        {
            InitializeComponent();
            PopulateListView();//calls function
        }

        public void PopulateListView()
        {
            //array/list that is can be filled with the prebuilt cells and filled in
            //var listOfItems = new ObservableCollection<ImageCellTemplate>()
            listOfItems = new ObservableCollection<ImageCellTemplate>()
            {
                new ImageCellTemplate() //1
                {
                    IconSource = ImageSource.FromFile("SP7Icon.jpg"),
                    ImageText = "SugarPine 7",
                    DetailText = "Show of the year",
                    URL = "https://www.youtube.com/channel/UCEY0yxj6QxG4RBVRSe5orig",
                    BioText = "Sugar Pine 7 is a series of \"alternative lifestyle\" videos " +
                    "revolving around Steven Suptic and his friends Cib and James. " +
                    "The style can been described as freeze-frame narrated, semi-scripted comedy vlogs."
                },

                new ImageCellTemplate() //2
                {
                    IconSource = ImageSource.FromFile("DTIcon.jpg"),
                    ImageText = "Dolan Twins",
                    DetailText = "Creator of the year",
                    URL = "https://www.youtube.com/user/TheDolanTwins",
                    BioText = "Ethan and Grayson Dolan (born December 16, 1999), collectively known as The Dolan Twins, " +
                    "are an American comedy duo who rose to prominence in May 2013 on the video sharing application Vine. " +
                    "They are currently signed to AwesomenessTV, and have been since 2015. The twins are from the Long Valley " +
                    "section of Washington Township, Morris County, New Jersey. Since their beginnings, the duo has accumulated " +
                    "over 6.4 million followers on Vine and 4 million subscribers on YouTube, and embarked on a world tour titled " +
                    "the \"4OU\" Tour in 2016. The duo was also involved in a Twitter ad campaign for the social network's new stickers feature."
                },

                new ImageCellTemplate() //3
                {
                    IconSource = ImageSource.FromFile("RLIcon.jpg"),
                    ImageText = "Rhett & Link’s Buddy System",
                    DetailText = "Comedy Series",
                    URL = "https://www.youtube.com/playlist?list=PLJ49NV73ttruI9rFSL0xrqHzZjJmdH219",
                    BioText = "Rhett and Link's Buddy System is a web television series produced exclusively for YouTube Red, created " +
                    "by, written by and starring comedy duo Rhett McLaughlin and Link Neal. The series premiered with episodes one and " +
                    "two being released on October 19, 2016 on Rhett and Link's Good Mythical Morning channel. Plot consists of Rhett and " +
                    "Link's co-ex-girlfriend is now a famous infomercial star, who is threatening to take control of the duo's famous show, " +
                    "Good Mythical Morning. They must work together on an adventure to get it back."
"
                },

                new ImageCellTemplate() //4
                {
                    IconSource = ImageSource.FromFile("VFIcon.jpg"),
                    ImageText = "Worth It",
                    DetailText = "Food",
                    URL = "https://www.youtube.com/playlist?list=PL5vtqDuUM1DmXwYYAQcyUwtcalp_SesZD",
                    BioText = "Steven and Andrew (along with their camera and sound guy, Adam) travel from restaurant to restaurant " +
                    "trying the best foods at various price points. They start with the least expensive foods and work their way up to " +
                    "the most extravagant, decadent, over-the-top foods in existence to find out which one is the most worth its price"
"
                },

                new ImageCellTemplate() //5
                {
                    IconSource = ImageSource.FromFile("TYIcon.jpg"),
                    ImageText = "The Young Turks",
                    DetailText = "News and Culture",
                    URL = "https://www.youtube.com/user/TheYoungTurks",
                    BioText = "The Young Turks (TYT) is an American news and commentary program on YouTube, which also serves as the" +
                    " flagship program of the TYT Network, a multi-channel network of associated web series focusing on news and current events."
                },

                new ImageCellTemplate() //6
                {
                    IconSource = ImageSource.FromFile("VEIcon.jpg"),
                    ImageText = "Veritasium",
                    DetailText = "Scienece and Education",
                    URL = "https://www.youtube.com/user/1veritasium",
                    BioText = "Veritasium is an English-language educational science channel on YouTube created by Derek Muller, a physicist, " +
                    "in 2011. The videos range in style from interviews with experts, such as 2011 Physics Nobel Laureate Brian Schmidt, to " +
                    "science experiments, dramatizations, songs, and—a hallmark of the channel—interviews with the public to uncover misconceptions " +
                    "about science."
                },

                new ImageCellTemplate() //7
                {
                    IconSource = ImageSource.FromFile("POIcon.jpg"),
                    ImageText = "Poppy",
                    DetailText = "Breakthrough Artist",
                    URL = "https://www.youtube.com/user/thatPoppyTV",
                    BioText = "Poppy, also known as That Poppy, is an American singer, songwriter, ambient music composer and YouTube " +
                    "personality. She moved to Los Angeles in 2014 to pursue a musical career, where she signed with Island Records and " +
                    "released her debut EP, Bubblebath (2016). In late 2016, she became the face of Sanrio's \"Hello Sanrio\" collection."
                },

                new ImageCellTemplate() //8
                {
                    IconSource = ImageSource.FromFile("CNIcon.jpg"),
                    ImageText = "Casey Neistat",
                    DetailText = "Cinematography",
                    URL = "https://www.youtube.com/user/caseyneistat",
                    BioText = "Casey Neistat is an American YouTube personality, filmmaker, vlogger, and co-founder of multimedia company Beme. " +
                    "Casey Neistat started to post daily vlogs on YouTube on March 24, 2015. On his May 15, 2015 vlog post \"The Vice President, " +
                    "Outer Space and the Baby\", Neistat stated that he sees his vlogs more as a forum as opposed to a daily journal. On January 19, " +
                    "2016 Neistat posted his 300th vlog. As a result of vlogging everyday, Neistat said he has chosen to refrain from making any " +
                    "feature length content. Neistat is frequently seen using and discussing his collection of Boosted boards in his daily vlogs, " +
                    "which are sometimes showcased in his other YouTube videos."
"

                },

                new ImageCellTemplate() //9
                {
                    IconSource = ImageSource.FromFile("DSIcon.jpg"),
                    ImageText = "DeStorm Power (“Caught”)",
                    DetailText = "Writing",
                    URL = "https://www.youtube.com/playlist?list=PLU9snlkp5CiyLEeBx5WM72esFhqwoJ1JW",
                    BioText = "Destorm is an American Music Award, Streamy Award and YouTube Award winning" +
                    " musician/actor/comedian with over 12 million followers across various social platforms " +
                    "including Facebook, Instagram and YouTube. He has had over 3.5 billion video views across " +
                    "all major social platforms of serialized short form scripted, video content. "
                },

                new ImageCellTemplate() //10
                {
                    IconSource = ImageSource.FromFile("COIcon.jpg"),
                    ImageText = "Corridor",
                    DetailText = "Visual and Special Effects",
                    URL = "https://www.youtube.com/user/CorridorDigital",
                    BioText = "Corridor Digital is a company located in Los Angeles, USA. Corridor Digital uploads" +
                    " short movies to YouTube every month. They specialise in visual special effects and physical effects." +
                    " It was founded by YouTubers; Sam Gorski, Niko Pueringer and Jake Watson. They currently have a total " +
                    "of 4.4 million subscribers."
                },
            };

            WebsiteListView.ItemsSource = listOfItems; //fills list view with newly filled array
        }

        void Handle_NavigateToUrl(object sender, System.EventArgs e)
        {
            var listViewItem = (MenuItem)sender;
            var url = (string)listViewItem.CommandParameter;
            Device.OpenUri(new Uri(url));
        }

        void Handle_Refresh(object sender, System.EventArgs e)
        {
            //Calls the function to repopulate the list view
            PopulateListView();
            //makes spinning thing go away
            WebsiteListView.IsRefreshing = false;
        }

        //goes to info page, grabbing the name from templae
        void Handle_To_Info(object sender, System.EventArgs e)
        {
            var listViewItem = (MenuItem)sender;
            var CellInfo = (ImageCellTemplate)listViewItem.CommandParameter;
            
            Navigation.PushAsync(new InfoPage(CellInfo));
        }
        //TO DO: Pass info from mainpage to the info page to display a bunch of stuff

        void Handle_Delete_Cell(object sender, System.EventArgs e)
        {
            MenuItem Item = (MenuItem)sender;
            listOfItems.Remove((ImageCellTemplate)Item.BindingContext);
        }
    }
}
