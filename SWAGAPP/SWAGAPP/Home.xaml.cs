using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWAGAPP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        private async void Mens(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Men());
        }

        private async void Womens(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Women());
        }

        private async void Unisex(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Unisex());
        }

        private async void Children(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Children());
        }
    }
}