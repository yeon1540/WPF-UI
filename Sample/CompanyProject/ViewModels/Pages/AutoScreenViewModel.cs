using Comm.sqlite.Interfaces;
using Comm.sqlite.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CompanyProject.ViewModels.Pages
{
    public partial class AutoScreenViewModel : ObservableObject
    {
        private readonly IDataBase<Info> dataBase;

        public AutoScreenViewModel(IDataBase<Info> dataBase)
        {
            this.dataBase = dataBase;
        }
    }
}
