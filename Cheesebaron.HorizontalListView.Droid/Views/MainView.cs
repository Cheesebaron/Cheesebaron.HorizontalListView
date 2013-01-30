using Android.App;
using Cheesebaron.HorizontalListView.Core.ViewModels;
using Cirrious.MvvmCross.Binding.Android.Views;

namespace Cheesebaron.HorizontalListView.Droid.Views
{
    [Activity]
    public class MainView
        : MvxBindingActivityView<TestCollectionViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Main);

            var hlv = FindViewById<HorizontalListView>(Resource.Id.listView);
            //hlv.Snap = true;
        }
    }
}