using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SWAGAPP
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();
            main.view.ItemSelected += OnSelectedItem;
        }

        private void OnSelectedItem(object sender, SelectedItemChangedEventArgs x)
        {
            var item = x.SelectedItem as FlyoutNav;
            if (item != null)
            {
                Detail = new NavigationPage(Activator.CreateInstance(item.Navpages) as Page);
                main.view.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
