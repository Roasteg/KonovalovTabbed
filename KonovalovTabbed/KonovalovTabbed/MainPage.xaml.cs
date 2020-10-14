using KonovalovTabbed.ColorPicker;
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
        ColPick cp = new ColPick();
        public MainPage()
        {
            InitializeComponent();
            OpenActSheet();
            if (ColPick.y == 1)
            {
                tabz.BarBackgroundColor = cp.col[1];
                tabz.BarTextColor = cp.col[2];
            }
            else if (ColPick.y == 0)
            {
                tabz.BarBackgroundColor = cp.col[2];
                tabz.BarTextColor = cp.col[0];
            }
        }

        private async void OpenActSheet()
        {
            string opt = await DisplayActionSheet("Mis kylg avada?", "Cancel", "","Talv", "Sygis", "Kevad", "Suvi");
            if (opt == "Sygis")
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