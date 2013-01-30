using System.Collections.ObjectModel;
using System.Windows.Input;
using Cirrious.MvvmCross.Commands;
using Cirrious.MvvmCross.Platform.Diagnostics;
using Cirrious.MvvmCross.ViewModels;

namespace Cheesebaron.HorizontalListView.Core.ViewModels
{
    public class TestCollectionViewModel : MvxViewModel
    {
        public ObservableCollection<TestViewModel> TestViewModels { get; set; }
        public ICommand DisplaySelectedItem
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

        public ICommand ScreenChanged
        {
            get
            {
                return new MvxRelayCommand<object>(DiplayScreenChanged);
            }
        }

        private void DiplayScreenChanged(object it)
        {
            //MvxTrace.TaggedTrace("TestCollectionViewModel", "I'm changing the screen! {0}", it);
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