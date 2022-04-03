using System.Windows;
using Core.Interface;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Shell.Views;
using Syncfusion.Windows.Tools.Controls;

namespace Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
#if DEBUG
        private const string MODULEPATH = @".\";
#else
        private const string MODULEPATH = @"..\modules\";
#endif
        protected override Window CreateShell()
        {
            //iRegionManager.RequestNavigate(Core.RegionNames.MainRegion, nameof(PDFView));
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }
        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(DockingManager), Container.Resolve<DockingManagerRegionAdapter>());
        }
        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new DirectoryModuleCatalog() { ModulePath = MODULEPATH };
        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            //moduleCatalog.AddModule(typeof(ExcelModule));
            //moduleCatalog.AddModule(typeof(ImageEditorModule));
            //moduleCatalog.AddModule(typeof(KanbanModule));
            //moduleCatalog.AddModule(typeof(MSProjectModule));
            //moduleCatalog.AddModule(typeof(MSWordModule));
            //moduleCatalog.AddModule(typeof(PDFModule));
            //moduleCatalog.AddModule(typeof(SchedulingModule));
            //moduleCatalog.AddModule(typeof(SQLModule));
        }
    }
}
