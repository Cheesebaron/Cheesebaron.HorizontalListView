using Cheesebaron.HorizontalListView.Core.ApplicationObjects;
using Cirrious.MvvmCross.Application;
using Cirrious.MvvmCross.ExtensionMethods;
using Cirrious.MvvmCross.Interfaces.ServiceProvider;
using Cirrious.MvvmCross.Interfaces.ViewModels;

namespace Cheesebaron.HorizontalListView.Core
{
    public class App
    : MvxApplication
    , IMvxServiceProducer<IMvxStartNavigation>
    {
        public App()
        {
            var startAppObject = new StartApplicationObject();
            this.RegisterServiceInstance(startAppObject);
        }
    }
}