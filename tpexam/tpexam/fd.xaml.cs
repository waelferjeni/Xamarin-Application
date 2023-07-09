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
    public partial class fd : ContentPage
    {
        public fd()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                myCollectionView.ItemsSource = await App.MyDatabase.Category("food");
            }
            catch
            {

            }
        }
    }
}