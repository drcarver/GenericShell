using Prism.Mvvm;
using Prism.Navigation;
using Prism.Regions;

namespace Core.Mvvm
{
    public abstract class ViewModelBase : BindableBase, IDestructible, INavigationAware
    {
        protected ViewModelBase()
        {

        }

        public virtual void Destroy()
        {

        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
        }

        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
    }
}
