using CustomControls;
using HotelApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace HotelApp
{
    partial class HotelAppForm
    {

        #region Initialization

        private void InitHouseKeepingPage()
        {
            #region HouseKeeping

            this.houseKeepingNavigationPanel.BackgroundImage = Properties.Resources.fasha_no_borders;
            this.houseKeepingNavigationPanel.BackgroundImageLayout = ImageLayout.Stretch;
            this.houseKeepingNavigationPanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            this.houseKeepingNavigationPanel.PanelElement.Visibility = ElementVisibility.Collapsed;

            this.houseKeepingSchedulerHeaderLabel.TextAlignment = ContentAlignment.MiddleCenter;
            this.houseKeepingSchedulerHeaderLabel.ForeColor = Color.White;
            this.houseKeepingSchedulerHeaderLabel.LabelElement.LabelFill.GradientStyle = GradientStyles.Solid;
            this.houseKeepingSchedulerHeaderLabel.LabelElement.CustomFont = Utils.MainFont;
            this.houseKeepingSchedulerHeaderLabel.LabelElement.CustomFontSize = 15;

            this.notAssignedLabel.LabelElement.LabelFill.GradientStyle = GradientStyles.Solid;
            this.notAssignedLabel.TextAlignment = ContentAlignment.MiddleCenter;
            this.notAssignedLabel.ForeColor = Color.White;
            this.notAssignedLabel.LabelElement.CustomFont = Utils.MainFont;
            this.notAssignedLabel.LabelElement.CustomFontSize = 15;
            this.notAssignedGridView.DataSource = this.Rooms.Where<Room>(r => r.HouseKeeperId == null && r.HouseKeepingStatus != HouseKeepingStatus.Clean);
            foreach (GridViewColumn col in this.notAssignedGridView.Columns)
            {
                if (col.Name != "Id" && col.Name != "HouseKeepingStatus" && col.Name != "Priority")
                {
                    col.IsVisible = false;
                }
            }
            this.notAssignedGridView.Columns["Id"].TextAlignment = ContentAlignment.MiddleLeft;
            this.notAssignedGridView.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.notAssignedGridView.EnableGrouping = false;
            this.notAssignedGridView.AllowAddNewRow = false;
            this.notAssignedGridView.EnableFiltering = false;
            this.notAssignedGridView.MasterView.TableHeaderRow.Height = 30;
            this.notAssignedGridView.ReadOnly = true;
            this.notAssignedGridView.TableElement.DrawBorder = true;
            this.notAssignedGridView.TableElement.BorderGradientStyle = GradientStyles.Solid;
            this.notAssignedGridView.TableElement.BorderColor = Color.FromArgb(209, 209, 209);

            this.houseKeepingNavigationPanel.RootElement.EnableElementShadow = false;
            this.houseKeepingListView.RootElement.EnableElementShadow = false;
            this.houseKeepingScheduler.RootElement.EnableElementShadow = false;
            this.notAssignedGridView.RootElement.EnableElementShadow = false;
            this.notAssignedLabel.RootElement.EnableElementShadow = false;
            this.notAssignedGridView.AllowSearchRow = true;
            SortDescriptor sortDescriptor = new SortDescriptor();
            sortDescriptor.PropertyName = "Priority";
            sortDescriptor.Direction = ListSortDirection.Descending;
            this.notAssignedGridView.SortDescriptors.Add(sortDescriptor);

            BaseGridBehavior gridBehavior = this.notAssignedGridView.GridBehavior as BaseGridBehavior;
            gridBehavior.UnregisterBehavior(typeof(GridViewDataRowInfo));
            gridBehavior.RegisterBehavior(typeof(GridViewDataRowInfo), new CustomGridDataRowBehavior());

            RadDragDropService service = this.notAssignedGridView.GridViewElement.GetDragDropService();
            service.PreviewDragStart += service_PreviewDragStart;
            service.PreviewDragOver += service_PreviewDragOver;
            service.PreviewDragDrop += service_PreviewDragDrop;

            this.houseKeepingScheduler.AppointmentTitleFormat = "{2}";

            SchedulerBindingDataSource houseKeepingScheduleSource = new SchedulerBindingDataSource();
            AppointmentMappingInfo houseKeepingAppointmentMappingInfo = new AppointmentMappingInfo();
            houseKeepingAppointmentMappingInfo.Summary = "Name";
            houseKeepingAppointmentMappingInfo.ResourceId = "HouseKeeperId";
            houseKeepingAppointmentMappingInfo.Start = "HouseKeepingStart";
            houseKeepingAppointmentMappingInfo.End = "HouseKeepingEnd";
            houseKeepingAppointmentMappingInfo.StatusId = "HouseKeepingStatus";
            houseKeepingAppointmentMappingInfo.BackgroundId = "Priority";
            houseKeepingAppointmentMappingInfo.Visible = "Visible";

            houseKeepingAppointmentMappingInfo.FindBySchedulerProperty("ResourceId").ConvertToScheduler = ConvertTo;
            houseKeepingAppointmentMappingInfo.FindBySchedulerProperty("ResourceId").ConvertToDataSource = ConvertFrom;
            houseKeepingScheduleSource.EventProvider.Mapping = houseKeepingAppointmentMappingInfo;
            houseKeepingScheduleSource.EventProvider.DataSource = this.Rooms;
            ResourceMappingInfo houseKeepingResourceMappingInfo = new ResourceMappingInfo();
            houseKeepingResourceMappingInfo.Id = "Id";
            houseKeepingResourceMappingInfo.Name = "Name";
            houseKeepingResourceMappingInfo.Image = "Photo";
            BindingList<HouseKeeper> houseKeepersCopy = new BindingList<HouseKeeper>();
            foreach (HouseKeeper hk in this.HouseKeepers)
            {
                houseKeepersCopy.Add(new HouseKeeper(hk.Id, hk.Name, hk.Photo));
            }
            houseKeepingScheduleSource.ResourceProvider.Mapping = houseKeepingResourceMappingInfo;
            houseKeepingScheduleSource.ResourceProvider.DataSource = houseKeepersCopy;
            this.houseKeepingScheduler.DataSource = houseKeepingScheduleSource;
            foreach (Resource r in this.houseKeepingScheduler.Resources)
            {
                r.Color = Color.White;
            }

            AppointmentStatusInfo.DefaultStatusId = -1;
            this.houseKeepingScheduler.Statuses.Clear();
            this.houseKeepingScheduler.Statuses.Add(new AppointmentStatusInfo(1, "Clean", Color.Green, Color.Transparent, AppointmentStatusFillType.Solid));
            this.houseKeepingScheduler.Statuses.Add(new AppointmentStatusInfo(2, "NotClean", Color.Red, Color.Transparent, AppointmentStatusFillType.Solid));
            this.houseKeepingScheduler.Statuses.Add(new AppointmentStatusInfo(3, "InProgress", Color.Yellow, Color.Transparent, AppointmentStatusFillType.Solid));

            this.houseKeepingScheduler.Backgrounds.Clear();

            AppointmentBackgroundInfo lowBackgroundInfo = new AppointmentBackgroundInfo(1, "Low", Color.Wheat, Color.Wheat);
            lowBackgroundInfo.ShadowWidth = 0;
            this.houseKeepingScheduler.Backgrounds.Add(lowBackgroundInfo);

            AppointmentBackgroundInfo mediumBackgroundInfo = new AppointmentBackgroundInfo(2, "Medium", Color.Salmon, Color.Salmon);
            mediumBackgroundInfo.ShadowWidth = 0;
            this.houseKeepingScheduler.Backgrounds.Add(mediumBackgroundInfo);

            AppointmentBackgroundInfo highBackgroundInfo = new AppointmentBackgroundInfo(3, "High", Color.OrangeRed, Color.OrangeRed);
            highBackgroundInfo.ShadowWidth = 0;
            this.houseKeepingScheduler.Backgrounds.Add(highBackgroundInfo);

            this.houseKeepingScheduler.AppointmentEditDialogShowing += houseKeepingScheduler_AppointmentEditDialogShowing;
            this.houseKeepingScheduler.AppointmentChanged += houseKeepingScheduler_AppointmentChanged;
            this.houseKeepingScheduler.ActiveViewChanged += houseKeepingScheduler_ActiveViewChanged;
            this.houseKeepingScheduler.ActiveViewType = SchedulerViewType.Timeline;
            this.houseKeepingScheduler.Culture = culture;
            this.houseKeepingDateNavigator.DateTimePicker.ValueChanged += HouseKeepingNavigatorDateTimePicker_ValueChanged;
            this.houseKeepingDaysToggleButton.ToggleStateChanged += houseKeepingDaysButton_ToggleStateChanged;
            this.houseKeepingWeeklyToggleButton.ToggleStateChanged += houseKeepingWeeklyButton_ToggleStateChanged;
            this.houseKeepingMonthlyToggleButton.ToggleStateChanged += houseKeepingMonthlyButton_ToggleStateChanged;

            this.houseKeepingScheduler.GroupType = GroupType.Resource;
            this.houseKeepingDaysToggleButton.PerformClick();

            this.houseKeepingScheduler.GetDayView().ShowAllDayArea = false;

            this.houseKeepingListView.ListViewElement.Padding = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.houseKeepingListView.VisualItemCreating += houseKeepingListView_VisualItemCreating;
            this.houseKeepingListView.VisualItemFormatting += leftView_VisualItemFormatting;
            ListViewDataItemGroup houseKeepingGroup = new ListViewDataItemGroup();
            houseKeepingGroup.Text = "HOUSE KEEPING";
            ListViewDataItemGroup houseKeepersGroup = new ListViewDataItemGroup();
            houseKeepersGroup.Text = "STAFF - SERVICE";
            ListViewDataItemGroup notAssignedGroup = new ListViewDataItemGroup();
            notAssignedGroup.Text = "Not assigned";

            this.houseKeepingListView.Groups.AddRange(new ListViewDataItemGroup[] { houseKeepingGroup, houseKeepersGroup, notAssignedGroup });
            this.houseKeepingListView.ShowGroups = true;
            this.houseKeepingListView.EnableCustomGrouping = true;
            this.houseKeepingListView.ShowCheckBoxes = true;
            Array houseKeepingOptions = Enum.GetValues(typeof(HouseKeepingStatus));
            foreach (object item in houseKeepingOptions)
            {
                ListViewDataItem houseKeepingItem = new ListViewDataItem(Utils.GetHouseKeepingStatus((HouseKeepingStatus)item));
                houseKeepingItem.Value = (HouseKeepingStatus)item;
                houseKeepingItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.On;
                this.houseKeepingListView.Items.Add(houseKeepingItem);
                houseKeepingItem.Group = houseKeepingGroup;
            }
            foreach (Resource r in this.houseKeepingScheduler.Resources)
            {
                ListViewDataItem resourceItem = new ListViewDataItem();
                resourceItem.Value = r.Name;
                resourceItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.On;
                this.houseKeepingListView.Items.Add(resourceItem);
                resourceItem.Group = houseKeepersGroup;
            }
            ListViewDataItem needsRepairItem = new ListViewDataItem("Repair");
            needsRepairItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.Off;
            this.houseKeepingListView.Items.Add(needsRepairItem);
            needsRepairItem.Group = houseKeepingGroup;

            ListViewDataItem notAssignedItem = new ListViewDataItem();
            notAssignedItem.Value = "Not assigned rooms";
            notAssignedItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.houseKeepingListView.Items.Add(notAssignedItem);
            notAssignedItem.Group = notAssignedGroup;

            this.houseKeepingListView.ItemCheckedChanged += houseKeepingListView_ItemCheckedChanged;
            this.houseKeepingListView.AllowEdit = false;
            this.houseKeepingListView.SelectedItemChanging += delegate (object sender, ListViewItemCancelEventArgs e) { e.Cancel = true; };
            this.houseKeepingListView.SelectedIndex = -1;

            #endregion
        }
        #endregion

        #region Events
        private void houseKeepingListView_VisualItemCreating(object sender, ListViewVisualItemCreatingEventArgs e)
        {
            if (e.VisualItem is SimpleListViewVisualItem)
            {
                e.VisualItem = new OptionsSimpleListViewVisualItem();
            }
        }

        private void houseKeepingScheduler_AppointmentChanged(object sender, AppointmentChangedEventArgs e)
        {
            if (e.PropertyName == "StatusId")
            {
                bool repair = false;
                ListViewDataItem item = this.houseKeepingListView.Groups[0].Items.FirstOrDefault<ListViewDataItem>(i => i.CheckState == ToggleState.On && i.Text == "Repair");
                if (item != null)
                {
                    repair = true;
                }
                UpdateAppointmentsVisibility(this.houseKeepingListView.Groups[0], repair);
            }
            this.houseKeepingListView.ListViewElement.SynchronizeVisualItems();
        }

        private void houseKeepingScheduler_AppointmentEditDialogShowing(object sender, AppointmentEditDialogShowingEventArgs e)
        {
            if (e.Appointment.DataItem == null)
            {
                e.Cancel = true;
            }
            e.AppointmentEditDialog = new HouseKeepingEditAppointmentDialog();

            ((RadForm)e.AppointmentEditDialog).FormClosed += HotelAppForm_FormClosed;
        }

        private void HotelAppForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.houseKeepingListView.ListViewElement.SynchronizeVisualItems();
        }



        private void service_PreviewDragStart(object sender, PreviewDragStartEventArgs e)
        {
            GridDataRowElement rowElement = e.DragInstance as GridDataRowElement;
            if (rowElement == null)
            {
                e.CanStart = false;
                return;
            }
            e.CanStart = true;
            draggedRowInfo = rowElement.RowInfo;
        }

        private void service_PreviewDragOver(object sender, RadDragOverEventArgs e)
        {
            SchedulerCellElement cell = e.HitTarget as SchedulerCellElement;
            if (cell != null && cell.View.GetResource() != null)
            {
                e.CanDrop = true;
            }
            else
            {
                e.CanDrop = false;
            }
        }

        private void service_PreviewDragDrop(object sender, RadDropEventArgs e)
        {
            SchedulerCellElement cell = e.HitTarget as SchedulerCellElement;
            Room draggedRoom = draggedRowInfo.DataBoundItem as Room;
            if (cell == null || draggedRowInfo == null || draggedRowInfo == null)
            {
                e.Handled = false;
                return;
            }

            e.Handled = true;
            draggedRoom.HouseKeeperId = int.Parse(cell.View.GetResource().Id.KeyValue.ToString());
            draggedRoom.HouseKeepingStart = cell.Date;
            draggedRoom.HouseKeepingEnd = cell.Date.AddHours(1);
            SchedulerBindingDataSource sbs = this.houseKeepingScheduler.DataSource as SchedulerBindingDataSource;
            sbs.Rebind();
            this.Height += 1;
            this.Height -= 1;

            this.notAssignedGridView.DataSource = this.Rooms.Where<Room>(r => r.HouseKeeperId == null && r.HouseKeepingStatus != HouseKeepingStatus.Clean);
            this.houseKeepingListView.ListViewElement.SynchronizeVisualItems();
        }

        private void houseKeepingDaysButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                this.houseKeepingSchedulerHeaderLabel.Text = "3 Days";
                this.houseKeepingWeeklyToggleButton.ToggleState = ToggleState.Off;
                this.houseKeepingMonthlyToggleButton.ToggleState = ToggleState.Off;
                this.houseKeepingScheduler.ActiveViewType = SchedulerViewType.Day;
            }
        }

        private void houseKeepingWeeklyButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                this.houseKeepingSchedulerHeaderLabel.Text = "Weekly";
                this.houseKeepingDaysToggleButton.ToggleState = ToggleState.Off;
                this.houseKeepingMonthlyToggleButton.ToggleState = ToggleState.Off;
                this.houseKeepingScheduler.ActiveViewType = SchedulerViewType.Week;
            }
        }

        private void houseKeepingMonthlyButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                this.houseKeepingSchedulerHeaderLabel.Text = "Monthly";
                this.houseKeepingDaysToggleButton.ToggleState = ToggleState.Off;
                this.houseKeepingWeeklyToggleButton.ToggleState = ToggleState.Off;
                this.houseKeepingScheduler.ActiveViewType = SchedulerViewType.Month;
            }
        }

        private void HouseKeepingNavigatorDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.houseKeepingScheduler.ActiveView.StartDate = this.houseKeepingDateNavigator.DateTimePicker.Value;
        }

        private void houseKeepingListView_ItemCheckedChanged(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.Text == "Not assigned rooms")
            {
                if (e.Item.CheckState == ToggleState.On)
                {
                    this.splitPanel2.Visible = true;
                    this.houseKeepingSplitContainer.RestoreSplitterPosition(this.houseKeepingSplitContainer.Splitters[0]);
                }
                else
                {
                    this.splitPanel2.Visible = false;
                    this.houseKeepingSplitContainer.MoveSplitter(this.houseKeepingSplitContainer.Splitters[0], RadDirection.Down);
                }
            }
            UpdateHouseKeepingResources(e.Item.Group, e.Item.Text, e.Item.CheckState);
        }

        private void UpdateHouseKeepingResources(ListViewDataItemGroup group, string itemText, ToggleState toggleState)
        {
            SchedulerBindingDataSource schedulerSource = this.houseKeepingScheduler.DataSource as SchedulerBindingDataSource;
            BindingList<HouseKeeper> houseKeepersSource = schedulerSource.ResourceProvider.DataSource as BindingList<HouseKeeper>;
            List<HouseKeeper> toDelete = new List<HouseKeeper>();
            if (group.Text == "STAFF - SERVICE")
            {
                if (toggleState == ToggleState.Off)
                {
                    foreach (HouseKeeper h in houseKeepersSource)
                    {
                        if (h.Name.ToString() == itemText)
                        {
                            toDelete.Add(h);
                        }
                    }
                    while (toDelete.Count > 0)
                    {
                        houseKeepersSource.Remove(toDelete[0]);
                        toDelete.RemoveAt(0);
                    }
                }
                else
                {
                    foreach (HouseKeeper hk in this.HouseKeepers)
                    {
                        if (!HouseKeeperExists(houseKeepersSource, hk.Id))
                        {
                            ListViewDataItem item = group.Items.FirstOrDefault<ListViewDataItem>(i => i.CheckState == ToggleState.On &&
                                                                                                      i.Text == hk.Name.ToString());
                            if (item != null)
                            {
                                houseKeepersSource.Add(new HouseKeeper(hk.Id, hk.Name, hk.Photo));
                            }
                        }
                    }
                }
            }
            else if (group.Text == "HOUSE KEEPING")
            {
                bool repair = false;
                ListViewDataItem item = group.Items.FirstOrDefault<ListViewDataItem>(i => i.CheckState == ToggleState.On && i.Text == "Repair");
                if (item != null)
                {
                    repair = true;
                }
                UpdateAppointmentsVisibility(group, repair);
            }

            foreach (Resource r in this.houseKeepingScheduler.Resources)
            {
                r.Color = Color.White;
            }

            if (group.Text == "STAFF - SERVICE")
            {
                ListViewDataItem houseKeepingItem = group.Items.FirstOrDefault<ListViewDataItem>(i => i.CheckState == ToggleState.On);
                if (houseKeepingItem == null)
                {
                    this.houseKeepingScheduler.GroupType = GroupType.None;
                }
                else
                {
                    this.houseKeepingScheduler.GroupType = GroupType.Resource;
                }
            }

            this.houseKeepingScheduler.SchedulerElement.RefreshViewElement();
            RefreshHouseKeepingScheduler();
        }

        private void UpdateAppointmentsVisibility(ListViewDataItemGroup group, bool repair)
        {
            List<Room> roomsToHide = new List<Room>();
            List<Room> roomsToShow = new List<Room>();
            foreach (Appointment a in this.houseKeepingScheduler.Appointments)
            {
                Room r = a.DataItem as Room;

                ListViewDataItem item = group.Items.FirstOrDefault<ListViewDataItem>(i => i.CheckState == ToggleState.On &&
                                                                                          i.Text == r.HouseKeepingStatus.ToString());
                if (item != null)
                {
                    if ((r.NeedsRepairs && repair) || !repair)
                    {
                        roomsToShow.Add(r);
                    }
                    else
                    {
                        roomsToHide.Add(r);
                    }
                }
                else
                {
                    roomsToHide.Add(r);
                }
            }
            while (roomsToHide.Count > 0)
            {
                roomsToHide.First().Visible = false;
                roomsToHide.RemoveAt(0);
            }
            while (roomsToShow.Count > 0)
            {
                roomsToShow.First().Visible = true;
                roomsToShow.RemoveAt(0);
            }
        }

        private bool HouseKeeperExists(BindingList<HouseKeeper> houseKeepersSource, int id)
        {
            foreach (HouseKeeper h in houseKeepersSource)
            {
                if (h.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        private void houseKeepingScheduler_RulerTextFormatting(object sender, RulerTextFormattingEventArgs e)
        {
            if (e.Context == RulerTextFormattingContext.Minute)
            {
                e.Text = string.Empty;
            }
            else
            {
                e.Text = e.Time.ToString("HH:mm");
            }
        }

        private void houseKeepingScheduler_CellFormatting(object sender, SchedulerCellEventArgs e)
        {
            e.CellElement.Visibility = ElementVisibility.Visible;

            if (e.CellElement.VisualState.Contains("CornerHeaderCell3") || e.CellElement.VisualState.Contains("CornerHeaderCell2"))
            {
                e.CellElement.Visibility = ElementVisibility.Collapsed;
            }
            SchedulerResourceHeaderCellElement headerCell = e.CellElement as SchedulerResourceHeaderCellElement;
            if (headerCell != null)
            {
                headerCell.Layout.LeftPart.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
                headerCell.ImageLayout = ImageLayout.None;
                headerCell.ImageAlignment = ContentAlignment.MiddleLeft;
                headerCell.TextImageRelation = TextImageRelation.ImageBeforeText;
                headerCell.TextAlignment = ContentAlignment.MiddleLeft;
                headerCell.CustomFont = Utils.MainFont;
                headerCell.CustomFontSize = 10;
                headerCell.BorderGradientStyle = GradientStyles.Solid;
                headerCell.BorderColor = Color.FromArgb(209, 209, 209);
            }
            else if (e.CellElement.VisualState == "MonthViewHeaderCellElement.IsVertical")
            {
                e.CellElement.BorderBoxStyle = BorderBoxStyle.FourBorders;
                e.CellElement.BorderLeftWidth = 0;
                e.CellElement.BorderTopWidth = 1;
                e.CellElement.BorderTopColor = Color.FromArgb(209, 209, 209);
                e.CellElement.BorderRightWidth = 1;
                e.CellElement.BorderRightColor = Color.FromArgb(209, 209, 209);
                e.CellElement.BorderBottomWidth = 1;
                e.CellElement.BorderBottomColor = Color.FromArgb(209, 209, 209);
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.ImageLayoutProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.ImageAlignmentProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.TextImageRelationProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.CustomFontProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.CustomFontSizeProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.BorderGradientStyleProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.BorderColorProperty, ValueResetFlags.Local);
            }
            if (!(e.CellElement is SchedulerHeaderCellElement) && e.CellElement.VisualState != "CornerHeaderCell2")
            {
                e.CellElement.BackColor = Color.FromArgb(244, 244, 244);
                e.CellElement.Opacity = 1;
            }
            else if (e.CellElement.VisualState == "MonthViewHeaderCellElement.IsVertical")
            {
                e.CellElement.BorderBoxStyle = BorderBoxStyle.FourBorders;
                e.CellElement.BorderLeftWidth = 0;
                e.CellElement.BorderTopWidth = 1;
                e.CellElement.BorderTopColor = Color.FromArgb(209, 209, 209);
                e.CellElement.BorderRightWidth = 1;
                e.CellElement.BorderRightColor = Color.FromArgb(209, 209, 209);
                e.CellElement.BorderBottomWidth = 1;
                e.CellElement.BorderBottomColor = Color.FromArgb(209, 209, 209);
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.OpacityProperty, ValueResetFlags.Local);
            }
            if (e.CellElement.Text == "Local")
            {
                e.CellElement.Text = string.Empty;
            }
        }

        private void houseKeepingScheduler_ActiveViewChanged(object sender, SchedulerViewChangedEventArgs e)
        {
            this.RefreshHouseKeepingScheduler();
        }

        private void RefreshHouseKeepingScheduler()
        {
            SchedulerDayViewGroupedByResourceElement dayView = this.houseKeepingScheduler.SchedulerElement.ViewElement as SchedulerDayViewGroupedByResourceElement;
            SchedulerMonthViewGroupedByResourceElement monthView = this.houseKeepingScheduler.SchedulerElement.ViewElement as SchedulerMonthViewGroupedByResourceElement;
            if (this.houseKeepingScheduler.ActiveViewType != SchedulerViewType.Day)
            {
                this.houseKeepingScheduler.ActiveView.ResourcesPerView = 1;
            }
            else
            {
                this.houseKeepingScheduler.ActiveView.ResourcesPerView = 3;
            }
            if (dayView != null)
            {
                SchedulerDayViewBase dv = this.houseKeepingScheduler.ActiveView as SchedulerDayViewBase;
                dv.RulerStartScale = 8;
                dv.RulerEndScale = 19;
                dayView.DrawBorder = false;
                dayView.ResourceHeaderHeight = 65;
                RulerPrimitive ruler;
                foreach (RadElement c in dayView.Children)
                {
                    SchedulerDayViewElement view = c as SchedulerDayViewElement;
                    if (view != null)
                    {
                        view.DataAreaElement.Ruler.DefaultSeparatorOffset = 40;
                        ruler = view.DataAreaElement.Ruler;
                        ruler.CustomFont = Utils.MainFont;
                        ruler.CustomFontSize = 10f;
                        ruler.Border.BoxStyle = BorderBoxStyle.FourBorders;
                        ruler.Border.LeftWidth = 0;
                        ruler.Border.TopWidth = 0;
                        ruler.Border.RightWidth = 1;
                        ruler.Border.BottomWidth = 0;
                    }
                }
                this.houseKeepingScheduler.HeaderFormat = "dd MMM";
            }

            if (monthView != null)
            {
                monthView.DrawBorder = false;
                monthView.ResourceHeaderHeight = 65;
                monthView.ResourcesHeader.DrawBorder = false;

                foreach (RadElement view in monthView.Children)
                {
                    SchedulerMonthViewElement monthViewElement = view as SchedulerMonthViewElement;
                    if (monthViewElement != null)
                    {
                        monthViewElement.VerticalHeader.HeaderWidth = 50;
                        monthViewElement.Children[3].Visibility = ElementVisibility.Collapsed;
                        monthViewElement.DrawBorder = false;
                    }
                }
            }

            if (this.houseKeepingScheduler.GroupType == GroupType.None)
            {
                SchedulerDayViewElement dayViewElement = this.houseKeepingScheduler.SchedulerElement.ViewElement as SchedulerDayViewElement;
                if (dayViewElement != null)
                {
                    dayViewElement.DataAreaElement.Ruler.DefaultSeparatorOffset = 40;
                    RulerPrimitive ruler = dayViewElement.DataAreaElement.Ruler;
                    ruler.CustomFont = Utils.MainFont;
                    ruler.CustomFontSize = 10f;
                    ruler.Border.BoxStyle = BorderBoxStyle.FourBorders;
                    ruler.Border.LeftWidth = 0;
                    ruler.Border.TopWidth = 0;
                    ruler.Border.RightWidth = 1;
                    ruler.Border.BottomWidth = 0;
                }
            }
            this.houseKeepingScheduler.CellFormatting -= houseKeepingScheduler_CellFormatting;
            this.houseKeepingScheduler.RulerTextFormatting -= houseKeepingScheduler_RulerTextFormatting;
            this.houseKeepingScheduler.ActiveView.PropertyChanged -= ActiveView_PropertyChanged;
            this.houseKeepingScheduler.AppointmentFormatting -= houseKeepingScheduler_AppointmentFormatting;

            this.houseKeepingScheduler.CellFormatting += houseKeepingScheduler_CellFormatting;
            this.houseKeepingScheduler.RulerTextFormatting += houseKeepingScheduler_RulerTextFormatting;
            this.houseKeepingScheduler.ActiveView.PropertyChanged += ActiveView_PropertyChanged;
            this.houseKeepingScheduler.AppointmentFormatting += houseKeepingScheduler_AppointmentFormatting;
            this.houseKeepingScheduler.Height -= 1;
            this.houseKeepingScheduler.Height -= 1;
        }

        private void houseKeepingScheduler_AppointmentFormatting(object sender, SchedulerAppointmentEventArgs e)
        {
            e.AppointmentElement.BackColor = Color.FromArgb(209, 209, 209);
            e.AppointmentElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            e.AppointmentElement.NumberOfColors = 4;
            e.AppointmentElement.BorderColor = Color.FromArgb(209, 209, 209);
            e.AppointmentElement.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.OuterInnerBorders;

            Room r = e.Appointment.DataItem as Room;
            if (r != null)
            {
                e.AppointmentElement.Text = r.Name + " " + r.HouseKeepingStatus;
                e.AppointmentElement.ImageAlignment = ContentAlignment.MiddleLeft;
                e.AppointmentElement.TextAlignment = ContentAlignment.MiddleRight;
                e.AppointmentElement.Image = Utils.GetRoomIconByType(r.Type);
                e.AppointmentElement.TextImageRelation = TextImageRelation.ImageBeforeText;
                e.AppointmentElement.DisableHTMLRendering = true;
                e.AppointmentElement.CustomFont = Utils.MainFont;
                e.AppointmentElement.CustomFontSize = 9f;
                e.AppointmentElement.ForeColor = Color.Black;
            }
        }

        #endregion

    }
}
