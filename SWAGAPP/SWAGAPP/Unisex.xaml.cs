﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWAGAPP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Unisex : ContentPage
    {
        public Unisex()
        {
            InitializeComponent();
        }

        private async void Price_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cart1());
        }
    }
}