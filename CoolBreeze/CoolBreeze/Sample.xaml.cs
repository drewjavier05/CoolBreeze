using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoolBreeze
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sample : ContentPage
    {
        public Sample()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Xamarin", "Halooo", "OK");
        }


        private void Button_OnClickedAbout(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());
        }
    }
}