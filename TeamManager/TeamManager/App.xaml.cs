using System.Windows;
using Prism.Ioc;
using TeamManager.Views;

namespace TeamManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            //창 생성
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //View 등록
            containerRegistry.RegisterForNavigation<HomeView>();
            containerRegistry.RegisterForNavigation<SettingView>();
            containerRegistry.RegisterForNavigation<ProductView>();
        }
    }
}
