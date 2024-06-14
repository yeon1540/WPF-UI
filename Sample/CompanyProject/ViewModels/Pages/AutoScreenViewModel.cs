using Comm.sqlite.Interfaces;
using Comm.sqlite.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PropertyChanged;
using System.Windows.Input;

namespace CompanyProject.ViewModels.Pages
{
    [AddINotifyPropertyChangedInterface]
    public partial class AutoScreenViewModel : ObservableObject
    {
        private readonly IDataBase<Info> _dataBase;

        public ICommand MyCommand { get; }

        public AutoScreenViewModel(IDataBase<Info> dataBase)
        {
            this._dataBase = dataBase;

            // RelayCommand 초기화 및 명령 실행 메서드 지정
            MyCommand = new RelayCommand(ExecuteMyCommand);
        }

        private void ExecuteMyCommand()
        {
            _dataBase.Insert("길동이", "1234");
        }
    }
}
