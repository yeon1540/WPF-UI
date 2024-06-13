using CommunityToolkit.Mvvm.ComponentModel;
using CompanyProject.Views.Pages;
using PropertyChanged;
using System.Collections.ObjectModel;
using Wpf.Ui;
using Wpf.Ui.Controls;

namespace MainProject.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public partial class MainWindowViewModel : ObservableObject
    {
        private bool _isInitialized = false;

        public string ApplicationTitle { get; set; }
        public ObservableCollection<object> NavigationItems { get; set; }
        public ObservableCollection<object> NavigationFooter { get; set; }
        public ObservableCollection<MenuItem> TrayMenuItems { get; set; }

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
                Content = "Home",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
                TargetPageType = typeof(AutoScreen)
            }};

            NavigationFooter = new ObservableCollection<object>
{
            new NavigationViewItem
            {
                Content = "Settings",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                TargetPageType = typeof(AutoScreen)
            }};

            TrayMenuItems = new ObservableCollection<MenuItem>
            {
                new MenuItem { Header = "Home", Tag = "tray_home" }
            };

            _isInitialized = true;
        }
    }
}
