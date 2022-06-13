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
    public partial class FlyoutMenu : ContentPage
    {
        public FlyoutMenu()
        {
            InitializeComponent();
        }
        public object Listview { get; internal set; }
    }
}