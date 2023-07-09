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
    public partial class info : ContentPage
    {
        public info()
        {
            InitializeComponent();
        }
        private void Call(object sender, EventArgs e)
        {
            DependencyService.Get<IPhoneCall>().makeCall(ph.Text.ToString());
        }
    }
}