#region Copyright Syncfusion Inc. 2001-2021
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using BearWare.SpreadSheet.Module.Views;
using Syncfusion.UI.Xaml.CellGrid.Helpers;
using Syncfusion.UI.Xaml.Spreadsheet.Helpers;

namespace BearWare.SpreadSheet.Module.Behaviors
{
    class ExcelViewImportBehavior : FileImportBehavior
    {
        private ExcelView ExcelView;
        protected override void OnAttached()
        {
            base.OnAttached();
            this.AssociatedObject.WorkbookLoaded += AssociatedObject_WorkbookLoaded;
            this.AssociatedObject.WorksheetAdded += AssociatedObject_WorksheetAdded;
            this.AssociatedObject.WorksheetRemoving += AssociatedObject_WorksheetRemoving;
            this.AssociatedObject.WorkbookUnloaded += AssociatedObject_WorkbookUnloaded;
            this.AssociatedObject.ZoomFactorChanged += AssociatedObject_ZoomFactorChanged;
        }

        void AssociatedObject_ZoomFactorChanged(object sender, ZoomFactorChangedEventArgs args)
        {
            if (ExcelView != null)
                ExcelView.ZoomSlider.Value = args.ZoomFactor;
        }

        void AssociatedObject_WorkbookUnloaded(object sender, WorkbookUnloadedEventArgs args)
        {
            foreach (var grid in args.GridCollection)
            {
                grid.CurrentCellBeginEdit -= grid_CurrentCellBeginEdit;
                grid.CurrentCellEndEdit -= grid_CurrentCellEndEdit;
            }
        }

        void AssociatedObject_WorksheetRemoving(object sender, WorksheetRemovingEventArgs args)
        {
            var grid = this.AssociatedObject.GridCollection[args.SheetName];
            if (grid != null)
            {
                grid.CurrentCellBeginEdit -= grid_CurrentCellBeginEdit;
                grid.CurrentCellEndEdit -= grid_CurrentCellEndEdit;
            }
        }

        void AssociatedObject_WorksheetAdded(object sender, WorksheetAddedEventArgs args)
        {
            var grid = this.AssociatedObject.GridCollection[args.SheetName];
            if (grid != null)
            {
                grid.CurrentCellBeginEdit += grid_CurrentCellBeginEdit;
                grid.CurrentCellEndEdit += grid_CurrentCellEndEdit;
            }
        }

        void AssociatedObject_WorkbookLoaded(object sender, WorkbookLoadedEventArgs args)
        {
            foreach (var grid in args.GridCollection)
            {
                grid.CurrentCellBeginEdit += grid_CurrentCellBeginEdit;
                grid.CurrentCellEndEdit += grid_CurrentCellEndEdit;
            }
        }

        void grid_CurrentCellEndEdit(object sender, CurrentCellEndEditEventArgs args)
        {
            if (ExcelView == null) return;
            ExcelView.ZoomSlider.IsEnabled = true;
            ExcelView.ZoomIncreaseButton.IsEnabled = true;
            ExcelView.ZoomDecreaseButton.IsEnabled = true;
            ExcelView.ZoomTextBlock.IsEnabled = true;
            ExcelView.ModeTextBlock.Text = "READY";
        }

        void grid_CurrentCellBeginEdit(object sender, CurrentCellBeginEditEventArgs args)
        {
            if (ExcelView == null) return;
            ExcelView.ZoomSlider.IsEnabled = false;
            ExcelView.ZoomIncreaseButton.IsEnabled = false;
            ExcelView.ZoomDecreaseButton.IsEnabled = false;
            ExcelView.ZoomTextBlock.IsEnabled = false;
            ExcelView.ModeTextBlock.Text = "ENTER";
        } 

        protected override void OnDetaching()
        {
            ExcelView = null;
            this.AssociatedObject.WorkbookLoaded -= AssociatedObject_WorkbookLoaded;
            this.AssociatedObject.WorksheetAdded -= AssociatedObject_WorksheetAdded;
            this.AssociatedObject.WorksheetRemoving -= AssociatedObject_WorksheetRemoving;
            this.AssociatedObject.WorkbookUnloaded -= AssociatedObject_WorkbookUnloaded;
            this.AssociatedObject.ZoomFactorChanged -= AssociatedObject_ZoomFactorChanged;
        }
    }
}
