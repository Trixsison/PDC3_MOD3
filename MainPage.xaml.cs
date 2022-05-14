using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC3_MOD3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void activity1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity1());
        }
        private async void activity2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity2());
        }
        private async void activity3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity3());
        }
        private async void activity4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity4());
        }
        private async void activity5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity5());
        }
        private async void activity6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity6());
        }
    }
}
