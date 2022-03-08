using System;
using System.Collections.ObjectModel;
using BearWare.Core.Mvvm;
using BearWare.Services.Interfaces;
using Prism.Regions;
using Syncfusion.UI.Xaml.Kanban;

namespace BearWare.Kanban.Module.ViewModels
{
    public class KanbanViewModel : ViewModelBase
    {
        private string _headerName = "Kanban Board";

        public string HeaderName
        {
            get => _headerName;
            set => SetProperty(ref _headerName, value);
        }

        public KanbanViewModel(IRegionManager IRegionManager, IMessageService messageService)
        {
        }

        public ObservableCollection<KanbanModel> Tasks { get; set; } = new ObservableCollection<KanbanModel>
        {
            new KanbanModel()
            {

                Title = "Universal App",

                ID = "27654",

                Description = "Incorporate feedback into functional specifications",

                Category = "Open",

                ColorKey = "Low",

                Tags = new string[] { "Deployment" },

                ImageURL = new Uri("/images/icon.jpg", UriKind.RelativeOrAbsolute)
            },
            new KanbanModel()
            {

                Title = "Universal App",

                ID = "29477",

                Description = "Design functional specifications",

                Category = "In Progress",

                ColorKey = "Normal",

                Tags = new string[] { "Design" },

                ImageURL = new Uri("/images/icon.jpg", UriKind.RelativeOrAbsolute)
            },
            new KanbanModel()
            {
                Title = "Universal App",

                ID = "25678",

                Description = "Review preliminary software specifications",

                Category = "Done",

                ColorKey = "Low",

                Tags = new string[] { "Analysis" },

                ImageURL = new Uri("/images/icon.jpg", UriKind.RelativeOrAbsolute)
            },
            new KanbanModel()
            {
                Title = "Universal App",

                ID = "6593",

                Description = "Draft preliminary software specifications",

                Category = "Review",

                ColorKey = "High",

                Tags = new string[] { "Analysis" },

                ImageURL = new Uri("/images/icon.jpg", UriKind.RelativeOrAbsolute)

            }
        };
    }
} 
