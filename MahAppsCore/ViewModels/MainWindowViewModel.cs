using Prism.Events;
using Prism.Modularity;
using Prism.Mvvm;

namespace MahAppsCore.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "MahApps";
        private IEventAggregator _eventAggregator;
        private IModuleManager _moduleManager;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(
            IEventAggregator eventAggregator, 
            IModuleManager moduleManager)
        {
            _eventAggregator = eventAggregator;
            _moduleManager = moduleManager;
        }
    }
}
