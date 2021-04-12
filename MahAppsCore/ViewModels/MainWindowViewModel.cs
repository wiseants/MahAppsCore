using Prism.Events;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;

namespace MahAppsCore.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "MahApps";
        private IEventAggregator _eventAggregator;
        private IModuleManager _moduleManager;
        private IContainerExtension _container;
        private IRegionManager _regionManager;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(
            IEventAggregator eventAggregator, 
            IModuleManager moduleManager, 
            IContainerExtension container, 
            IRegionManager regionManager)
        {
            _eventAggregator = eventAggregator;
            _moduleManager = moduleManager;
            _container = container;
            _regionManager = regionManager;
        }
    }
}
