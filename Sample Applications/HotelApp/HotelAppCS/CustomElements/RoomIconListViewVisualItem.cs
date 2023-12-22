using HotelApp.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace HotelApp
{
    public class RoomIconListViewVisualItem : IconListViewVisualItem
    {
        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(IconListViewVisualItem);
            }
        }

        private LightVisualElement roomId = new LightVisualElement();
        private LightVisualElement roomStatus = new LightVisualElement();
        private LightVisualElement bookingInfo = new LightVisualElement();
        private LightVisualElement bookingDuration = new LightVisualElement(); 
        private LightVisualElement houseKeepingInfo = new LightVisualElement();
        private LightVisualElement needsRepair = new LightVisualElement();
        private StackLayoutElement verticalContainer = new StackLayoutElement();
        private StackLayoutElement roomHeaderContainer = new StackLayoutElement(); 
        private StackLayoutElement roomFooterContainer = new StackLayoutElement(); 

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            verticalContainer.Orientation = System.Windows.Forms.Orientation.Vertical;
            verticalContainer.NotifyParentOnMouseInput = true;
            verticalContainer.ShouldHandleMouseInput = false;
            verticalContainer.StretchHorizontally = true;
            verticalContainer.StretchVertically = true; 

            roomHeaderContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            roomHeaderContainer.NotifyParentOnMouseInput = true;
            roomHeaderContainer.ShouldHandleMouseInput = false;
            roomHeaderContainer.Children.Add(roomId);
            roomHeaderContainer.Children.Add(roomStatus);
            roomHeaderContainer.StretchHorizontally = true;

            roomId.NotifyParentOnMouseInput = true;
            roomId.ShouldHandleMouseInput = false;
            roomId.StretchHorizontally = true;
            roomId.CustomFont = Utils.MainFont;
            roomId.CustomFontSize = 9;
            roomId.CustomFontStyle = FontStyle.Bold;
            roomId.Margin = new System.Windows.Forms.Padding(5, 10, 0, 0);
            roomId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;

            roomStatus.NotifyParentOnMouseInput = true;
            roomStatus.ShouldHandleMouseInput = false;
            roomStatus.StretchHorizontally = false;
            roomStatus.CustomFont = Utils.MainFont;
            roomStatus.CustomFontSize = 9;
            roomStatus.CustomFontStyle = FontStyle.Regular;
            roomStatus.Margin = new System.Windows.Forms.Padding(0,5,5,0);

            roomFooterContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            roomFooterContainer.NotifyParentOnMouseInput = true;
            roomFooterContainer.ShouldHandleMouseInput = false;
            roomFooterContainer.StretchHorizontally = true;
            roomFooterContainer.DrawFill = true;
            roomFooterContainer.BackColor = Color.White;
            roomFooterContainer.GradientStyle = GradientStyles.Solid;
            roomFooterContainer.MinSize = new System.Drawing.Size(0, 30);

            bookingInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            bookingInfo.StretchHorizontally = false;
            bookingInfo.Layout.LeftPart.Padding = new System.Windows.Forms.Padding(24, 0, 8, 0);

            bookingInfo.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            bookingInfo.NotifyParentOnMouseInput = true;
            bookingInfo.ShouldHandleMouseInput = false;
            bookingInfo.CustomFont = Utils.MainFont;
            bookingInfo.CustomFontSize = 12;
            bookingInfo.CustomFontStyle = FontStyle.Regular;

            needsRepair.Text = "repair";
            bookingDuration.NotifyParentOnMouseInput = true;
            bookingDuration.ShouldHandleMouseInput = false;

            bookingDuration.StretchVertically = true;
            houseKeepingInfo.StretchVertically = true;
            needsRepair.StretchVertically = true;
            roomFooterContainer.Children.Add(bookingDuration);
            roomFooterContainer.Children.Add(houseKeepingInfo);
            roomFooterContainer.Children.Add(needsRepair); 

            needsRepair.NotifyParentOnMouseInput = true;
            needsRepair.ShouldHandleMouseInput = false;
            needsRepair.StretchHorizontally = false;
            needsRepair.Alignment = ContentAlignment.MiddleRight;
            needsRepair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;           
            needsRepair.CustomFont = Utils.MainFont;
            needsRepair.CustomFontSize = 9;
            needsRepair.CustomFontStyle = FontStyle.Regular;

            houseKeepingInfo.NotifyParentOnMouseInput = true;
            houseKeepingInfo.ShouldHandleMouseInput = false;
            houseKeepingInfo.StretchHorizontally = false;
            houseKeepingInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            houseKeepingInfo.CustomFont = Utils.MainFont;
            houseKeepingInfo.CustomFontSize = 9;
            houseKeepingInfo.CustomFontStyle = FontStyle.Regular;

            bookingDuration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            bookingDuration.CustomFont = Utils.MainFont;
            bookingDuration.CustomFontSize = 9;
            bookingDuration.CustomFontStyle = FontStyle.Regular;
            bookingDuration.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);    
            bookingDuration.StretchHorizontally = false; 
             
            verticalContainer.Children.Add(roomHeaderContainer);
            verticalContainer.Children.Add(bookingInfo);
            verticalContainer.Children.Add(roomFooterContainer);

            this.Children.Add(this.verticalContainer);
        }
        
        protected override void SynchronizeProperties()
        {
            base.SynchronizeProperties();
            this.DrawText = false;
            this.BackColor = Color.White;
            this.DrawFill = true;
            this.DrawBorder = false;
            roomId.Margin = new System.Windows.Forms.Padding(8,8,0,0);
            bookingInfo.ImageLayout = System.Windows.Forms.ImageLayout.None;
            bookingInfo.Margin = new System.Windows.Forms.Padding(24, 0, 0, 0); 
            
            bookingInfo.Layout.LeftPart.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            bookingInfo.StretchHorizontally = true;
            bookingInfo.ImageAlignment = ContentAlignment.MiddleLeft;
            bookingInfo.TextAlignment = ContentAlignment.MiddleLeft;
             
            bookingDuration.Layout.LeftPart.Margin = new System.Windows.Forms.Padding(0, -3, 0, 0);
            bookingDuration.ForeColor = Color.FromArgb(200, 0, 0, 0);
            houseKeepingInfo.ForeColor = Color.FromArgb(200, 0, 0, 0);
            houseKeepingInfo.Layout.LeftPart.Margin = new System.Windows.Forms.Padding(0, -3, 0, 0);
            needsRepair.ForeColor = Color.FromArgb(200, 0, 0, 0);
            needsRepair.Layout.LeftPart.Margin = new System.Windows.Forms.Padding(0, -3, 0, 0);

            Room room = this.Data.DataBoundItem as Room;
            if (room != null)
            { 
                HotelAppForm form = this.ElementTree.Control.FindForm() as HotelAppForm;
                roomId.Text = "Room " + room.Id; 
                RoomStatus roomStatusAtDate = room.GetStatusByBooking(form.OverviewDate, form.Bookings);
                roomStatus.Text = Utils.GetRoomStatus(roomStatusAtDate).ToLower();
               
                Booking booking = form.GetBooking(room);
                if (booking != null)
                {
                    bookingInfo.Text = booking.Name;
                    bookingInfo.Image = Utils.GetImageByRoomType(room.Type);   

                    bookingDuration.Text = +(booking.To - form.OverviewDate).Days + 1 + " days";
                    if (roomStatusAtDate == RoomStatus.Occupied || roomStatusAtDate == RoomStatus.CheckedOut)
                    {
                        this.BackColor = Color.FromArgb(247, 247, 247);
                    }
                    else
                    { 
                        this.BackColor = Color.FromArgb(232, 232, 232);
                    }
                    
                    roomId.ForeColor = Color.FromArgb(190, 0, 0, 0);
                    roomStatus.ForeColor = Color.Black;
                    bookingInfo.ForeColor = Color.Black;
                }
                else
                {
                    bookingInfo.Text = "Free Room";
                    bookingInfo.Image = Utils.GetAvailableImageByTheme();
                    bookingDuration.Text = "0 days";
                    this.BackColor = Utils.MainThemeColor;
                    roomId.ForeColor = Color.White;
                    roomStatus.ForeColor = Color.White;
                    bookingInfo.ForeColor = Color.White;
                }
                houseKeepingInfo.Text = "" + Utils.GetHouseKeepingStatus(room.HouseKeepingStatus).ToLower();
                needsRepair.Image = Properties.Resources.GlyphWrench;
                bookingDuration.Image = Properties.Resources.GlyphCalendar_small;
                if (room.HouseKeepingStatus == HouseKeepingStatus.NotClean)
                {
                    houseKeepingInfo.Image = Properties.Resources.GlyphClose;
                }
                else
                {
                    houseKeepingInfo.Image = Properties.Resources.GlyphCheck_small;
                }
                if (room.NeedsRepairs)
                {
                    needsRepair.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                }
                else
                {
                    needsRepair.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                }
            }
        }
    }
}