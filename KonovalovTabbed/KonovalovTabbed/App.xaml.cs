using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KonovalovTabbed
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            this.UserAppTheme = OSAppTheme.Dark;

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
