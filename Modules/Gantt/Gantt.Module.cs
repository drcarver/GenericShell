using Gantt.Module.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Gantt.Module
{
    public class GanttModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(Core.RegionNames.MainRegion, typeof(GanttView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<GanttView>(Core.RegionNames.MainRegion);
        }

        private readonly IRegionManager regionManager;
        public GanttModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void Initialize()
        {
        }
    }
}