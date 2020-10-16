using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KonovalovTabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            OpenActSheet();
        }

        private async void OpenActSheet()
        {
            string opt = await DisplayActionSheet("Mis külg avada?", "Cancel", "","Talv", "Sügis", "Kevad", "Suvi");
            if (opt == "Sügis")
            {
                CurrentPage = Children[2];
            }
            else if(opt == "Talv")
            {
                CurrentPage = Children[0];
            }
            else if(opt == "Kevad")
            {
                CurrentPage = Children[1];
            }
            else if(opt=="Suvi")
            {
                CurrentPage = Children[3];
            }
        }
    }
}