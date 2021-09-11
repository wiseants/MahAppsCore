using Prism.Commands;
using Prism.Events;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MahAppsCore.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title;
        private IEventAggregator _eventAggregator;
        private IModuleManager _moduleManager;
        private IContainerExtension _container;
        private IRegionManager _regionManager;
        ObservableCollection<BitMaskInfo> _bitMasks;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ObservableCollection<BitMaskInfo> BitMasks
        {
            get { return _bitMasks; }
            set { SetProperty(ref _bitMasks, value); }
        }

        public DelegateCommand BindingCommand { get; private set; }

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

            BitMasks = new ObservableCollection<BitMaskInfo>()
            {
                new BitMaskInfo() { Key="A", IsEnable = true },
                new BitMaskInfo() { Key="B", IsEnable = false },
            };

            BindingCommand = new DelegateCommand(() =>
            {
                Title = "Command";
            });

            Title = "Init";
        }
    }
}
