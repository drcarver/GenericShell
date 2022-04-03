using System;
using System.Collections.ObjectModel;
using BearWare.Core.Mvvm;
using BearWare.Services.Interfaces;
using Prism.Regions;
using Syncfusion.Windows.Controls.Gantt;

namespace BearWare.MSProject.Module.ViewModels
{
    public class MSProjectViewModel : ViewModelBase
    {
        private string _headerName = "Gant Chart";

        public string HeaderName
        {
            get => _headerName;
            set => SetProperty(ref _headerName, value);
        }

        public MSProjectViewModel(IRegionManager IRegionManager, IMessageService messageService)
        {
            GetTasks();
        }

        public ObservableCollection<TaskDetails> TaskCollection { get; set; } = new ObservableCollection<TaskDetails>
        {
            new TaskDetails
            {
                TaskId = 1,
                TaskName = "Scope",
                StartDate = new DateTime(2011, 1, 3),
                FinishDate = new DateTime(2011, 1, 14),
                Progress = 40d
            }
        };

        private void GetTasks()
        {
            TaskCollection[0].Child.Add(
                new TaskDetails
                {
                    TaskId = 2,
                    TaskName = "Determine project office scope",
                    StartDate = new DateTime(2011, 1, 3),
                    FinishDate = new DateTime(2011, 1, 5),
                    Progress = 20d
                });

            TaskCollection[0].Child.Add(
                new TaskDetails
                {
                    TaskId = 3,
                    TaskName = "Justify project office via business model",
                    StartDate = new DateTime(2011, 1, 6),
                    FinishDate = new DateTime(2011, 1, 7),
                    Duration = new TimeSpan(1, 0, 0, 0),
                    Progress = 20d
                });

            TaskCollection[0].Child.Add(
                new TaskDetails
                {
                    TaskId = 4,
                    TaskName = "Secure executive sponsorship",
                    StartDate = new DateTime(2011, 1, 10),
                    FinishDate = new DateTime(2011, 1, 14),
                    Duration = new TimeSpan(1, 0, 0, 0),
                    Progress = 20d
                });

            TaskCollection[0].Child.Add(
                new TaskDetails
                {
                    TaskId = 5,
                    TaskName = "Secure complete",
                    StartDate = new DateTime(2011, 1, 14),
                    FinishDate = new DateTime(2011, 1, 14),
                    Duration = new TimeSpan(1, 0, 0, 0),
                    Progress = 20d
                });
        }
    }
}

