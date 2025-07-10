using Manager.Models;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace Manager.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public ObservableCollection<MenuItem> MenuItems { get; set; }

        public MainViewModel()
        {
            MenuItems = new ObservableCollection<MenuItem>
            {
                new MenuItem { Icon = "https://cdn-icons-png.flaticon.com/512/1828/1828859.png", Text = "MENU", Command = new DelegateCommand(OnMenuClicked)},
                new MenuItem { Icon = "https://cdn-icons-png.flaticon.com/512/622/622669.png", Text = "SEARCH", Command = new DelegateCommand(OnSearcgClicked) },
                new MenuItem { Icon = "https://cdn-icons-png.flaticon.com/512/1828/1828817.png", Text = "ADD PRODUCT", Command = new DelegateCommand(OnAddProductClicked) },
                new MenuItem { Icon = "https://cdn-icons-png.flaticon.com/512/2099/2099058.png", Text = "SETTINGS", Command = new DelegateCommand(OnSettingClicked) },
                new MenuItem { Icon = "https://cdn-icons-png.flaticon.com/512/1828/1828490.png", Text = "EXIT", Command = new DelegateCommand(OnExitClicked) }
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
        }
    }
}
