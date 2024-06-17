using CompanyProject.ViewModels.Pages;
using System.Windows.Controls;

namespace CompanyProject.Views.Pages
{
    public partial class AutoScreen : Page
    {
        public AutoScreenViewModel ViewModel { get; }

        public AutoScreen(AutoScreenViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
