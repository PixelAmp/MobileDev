﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms; //needs to be added to use ImageSource for Icon

namespace Week5
{
    public class ListTemplate //public because it is private by default
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
