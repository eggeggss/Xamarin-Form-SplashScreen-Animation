using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading;

namespace splashScreen.Droid
{
    [Activity(Label = "splashScreen", MainLauncher = true, Theme ="@style/Theme.Splash", Icon = "@drawable/icon",
             NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        { 
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.splashLayout);

            StartActivity(typeof(MainActivity));
           
        }
        
    }
}