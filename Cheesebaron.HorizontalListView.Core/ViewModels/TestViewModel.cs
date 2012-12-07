using System;
using Cirrious.MvvmCross.ViewModels;

namespace Cheesebaron.HorizontalListView.Core.ViewModels
{
    public class TestViewModel : MvxNotifyPropertyChanged
    {
        private int _id;
        private string _testString;

        public int Id 
        { 
            get { return _id; } 
            set { 
                _id = value;
                FirePropertyChanged(() => Id);
            } 
        }
        public string TestString
        {
            get { return _testString; }
            set
            {
                _testString = value;
                FirePropertyChanged(() => TestString);
            }
        }

        public TestViewModel()
        {
            Id = new Random().Next();
            TestString = "Test " + Id;
        }
    }
}