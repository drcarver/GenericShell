using BearWare.MainMenuBar.Module.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace BearWare.MainMenuBar.Module
{
    [Module(ModuleName = "MainMenuBar.Module")]
    public class MainMenuBar : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(Core.RegionNames.MainRegion, typeof(MainMenuBarView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainMenuBarView>(Core.RegionNames.MainRegion);
        }
        private readonly IRegionManager regionManager;
        public MainMenuBar(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void Initialize()
        {
        }
    }
}