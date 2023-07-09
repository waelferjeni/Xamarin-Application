using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tpexam.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneCall))]
namespace tpexam.Droid
{
    public class PhoneCall : IPhoneCall
    {
        [Obsolete]
        public void makeCall(string phonenumber)
        {
            
            try
            {
                var URI = Android.Net.Uri.Parse(string.Format("tel:{0}", phonenumber));
                var intent = new Intent(Intent.ActionCall, URI);
                Xamarin.Forms.Forms.Context.StartActivity(intent);
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
            }
        }
    }
}