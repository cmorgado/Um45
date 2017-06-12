using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight.Ioc;
using Um45.Interfaces;
using Um45.ViewModels;
using Um45.Views;
using Xamarin.Forms;

namespace Um45
{
    public partial class App : Application
    {
        private static ViewModelLocator _locator;
        public static ViewModelLocator Locator => _locator ?? (_locator = new ViewModelLocator());

        public static Page Page { get; private set; }
        public App()
        {
            InitializeComponent();

            if (!SimpleIoc.Default.IsRegistered<INavigationService>())
                SimpleIoc.Default.Register<INavigationService>(() => new Um45.Services.UberNavigation());

            if (!SimpleIoc.Default.IsRegistered<IUiHelper>())
                SimpleIoc.Default.Register<IUiHelper>(() => new Um45.Services.UiHelper());

            if (!SimpleIoc.Default.IsRegistered<IConnectivityService>())
                SimpleIoc.Default.Register<IConnectivityService>(() => new Um45.Services.ConnectivityService());

            MainPage = new MainPage();
            Page = MainPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
