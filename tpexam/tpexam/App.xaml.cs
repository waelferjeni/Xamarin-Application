﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
namespace tpexam
{
    public partial class App : Application
    {
        private static SQLiteHelper db;
        public static int isAdmin { get; set; }
        public static SQLiteHelper MyDatabase
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"MyStore.db3"));
                }
                return db;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
