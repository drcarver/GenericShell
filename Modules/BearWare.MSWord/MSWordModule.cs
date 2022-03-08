using BearWare.MSWord.Module.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace BearWare.MSWord.Module
{
    public class MSWordModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(Core.RegionNames.MainRegion, typeof(RichTextView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<RichTextView>(Core.RegionNames.MainRegion);
        }

        private readonly IRegionManager regionManager;
        public MSWordModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void Initialize()
        {
        }
    }
}