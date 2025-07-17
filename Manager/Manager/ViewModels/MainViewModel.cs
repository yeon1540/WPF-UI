using Manager.Models;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Windows;

namespace Manager.ViewModels
{
    public class MainViewModel : BindableBase
    {
        #region Nivagation Bar

        public ObservableCollection<NaviItems> NaviItems { get; set; }

        public MainViewModel()
        {
            NaviItems = new ObservableCollection<NaviItems>
            {
                new NaviItems { Icon = "https://cdn-icons-png.flaticon.com/512/1828/1828859.png", Text = "MENU", Command = new DelegateCommand(OnMenuClicked)},
                new NaviItems { Icon = "https://cdn-icons-png.flaticon.com/512/622/622669.png", Text = "SEARCH", Command = new DelegateCommand(OnSearcgClicked) },
                new NaviItems { Icon = "https://cdn-icons-png.flaticon.com/512/1828/1828817.png", Text = "ADD PRODUCT", Command = new DelegateCommand(OnAddProductClicked) },
                new NaviItems { Icon = "https://cdn-icons-png.flaticon.com/512/2099/2099058.png", Text = "SETTINGS", Command = new DelegateCommand(OnSettingClicked) },
                new NaviItems { Icon = "https://cdn-icons-png.flaticon.com/512/1828/1828490.png", Text = "EXIT", Command = new DelegateCommand(OnExitClicked) }
            };
        }

        private void OnMenuClicked()
        {
        }

        private void OnSearcgClicked()
        {
        }

        private void OnAddProductClicked()
        {
        }

        private void OnSettingClicked()
        {
        }

        private void OnExitClicked()
        {
            Application.Current.Shutdown();
        }

        #endregion
    }
}
