using Prism.Mvvm;
using Prism.Regions;

namespace Shell.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Generic Shell";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public MainWindowViewModel(IRegionManager iRegionManager)
        {
        }
    }
}
