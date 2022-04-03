using System.Linq;
using System.Windows.Controls;
using Prism.Regions;
using Syncfusion.Windows.Tools.Controls;

namespace Shell
{
    public class DockingManagerRegionAdapter : RegionAdapterBase<DockingManager>
    {
        public DockingManagerRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
        {
        }
        protected override void Adapt(IRegion region, DockingManager regionTarget)
        {
            region.Views.CollectionChanged += delegate
            {
                foreach (var child in region.Views.Cast<UserControl>())
                {
                    if (!regionTarget.Children.Contains(child))
                    {
                        regionTarget.BeginInit();
                        regionTarget.Children.Add(child);
                        regionTarget.EndInit();
                    }
                }
            };
        }
        protected override IRegion CreateRegion()
        {
            return new AllActiveRegion();
        }
        protected override void AttachBehaviors(IRegion region, DockingManager regionTarget)
        {
            base.AttachBehaviors(region, regionTarget);
            if (!region.Behaviors.ContainsKey(DocumentRegionActiveAwareBehavior.BehaviorKey))
                region.Behaviors.Add(DocumentRegionActiveAwareBehavior.BehaviorKey, new DocumentRegionActiveAwareBehavior { HostControl = regionTarget });
        }
    }
}
