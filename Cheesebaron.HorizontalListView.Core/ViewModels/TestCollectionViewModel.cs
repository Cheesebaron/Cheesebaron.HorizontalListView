using System.Collections.ObjectModel;
using Cirrious.MvvmCross.Commands;
using Cirrious.MvvmCross.Interfaces.Commands;
using Cirrious.MvvmCross.Platform.Diagnostics;
using Cirrious.MvvmCross.ViewModels;

namespace Cheesebaron.HorizontalListView.Core.ViewModels
{
    public class TestCollectionViewModel : MvxViewModel
    {
        public ObservableCollection<TestViewModel> TestViewModels { get; set; }
        public IMvxCommand DisplaySelectedItem
        {
            get
            {
                return new MvxRelayCommand<TestViewModel>(test => DisplayItem(test.Id, test.TestString));
            }
        }

        private void DisplayItem(int id, string text)
        {
            MvxTrace.TaggedTrace("TestCollectionViewModel", "I'm in your base testing {0} with string {1}", id, text);
        }

        public TestCollectionViewModel()
        {
            TestViewModels = new ObservableCollection<TestViewModel>
                                 {
                                     new TestViewModel(),
                                     new TestViewModel(),
                                     new TestViewModel(),
                                     new TestViewModel(),
                                     new TestViewModel(),
                                 };
        }
    }
}