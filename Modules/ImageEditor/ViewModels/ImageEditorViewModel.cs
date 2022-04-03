using Core.Mvvm;
using Prism.Regions;

namespace ImageEditor.Module.ViewModels
{
    public class ImageEditorViewModel : ViewModelBase
    {
        private string _headerName = "Image Viewer";
        public string HeaderName
        {
            get => _headerName;
            set => SetProperty(ref _headerName, value);
        }
        public ImageEditorViewModel(IRegionManager IRegionManager)
        {
        }
    }
}
