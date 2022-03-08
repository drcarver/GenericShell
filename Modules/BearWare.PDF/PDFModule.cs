using BearWare.PDF.Module.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace BearWare.PDF.Module
{
    [Module(ModuleName = "PDF.Module")]
    public class PDFModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(Core.RegionNames.MainRegion, typeof(PDFView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<PDFView>(Core.RegionNames.MainRegion);
        }

        private readonly IRegionManager regionManager;
        public PDFModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void Initialize()
        {
        }
    }
}