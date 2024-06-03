using System;
using System.Collections.ObjectModel;
using Wpf.Ui;
using Wpf.Ui.Controls;

namespace Defalut.ViewModels
{
    public partial class MainWindowViewModel
    {
        private bool _isInitialized = false;
        
        private string _applicationTitle;

        public string ApplicationTitle
        {
            get => _applicationTitle;
            set => SetProperty(ref _applicationTitle, value);
        }

        private void SetProperty(ref string applicationTitle, string value)
        {
            throw new NotImplementedException();
        }

        private ObservableCollection<object> _navigationItems = new ObservableCollection<object>();

        public ObservableCollection<object> NavigationItems
        {
            get => _navigationItems;
            set => SetProperty(ref _navigationItems, value);
        }

        private ObservableCollection<object> _navigationFooter = new ObservableCollection<object>();

        public ObservableCollection<object> NavigationFooter
        {
            get => _navigationFooter;
            set => SetProperty(ref _navigationFooter, value);
        }

        private ObservableCollection<MenuItem> _trayMenuItems = new ObservableCollection<MenuItem>();

        public ObservableCollection<MenuItem> TrayMenuItems
        {
            get => _trayMenuItems;
            set => SetProperty(ref _trayMenuItems, value);
        }

        private void SetProperty(ref ObservableCollection<MenuItem> trayMenuItems, ObservableCollection<MenuItem> value)
        {
            throw new NotImplementedException();
        }

        private void SetProperty(ref ObservableCollection<object> navigationItems, ObservableCollection<object> value)
        {
            throw new NotImplementedException();
        }

        public MainWindowViewModel(INavigationService navigationService)
        {
            if (!_isInitialized)
            {
                InitializeViewModel();
            }
        }

        private void InitializeViewModel()
        {
            ApplicationTitle = "WPF UI";

            NavigationItems = new ObservableCollection<object>
{
            new NavigationViewItem
            {
                //Content = "Home",
                //Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
                //TargetPageType = typeof(AutoScreen)
            }};

            NavigationFooter = new ObservableCollection<object>
{
            new NavigationViewItem
            {
                //Content = "Settings",
                //Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                //TargetPageType = typeof(AutoScreen)
            }};

            TrayMenuItems = new ObservableCollection<MenuItem>
            {
                new MenuItem { Header = "Home", Tag = "tray_home" }
            };

            _isInitialized = true;
        }
    }
}
