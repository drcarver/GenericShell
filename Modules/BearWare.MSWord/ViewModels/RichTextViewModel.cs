using BearWare.Core.Mvvm;
using BearWare.Services.Interfaces;
using Prism.Regions;

namespace BearWare.MSWord.Module.ViewModels
{
    public class RichTextViewModel : ViewModelBase
    {
        private string _headerName = "Word Document";

        public string HeaderName
        {
            get => _headerName;
            set => SetProperty(ref _headerName, value);
        }

        public RichTextViewModel(IRegionManager IRegionManager, IMessageService messageService)
        {
        }
    }
}
