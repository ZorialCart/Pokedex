﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xama1.View;
using Xama1.View.Pokemon;

namespace Xama1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage( new MainMenu());
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
