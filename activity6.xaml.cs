using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC3_MOD3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity6 : ContentPage
    {
        public activity6()
        {
            InitializeComponent();
        }
        private async void backpage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}