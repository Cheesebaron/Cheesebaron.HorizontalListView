using System;
using Cirrious.MvvmCross.ViewModels;

namespace Cheesebaron.HorizontalListView.Core.ViewModels
{
    public class TestViewModel : MvxNotifyPropertyChanged
    {
        private int _id;
        private string _testString;
        private string _photoUrl;

        public int Id 
        { 
            get { return _id; } 
            set { 
                _id = value;
                RaisePropertyChanged(() => Id);
            } 
        }
        public string TestString
        {
            get { return _testString; }
            set
            {
                _testString = value;
                RaisePropertyChanged(() => TestString);
            }
        }

        public string PhotoUrl
        {
            get { return _photoUrl; }
            set
            {
                _photoUrl = value;
                RaisePropertyChanged(() => PhotoUrl);
            }
        }

        public TestViewModel()
        {
            Id = new Random().Next();
            TestString = "Test " + Id;
            PhotoUrl = "http://bknsrefeu.blob.core.windows.net/nsref1-d35a8f26-5828-4655-9ce4-69a655ac70cd-publicweb/LocationImage150-d1c0ee55-3072-43e2-8cd5-497c517507f9-4.jpg";
        }
    }
}