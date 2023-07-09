using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using tpexam.Model;
using tpexam.View;
namespace tpexam
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class admindbDetail : ContentPage
    {
        public admindbDetail()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            try
            {

                base.OnAppearing();
                myCollectionView.ItemsSource = await App.MyDatabase.ReadProducts();
            }
            catch
            {

            }
        }

        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductDetail());
        }

        async void SwipeItem_Invoked(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var product = item.CommandParameter as ProductModel;
            await Navigation.PushAsync(new ProductDetail(product));
        }

        async void SwipeItem_Invoked_1(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var product = item.CommandParameter as ProductModel;
            var result = await DisplayAlert("Delete", $"Delete {product.Name} from the database", "Yes", "No");
            if (result)
            {
                await App.MyDatabase.DeleteProduct(product);
                myCollectionView.ItemsSource = await App.MyDatabase.ReadProducts();
            }
        }
    }
}