using BearWare.Core.Mvvm;
using BearWare.Services.Interfaces;
using Prism.Mvvm;
using Prism.Regions;

namespace BearWare.SQL.Module.ViewModels
{
    public class SQLViewModel : ViewModelBase
    {
        private string _headerName = "SQL";
        public string HeaderName
        {
            get => _headerName;
            set => SetProperty(ref _headerName, value);
        }
        public SQLViewModel(IRegionManager IRegionManager, IMessageService messageService)
        {
        }
    }
}
