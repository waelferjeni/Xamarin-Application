using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tpexam
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class admindbFlyout : ContentPage
    {
        public ListView ListView;

        public admindbFlyout()
        {
            InitializeComponent();

            BindingContext = new admindbFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class admindbFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<admindbFlyoutMenuItem> MenuItems { get; set; }

            public admindbFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<admindbFlyoutMenuItem>(new[]
                {
                    new admindbFlyoutMenuItem { Id = 2, Title = "Home" ,Iconsource="home.png",TargetType=typeof(dashboard)},
                    new admindbFlyoutMenuItem { Id = 2, Title = "Products" ,Iconsource="all.png",TargetType=typeof(magasinDetail) },
                    new admindbFlyoutMenuItem { Id = 0, Title = "Magazines",Iconsource="magazine.png",TargetType=typeof(Magazines) },
                    new admindbFlyoutMenuItem { Id = 1, Title = "clothing",Iconsource="clothing.jfif",TargetType=typeof(clothing) },
                    new admindbFlyoutMenuItem { Id = 2, Title = "Food" ,Iconsource="food.png",TargetType=typeof(Food) },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}