using Cheesebaron.HorizontalListView.Core.ViewModels;
using Cirrious.MvvmCross.Interfaces.ViewModels;
using Cirrious.MvvmCross.ViewModels;

namespace Cheesebaron.HorizontalListView.Core.ApplicationObjects
{
    public class StartApplicationObject
        : MvxApplicationObject
        , IMvxStartNavigation
    {
        public void Start()
        {
            RequestNavigate<TestCollectionViewModel>();
        }

        public bool ApplicationCanOpenBookmarks { get { return true; } }
    }
}