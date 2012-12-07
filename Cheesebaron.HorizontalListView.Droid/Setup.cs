using Android.Content;
using Cheesebaron.HorizontalListView.Core;
using Cirrious.MvvmCross.Application;
using Cirrious.MvvmCross.Binding.Android;

namespace Cheesebaron.HorizontalListView.Droid
{
    public class Setup
        : MvxBaseAndroidBindingSetup
    {
        public Setup(Context applicationContext)
            : base(applicationContext)
        {
        }

        protected override MvxApplication CreateApp()
        {
            return new App();
        }

    }
}