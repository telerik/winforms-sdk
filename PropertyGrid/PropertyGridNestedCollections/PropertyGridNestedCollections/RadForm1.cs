using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace _1517562PropertyGridNestedCollections
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

            SegmentsCollection segments = new SegmentsCollection();
            for (int i = 0; i < 5; i++)
            {
                segments.Add(new Segment(new Start(i,i + 1, i + 2),new End(i,i * i,i * i + i,i + 3,i + 4, i + 5)));
            }
            this.radPropertyGrid1.SelectedObject = new Item(5,segments,145229);

            this.radPropertyGrid1.Edited += RadPropertyGrid1_Edited;

            this.radPropertyGrid1.Editing += RadPropertyGrid1_Editing;

            this.radPropertyGrid1.EditorInitialized += RadPropertyGrid1_EditorInitialized;
        }

        private void RadPropertyGrid1_EditorInitialized(object sender, PropertyGridItemEditorInitializedEventArgs e)
        {
            PropertyGridUITypeEditor editor = e.Editor as PropertyGridUITypeEditor;
            if (editor!=null)
            {
                PropertyGridUITypeEditorElement el = editor.EditorElement as PropertyGridUITypeEditorElement;
                el.Button.Visibility = ElementVisibility.Collapsed;
            }
        }

        private void RadPropertyGrid1_Editing(object sender, PropertyGridItemEditingEventArgs e)
        {
            if (e.Item.Label=="Segments") // or Employees in your case
            {
                e.Cancel = true;
            }
        }

        Timer t = null;
        private void RadPropertyGrid1_Edited(object sender, PropertyGridItemEditedEventArgs e)
        {
            if (e.Item.Label=="Count")
            {
                Item item = this.radPropertyGrid1.SelectedObject as Item;
                if (item.Segments.Count<item.Count)
                {
                    item.Segments.Add(new Segment(new Start(0,0,0), new End(0,0,0,0,0,0)));
                }
                t = new Timer();
                t.Interval = 500;
                t.Tick += T_Tick;t.Start();
              
            }
        }

        private void T_Tick(object sender, EventArgs e)
        {
            t.Stop();
            Item item = this.radPropertyGrid1.SelectedObject as Item;
            this.radPropertyGrid1.SelectedObject = null;
            this.radPropertyGrid1.SelectedObject = item;
        }

        public class SegmentsCollection : System.Collections.CollectionBase, ICustomTypeDescriptor
        {
            public override string ToString()
            {
                return "Count "+ this.Count;
            }
            public void Add(Segment s)
            {
                this.List.Add(s);
            }

            public void Remove(Segment s)
            {
                this.List.Remove(s);
            }

            public Segment this[ int index ]
            {
                get
                {
                    return (Segment)this.List[index];
                }
            }

            public String GetClassName()
            {
                return TypeDescriptor.GetClassName(this, true);
            }

            public AttributeCollection GetAttributes()
            {
                return TypeDescriptor.GetAttributes(this, true);
            }

            public String GetComponentName()
            {
                return TypeDescriptor.GetComponentName(this, true);
            }

            public TypeConverter GetConverter()
            {
                return TypeDescriptor.GetConverter(this, true);
            }

            public EventDescriptor GetDefaultEvent()
            {
                return TypeDescriptor.GetDefaultEvent(this, true);
            }

            public PropertyDescriptor GetDefaultProperty()
            {
                return TypeDescriptor.GetDefaultProperty(this, true);
            }

            public object GetEditor(Type editorBaseType)
            {
                return TypeDescriptor.GetEditor(this, editorBaseType, true);
            }

            public EventDescriptorCollection GetEvents(Attribute[] attributes)
            {
                return TypeDescriptor.GetEvents(this, attributes, true);
            }

            public EventDescriptorCollection GetEvents()
            {
                return TypeDescriptor.GetEvents(this, true);
            }

            public object GetPropertyOwner(PropertyDescriptor pd)
            {
                return this;
            }

            public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
            {
                return GetProperties();
            }

            PropertyDescriptorCollection pds;

            public PropertyDescriptorCollection GetProperties() 
            {
                // Create a new collection object PropertyDescriptorCollection
                pds = new PropertyDescriptorCollection(null);

                // Iterate the list of employees
                for (int i = 0; i < this.List.Count; i++)
                {
                    // For each employee create a property descriptor 
                    // and add it to the 
                    // PropertyDescriptorCollection instance
                    SegmentsCollectionPropertyDescriptor pd = new 
                    SegmentsCollectionPropertyDescriptor(this,i);
                    pds.Add(pd);
                }
                return pds;
            }
        }

        public class SegmentsCollectionPropertyDescriptor : PropertyDescriptor
        {
            private SegmentsCollection collection = null;
            private int index = -1;

            public SegmentsCollectionPropertyDescriptor(SegmentsCollection coll,
                int idx) : base("#" + idx.ToString(), null)
            {
                this.collection = coll;
                this.index = idx;
            }

            public override AttributeCollection Attributes
            {
                get 
                { 
                    return new AttributeCollection(null);
                }
            }

            public override bool CanResetValue(object component)
            {
                return true;
            }

            public override Type ComponentType
            {
                get 
                { 
                    return this.collection.GetType();
                }
            }

            public override string DisplayName
            {
                get 
                {
                    Segment s = this.collection[index];
                    return s.Start + " " + s.End;
                }
            }

            public override string Description
            {
                get
                {
                    Segment s = this.collection[index];
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Start: ");
                    sb.Append(s.Start.X);
                    sb.Append(",");
                    sb.Append(s.Start.Y);
                    sb.Append(",");
                    sb.Append(s.Start.Y);
                    sb.Append(" End: ");
                    sb.Append(s.End.Direction);
                    sb.Append(" direction ");
                    sb.Append(s.End.ElevationAngle);

                    return sb.ToString();
                }
            }

            public override object GetValue(object component)
            {
                return this.collection[index];
            }

            public override bool IsReadOnly
            {
                get
                {
                    return true;
                }
            }

            public override string Name
            {
                get
                {
                    return "#" + index.ToString();
                }
            }

            public override Type PropertyType
            {
                get
                {
                    return this.collection[index].GetType();
                }
            }

            public override void ResetValue(object component)
            {
            }

            public override bool ShouldSerializeValue(object component)
            {
                return true;
            }

            public override void SetValue(object component, object value)
            {
                // this.collection[index] = value;
            }
        }

        public class Item
        {
            public int Count { get; set; }

            [TypeConverter(typeof(ExpandableObjectConverter))]
            public SegmentsCollection Segments { get; set; }

            public int TotalLength { get; set; }

            public Item(int count, SegmentsCollection segments, int totalLength)
            {
                this.Count = count;
                this.Segments = segments;
                this.TotalLength = totalLength;
            }
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class Segment
        {
            public Start Start { get; set; }

            public End End { get; set; }

            public Segment(Start start, End end)
            {
                this.Start = start;
                this.End = end;
            }

            public override string ToString()
            {
                return this.Start + " "+ this.End.ToString();
            }
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class Start
        {
            public int X { get; set; }

            public int Y { get; set; }

            public int Z { get; set; }

            public Start(int x, int y, int z)
            {
                this.X = x;
                this.Y = y;
                this.Z = z;
            }

            public override string ToString()
            {
                return "Segment Start: " + this.X + ", " + this.Y + ", " + this.Z;
            }
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class End
        {
            public int Length { get; set; }

            public int Direction { get; set; }

            public int ElevationAngle { get; set; }

            public int DeltaX { get; set; }

            public int DeltaY { get; set; }

            public int DeltaZ { get; set; }

            public End(int length, int direction, int elevationAngle, int deltaX, int deltaY, int deltaZ)
            {
                this.Length = length;
                this.Direction = direction;
                this.ElevationAngle = elevationAngle;
                this.DeltaX = deltaX;
                this.DeltaY = deltaY;
                this.DeltaZ = deltaZ;
            }

            public override string ToString()
            {
                return "Segment End: d " + this.Direction + " a " + this.ElevationAngle;
            }
        }
        
        public class SegmentsTypeConverter : ExpandableObjectConverter
        {
            public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
                if (sourceType == typeof(string))
                {
                    return true;
                }

                return base.CanConvertFrom(context, sourceType);
            }

            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            {
                if (destinationType == typeof(string))
                {
                    return true;
                }

                return base.CanConvertTo(context, destinationType);
            }

            public override object ConvertTo(ITypeDescriptorContext context,
                System.Globalization.CultureInfo culture, object value, Type destinationType)
            {
                if (destinationType != typeof(string))
                {
                    return base.ConvertTo(context, culture, value, destinationType);
                }

                List<Segment> segments = value as  List<Segment>;

                if (segments == null)
                {
                    return string.Empty;
                }

                return string.Format("Number of segments: {0}", segments.Count);
            }

            public override object ConvertFrom(ITypeDescriptorContext context,
                System.Globalization.CultureInfo culture, object value)
            {
                string stringValue = value as string;

                //  if (stringValue == null)
                {
                    return base.ConvertFrom(context, culture, value);
                }
                //string number = "";
                //for (int i = 0; i < stringValue.Length; i++)
                //{
                //    char c = stringValue[i];
                //    if (char.IsNumber(c))
                //    {
                //        number += stringValue[i];
                //    }
                //    if (c == ',' || c == '.')
                //    {
                //        number += culture.NumberFormat.NumberDecimalSeparator;
                //    }
                //}
                //TemperatureUnit unit = TemperatureUnit.Kelvin;
                //if (stringValue.ToUpper().Contains("K"))
                //{
                //    unit = TemperatureUnit.Kelvin;
                //}
                //else if (stringValue.ToUpper().Contains("F"))
                //{
                //    unit = TemperatureUnit.Fahrenheit;
                //}
                //else if (stringValue.ToUpper().Contains("C"))
                //{
                //    unit = TemperatureUnit.Celsius;
                //}
                //else
                //{
                //    PropertyGridItem item = context as PropertyGridItem;
                //    if (item != null)
                //    {
                //        Temperature oldTemp = item.Value as Temperature;
                //        if (oldTemp != null)
                //        {
                //            unit = oldTemp.Unit;
                //        }
                //    }
                //}
                //return new Temperature() { Value = double.Parse(number), Unit = unit };
            }
        }
    }
}