﻿using ON.MobileApp.Services;
using ON.MobileApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ON.MobileApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<DataStore>();
            MainPage = new AppShell();
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
