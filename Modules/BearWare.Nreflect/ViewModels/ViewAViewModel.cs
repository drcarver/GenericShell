using BearWare.Services.Interfaces;
using Prism.Mvvm;
using Prism.Regions;

namespace BearWare.Nreflect.Module.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewAViewModel(IRegionManager IRegionManager, IMessageService messageService )
        {
            Message = "View A from your Prism Module";
        }
    }
}
