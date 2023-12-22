using HotelApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace HotelApp
{
    public class RoomGridDataCellElement : GridDataCellElement
    {
        private StackLayoutElement container = new StackLayoutElement();
        private LightVisualElement roomIdElement = new LightVisualElement();
        private LightVisualElement roomTypeElement = new LightVisualElement();
            
        public RoomGridDataCellElement(GridViewColumn column, GridRowElement row) : base(column, row)
        {
        }
            
        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridDataCellElement);
            }
        }
            
        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            container.Orientation = Orientation.Horizontal;
            container.StretchHorizontally = true;
            container.StretchVertically = true;
            roomIdElement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            roomIdElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            roomIdElement.ImageAlignment = ContentAlignment.MiddleLeft;
            roomIdElement.TextAlignment = ContentAlignment.MiddleLeft;
            roomIdElement.MaxSize = new System.Drawing.Size(80, 100);
            roomIdElement.MinSize = new System.Drawing.Size(80, 0);
            roomIdElement.StretchHorizontally = false;
            roomTypeElement.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            roomTypeElement.StretchHorizontally = true;
            roomTypeElement.TextAlignment = ContentAlignment.MiddleRight;
            container.Children.Add(roomIdElement);
            container.Children.Add(roomTypeElement);
                
            this.Children.Add(container);
        }
            
        protected override void SetContentCore(object value)
        {
            base.SetContentCore(value);
            this.DrawText = false;
            Booking booking = this.RowInfo.DataBoundItem as Booking;
            if (booking != null)
            {
                Room room = Utils.GetRoomById(booking.RoomId, this.RowInfo.ViewTemplate.Tag as BindingList<Room>);
                roomIdElement.Image = Utils.GetRoomIconByType(room.Type);
                roomIdElement.Text = booking.RoomId.ToString();
                roomTypeElement.Text = Utils.GetRoomType(room.Type).ToLower();
            }
        }
            
        public override bool IsCompatible(GridViewColumn data, object context)
        {
            return data.Name == "RoomId" && context is GridViewDataRowInfo;
        }
    }
    
}