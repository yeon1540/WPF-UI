using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CompanyProject.Config;
using PropertyChanged;
using System.Windows.Input;

namespace CompanyProject.ViewModels.Pages
{
    [AddINotifyPropertyChangedInterface]
    public partial class AutoScreenViewModel : ObservableObject
{
        public ICommand MyCommand { get; }
        private SqlManager _sql;

        public AutoScreenViewModel(SqlManager sql)
        {
            _sql = sql;

            //RelayCommand
            MyCommand = new RelayCommand(ExecuteMyCommand);
        }

        private void ExecuteMyCommand()
        {
            var value = _sql.Eqpinfo.GetAll();
        }
    }
}
