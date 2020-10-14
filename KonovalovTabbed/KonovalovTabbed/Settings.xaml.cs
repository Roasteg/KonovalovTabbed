using KonovalovTabbed.ColorPicker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KonovalovTabbed.ColorPicker;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace KonovalovTabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();
            
        }

        private void lfont_Clicked(object sender, EventArgs e)
        {
            App.Current.UserAppTheme = OSAppTheme.Light;
        }

        private void sfont_Clicked(object sender, EventArgs e)
        {
            App.Current.UserAppTheme = OSAppTheme.Dark;
        }
    }
}