using Core.Interface;
using Core.Mvvm;
using Prism.Regions;

namespace Document.Module.ViewModels
{
    public class PDFViewModel : ViewModelBase
    {
        private string _headerName = "PDF Viewer";

        public string HeaderName
        {
            get => _headerName;
            set => SetProperty(ref _headerName, value);
        }

        public PDFViewModel(IRegionManager IRegionManager, IMessageService messageService )
        {
        }
        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
        }

        public override bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
    }
}
