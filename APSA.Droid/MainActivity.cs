﻿using Android.App;
using Android.Widget;
using Android.OS;
using APSA.Portable.AppStart;
using Android.Content.PM;
using Xamarin.Forms;

namespace APSA.Droid
{
    
    [Activity(Label = "APSA ICICI", 
        MainLauncher = true, 
        Theme = "@style/AppTheme.Dark", 
        Icon = "@drawable/ICICIIcon")]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Xamarin.Forms.Forms.Init(this, bundle);
            
            LoadApplication(new App());
            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            global::ZXing.Net.Mobile.Forms.Android.PermissionsHandler.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}

