using BearWare.Core.Mvvm;
using BearWare.Services.Interfaces;
using Prism.Regions;

namespace BearWare.Scheduling.Module.ViewModels
{
    public class SchedulerViewModel : ViewModelBase
    {
        private string _headerName = "Scheduler";

        public string HeaderName
        {
            get => _headerName;
            set => SetProperty(ref _headerName, value);
        }

        public SchedulerViewModel(IRegionManager IRegionManager, IMessageService messageService)
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
