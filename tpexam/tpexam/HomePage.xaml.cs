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

    public partial class HomePage : ContentPage
    {
        UserDB userData;
        public HomePage()
        {
            InitializeComponent();
            userData = new UserDB();
            NavigationPage.SetHasBackButton(this, false);
            userNameEntry.ReturnCommand = new Command(() => passwordEntry.Focus());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register());
        }

        private void LoginValidation_ButtonClicked(object sender, EventArgs e)
        {
            if (userNameEntry.Text != null && passwordEntry.Text != null)
            {
                var validData = userData.LoginValidate(userNameEntry.Text, passwordEntry.Text);
                if (validData)
                {
                    if(userNameEntry.Text =="admin")
                    {
                        App.isAdmin = 1;
                    }
                    else
                    {
                        App.isAdmin = 0;
                    }
                    Navigation.PushAsync(new dashboard());
                    NavigationPage.SetHasBackButton(this, false);

                }
                else
                {                
                   DisplayAlert("Login Failed", "Username or Password Incorrect", "OK");
                }
            }
            else
            {
                DisplayAlert("He He", "Enter User Name and Password Please", "OK");
            }
        }
    }
}