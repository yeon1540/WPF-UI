using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation.Regions;
using System.Collections.ObjectModel;
using System.Windows;
using TeamManager.Models;

namespace TeamManager.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
            NaviBarDrawing();
        }

        #region Title

        private string _title = "TEAM MANAGER";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        #endregion

        #region Navigation Bar

        public ObservableCollection<MenuItems> MenuItems { get; set; }

        private void NaviBarDrawing()
        {
            MenuItems = new ObservableCollection<MenuItems>
            {
                new MenuItems { Icon = "https://cdn-icons-png.flaticon.com/512/1828/1828859.png", Text = "HOME", Command = new DelegateCommand(() => NavigateTo("HOME"))},
                new MenuItems { Icon = "https://cdn-icons-png.flaticon.com/512/1828/1828817.png", Text = "PRODUCT", Command = new DelegateCommand(() => NavigateTo("PRODUCT"))},
                new MenuItems { Icon = "https://cdn-icons-png.flaticon.com/512/2099/2099058.png", Text = "SETTING", Command = new DelegateCommand(() => NavigateTo("SETTING"))},
                new MenuItems { Icon = "https://cdn-icons-png.flaticon.com/512/1828/1828490.png", Text = "EXIT", Command = new DelegateCommand(() => NavigateTo("EXIT"))}
            };
        }

        private void NavigateTo(string btn_Name)
        {
            switch (btn_Name)
            {
                case "HOME":
                    _regionManager.RequestNavigate("ContentRegion", "HomeView");
                    break;

                case "PRODUCT":
                    _regionManager.RequestNavigate("ContentRegion", "ProductView");
                    break;

                case "SETTING":
                    _regionManager.RequestNavigate("ContentRegion", "SettingView");
                    break;

                default:
                    MessageBoxResult msg = MessageBox.Show("Do you want to exit?", "Info", MessageBoxButton.YesNo);
                    if (msg == MessageBoxResult.Yes) Application.Current.Shutdown();
                    break;
            }
        }

        #endregion
    }
}
