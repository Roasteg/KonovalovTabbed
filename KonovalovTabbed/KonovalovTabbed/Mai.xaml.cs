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
    public partial class Mai : ContentPage
    {
        public Mai()
        {
            InitializeComponent();
            var lbl = new TapGestureRecognizer();
            lbl.Tapped += Lbl_Tapped;
            pyha1.GestureRecognizers.Add(lbl);
            var lbl2 = new TapGestureRecognizer();
            lbl2.Tapped += Lbl2_Tapped;
            pyha2.GestureRecognizers.Add(lbl2);
        }

        private void Lbl2_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Pidupaev", "See pidu toimub 01. mai", "Ok");
        }

        private void Lbl_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Pidupaev", "See pidu toimub 31. mai", "Ok");
        }
    }
}