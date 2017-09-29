using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms; //needs to be added to use ImageSource for Icon

namespace Streamys_Winners_List
{
    class ImageCellTemplate
    {
        public ImageSource IconSource
        {
            get;
            set;
        }

        public string ImageText
        {
            get;
            set;
        }

        public string DetailText
        {
            get;
            set;
        }

        public string URL
        {
            get;
            set;
        }
    }
}
