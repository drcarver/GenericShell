using Syncfusion.UI.Xaml.Kanban;
using System;
using System.Collections.ObjectModel;

namespace BearWare.Kanban.Module
{
    public class TaskDetails
    {
        public TaskDetails()
        {

            Tasks = new ObservableCollection<KanbanModel>
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
        public ObservableCollection<KanbanModel> Tasks { get; set; }
    }
}
