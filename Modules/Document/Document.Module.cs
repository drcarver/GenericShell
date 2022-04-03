using Core;
using Document.Module.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Document.Module
{
    [Module(ModuleName = "Document.Module")]
    public class DocumentModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(RichTextView));
            regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(PDFView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<RichTextView>(RegionNames.MainRegion);
            containerRegistry.RegisterForNavigation<PDFView>(RegionNames.MainRegion);

        }

        private readonly IRegionManager regionManager;
        public DocumentModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
    }
}