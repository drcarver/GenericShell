using BearWare.Core.Mvvm;
using BearWare.Services.Interfaces;
using Prism.Regions;

namespace BearWare.SpreadSheet.Module.ViewModels
{
    public class ExcelViewModel : ViewModelBase
    {
        private string _headerName = "Excel SpreadSheet";
        public string HeaderName
        {
            get => _headerName;
            set => SetProperty(ref _headerName, value);
        }
        public ExcelViewModel(IRegionManager IRegionManager, IMessageService messageService)
        {
        }
    }
}
