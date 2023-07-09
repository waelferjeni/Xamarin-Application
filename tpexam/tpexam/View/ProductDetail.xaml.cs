using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tpexam.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetail : ContentPage
    {
        public ProductDetail()
        {
            InitializeComponent();
        }
        Model.ProductModel _product;
        public ProductDetail(Model.ProductModel product)
        {
            InitializeComponent();
            Title = "Edit Infor";
            _product = product;
            nameEntry.Text = product.Name;
            prixEntry.Text = product.Prix.ToString();
            categoryEntry.Text = product.category;
            nameEntry.Focus();

        }
        async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameEntry.Text) || string.IsNullOrWhiteSpace(prixEntry.Text) || string.IsNullOrWhiteSpace(prixEntry.Text))
            {
                await DisplayAlert("Invalid", "Blank or WhiteSpace value is Invalid!", "OK");
            }
            else if (_product != null)
            {
                UpdateProduct();
            }
            else
                AddNewProduct();
        }

        async void UpdateProduct()
        {
            _product.Name = nameEntry.Text;
            _product.Prix = float.Parse(prixEntry.Text, CultureInfo.InvariantCulture.NumberFormat);
            _product.category = categoryEntry.Text;
            await App.MyDatabase.UpdateProduct(_product);
            await Navigation.PopAsync();
        }

        async void AddNewProduct()
        {
            await App.MyDatabase.CreateProduct(new Model.ProductModel
            {
                Name = nameEntry.Text,
                Prix = float.Parse(prixEntry.Text, CultureInfo.InvariantCulture.NumberFormat),
                category = categoryEntry.Text
        });
            await Navigation.PopAsync();
        }
    }
}