using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Auth.Module
{
    [Module(ModuleName = "Auth.Module")]
    public class AuthModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            //regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(RichTextView));
            //regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(PDFView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<RichTextView>(RegionNames.MainRegion);
            //containerRegistry.RegisterForNavigation<PDFView>(RegionNames.MainRegion);
        }

        private readonly IRegionManager regionManager;
        public AuthModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
    }
}