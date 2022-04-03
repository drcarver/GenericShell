using BearWare.Scheduling.Module.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace BearWare.Scheduling.Module
{
    [Module(ModuleName = "Scheduling.Module")]
    public class SchedulingModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(Core.RegionNames.MainRegion, typeof(SchedulerView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<SchedulerView>(Core.RegionNames.MainRegion);
        }

        private readonly IRegionManager regionManager;
        public SchedulingModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void Initialize()
        {
        }
    }
}