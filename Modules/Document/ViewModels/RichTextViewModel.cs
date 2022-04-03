using Core.Mvvm;
using Prism.Regions;

namespace Document.Module.ViewModels
{
    public class RichTextViewModel : ViewModelBase
    {
        private string _headerName = "Word Document";

        public string HeaderName
        {
            get => _headerName;
            set => SetProperty(ref _headerName, value);
        }

        public RichTextViewModel(IRegionManager IRegionManager)
        {
        }
    }
}
