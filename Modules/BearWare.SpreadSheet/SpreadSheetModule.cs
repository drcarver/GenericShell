﻿using BearWare.SpreadSheet.Module.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace BearWare.SpreadSheet.Module
{
    public class ExcelModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(Core.RegionNames.MainRegion, typeof(ExcelView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ExcelView>(Core.RegionNames.MainRegion);
        }

        private readonly IRegionManager regionManager;
        public ExcelModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void Initialize()
        {
        }
    }
}