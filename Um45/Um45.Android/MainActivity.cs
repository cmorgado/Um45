﻿using Android.App;
using Android.Content.PM;
using Android.OS;

namespace Um45.Droid
{
    [Activity(Label = "Um45", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            Code.RegisterServices.Init();
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new Um45.App());
        }
    }
}

