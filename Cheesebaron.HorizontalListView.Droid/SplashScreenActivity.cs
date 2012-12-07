using Android.App;
using Cirrious.MvvmCross.Android.Views;

namespace Cheesebaron.HorizontalListView.Droid
{
    [Activity(Label = "Horizontal ListView Demo", MainLauncher = true, NoHistory = true, Icon = "@drawable/icon")]
    public class SplashScreenActivity 
        : MvxBaseSplashScreenActivity 
    {
        public SplashScreenActivity()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}