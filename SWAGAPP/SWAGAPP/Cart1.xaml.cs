using SWAGAPP.DataB;
using SWAGAPP.Swag;
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
    public partial class Cart1 : ContentPage
    {
        public Cart1()
        {
            InitializeComponent();

            BindingContext = new Swag1();
        }

        private async void Saved(object sender, EventArgs e)
        {
            DataBase database = DataBase.Database;

            Swag1 item = BindingContext as Swag1;

            await database.SaveSwagItemAsync(item);

        }
    }
}