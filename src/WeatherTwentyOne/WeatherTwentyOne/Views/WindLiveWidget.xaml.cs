﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherTwentyOne.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WindLiveWidget : ContentView
    {
        public WindLiveWidget()
        {
            InitializeComponent();
        }
    }
}