using Android.Content;
using System.Collections.Generic;
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

        protected override IDictionary<string, string> ViewNamespaceAbbreviations
        {
            get
            {
                var abbreviations = base.ViewNamespaceAbbreviations;
                abbreviations["chsb"] = "cheesebaron.horizontallistview.droid.bindings";
                return abbreviations;
            }
        }
    }
}