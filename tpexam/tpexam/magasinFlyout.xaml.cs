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
    public partial class magasinFlyout : ContentPage
    {
        public ListView ListView;

        public magasinFlyout()
        {
            InitializeComponent();

            BindingContext = new magasinFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class magasinFlyoutViewModel : INotifyPropertyChanged
        {
            
            public ObservableCollection<magasinFlyoutMenuItem> MenuItems { get; set; }

            public magasinFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<magasinFlyoutMenuItem>(new[]
                {
                    new magasinFlyoutMenuItem { Id = 2, Title = "Home" ,Iconsource="home.png",TargetType=typeof(dashboard)},
                    new magasinFlyoutMenuItem { Id = 2, Title = "Products" ,Iconsource="all.png",TargetType=typeof(magasinDetail)},
                    new magasinFlyoutMenuItem { Id = 0, Title = "Magazines",Iconsource="magazine.png",TargetType=typeof(mg)},
                    new magasinFlyoutMenuItem { Id = 1, Title = "clothing",Iconsource="clothing.jfif",TargetType=typeof(clthn)},
                    new magasinFlyoutMenuItem { Id = 2, Title = "Food" ,Iconsource="food.png",TargetType=typeof(fd)},
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