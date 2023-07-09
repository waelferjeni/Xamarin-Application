using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tpexam
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class dashboard : ContentPage
    {
        public dashboard()
        {
            InitializeComponent();
            if(App.isAdmin==1)
            {
                admin.IsVisible = true;
            }
        }

        private void Btnc1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ISET());   
        }

        private void Btnc2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new voiture());
        }
        private void Btnc3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new magasin());
        }
        private async void Btnc4(object sender, EventArgs e)
        {
            await DisplayAlert("Quit", "You want Quit", "OK");
            Navigation.PushAsync(new HomePage());
        }

        private void Btnc5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new admindb());
        }
    }
}