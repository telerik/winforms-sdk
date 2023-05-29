using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Scheduler.Dialogs;
using static MultipleCategoriesInAppointments.MainForm;
using static Telerik.WinControls.UI.DateInput;

namespace MultipleCategoriesInAppointments
{
    public partial class CustomAppointmentEditForm : EditAppointmentDialog
    {
        RadLabel categoriesLabel;
        RadCheckedDropDownList categoriesDropDown;
        public CustomAppointmentEditForm()
        {
            InitializeComponent();

            this.cmbBackground.Visible = false;
            this.labelBackground.Visible = false;

            categoriesLabel = new RadLabel();
            categoriesLabel.ThemeName = this.ThemeName;
            categoriesLabel.Text = "Category";
            categoriesLabel.Location = labelBackground.Location;
            this.Controls.Add(categoriesLabel);

            categoriesDropDown = new RadCheckedDropDownList();
            categoriesDropDown.TextBlockFormatting += CategoriesDropDown_TextBlockFormatting;
            categoriesDropDown.VisualListItemFormatting += CategoriesDropDown_VisualListItemFormatting;
            categoriesDropDown.ThemeName = this.ThemeName;
            categoriesDropDown.Location = this.cmbBackground.Location;
            categoriesDropDown.Width = this.cmbBackground.Width;
            categoriesDropDown.DropDownSizingMode = SizingMode.UpDownAndRightBottom;
            this.Controls.Add(categoriesDropDown);

            this.cmbShowTimeAs.Width -= this.cmbShowTimeAs.Width / 2;
            this.cmbShowTimeAs.Left += this.cmbShowTimeAs.Width;
            this.labelStatus.Left += this.cmbShowTimeAs.Width;
            categoriesDropDown.Width += this.cmbShowTimeAs.Width;
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            ((RadScheduler)this.SchedulerData).SchedulerElement.RefreshViewElement();
        }

        protected override void LoadSettingsFromEvent(IEvent sourceEvent)
        {
            base.LoadSettingsFromEvent(sourceEvent);
            AppointmentWithCategories categorizedAppointment = sourceEvent as AppointmentWithCategories;
            if (categorizedAppointment.CategoryIds.Count > 0)
            {
                foreach (RadCheckedListDataItem categoryItem in this.categoriesDropDown.Items)
                {
                    if (categorizedAppointment.CategoryIds.Contains((int)categoryItem.Value))
                    {
                        categoryItem.Checked = true;
                    }
                }
            }

        }

        protected override void ApplySettingsToEvent(IEvent targetEvent)
        {
            base.ApplySettingsToEvent(targetEvent);

            AppointmentWithCategories categorizedAppointment = targetEvent as AppointmentWithCategories;
            categorizedAppointment.CategoryIds.Clear();
            foreach (RadCheckedListDataItem categoryItem in this.categoriesDropDown.CheckedItems)
            {
                categorizedAppointment.CategoryIds.Add((int)categoryItem.Value);
            }
        }
        protected override IEvent CreateNewEvent()
        {
            return new AppointmentWithCategories();
        } 

        protected override void LoadBackgrounds()
        {
            base.LoadBackgrounds();
             
            this.categoriesDropDown.DataSource = this.SchedulerData.GetBackgroundStorage();
            this.categoriesDropDown.DisplayMember = "DisplayName";
            this.categoriesDropDown.ValueMember = "Id";
        }

        private void CategoriesDropDown_VisualListItemFormatting(object sender, VisualItemFormattingEventArgs args)
        {
            RadCheckedListVisualItem visualItem = args.VisualItem as RadCheckedListVisualItem;
            RadCheckBoxElement checkBox = visualItem.CheckBox as RadCheckBoxElement;
            checkBox.CheckMarkPrimitive.Border.Visibility = ElementVisibility.Hidden;
            checkBox.CheckMarkPrimitive.Fill.GradientStyle = GradientStyles.Solid;
            checkBox.CheckMarkPrimitive.Fill.BackColor =  GetBackgroundById((int)(args.VisualItem.Data.Value));
            checkBox.CheckMarkPrimitive.ForeColor= GetForeColor(checkBox.CheckMarkPrimitive.Fill.BackColor);
        }

        private void CategoriesDropDown_TextBlockFormatting(object sender, TextBlockFormattingEventArgs e)
        {
            TokenizedTextBlockElement token = e.TextBlock as TokenizedTextBlockElement;
            if (token != null)
            { 
                token.DrawFill = true;
                token.GradientStyle = GradientStyles.Solid;
                token.BackColor = GetBackgroundById((int)((RadCheckedListDataItem)token.Item.Value).Value);
                token.ForeColor = GetForeColor(token.BackColor);
            }
        }

        public virtual Color GetForeColor(Color backColor)
        {
            Color textColor;
            double brightness = (0.299 * backColor.R + 0.587 * backColor.G + 0.114 * backColor.B) / 255;



            if (brightness > 0.5)
            {
                textColor = Color.Black;
            }
            else
            {
                textColor = Color.White;
            }



            return textColor;
        }

        private Color GetBackgroundById(int categoryId)
        {
            RadScheduler scheduler = this.SchedulerData as RadScheduler;
            foreach (AppointmentBackgroundInfo bc in scheduler.Backgrounds)
            {
               
                if (bc.Id == categoryId)
                {
                    if (scheduler.UseModernAppointmentStyles)
                    {
                        return bc.BackColor;
                    }
                    return bc.BackColor2;
                }
            }
            return Color.Red;
        }

        private Image CreateImageByBackgroundInfo(IAppointmentBackgroundInfo backgroundInfo)
        {
            Size defaultImageSize = new Size(11, 11);
            Bitmap image = new Bitmap(defaultImageSize.Width, defaultImageSize.Height);
            Graphics graphics = Graphics.FromImage(image);

            Rectangle rect = new Rectangle(Point.Empty, defaultImageSize);
            rect.Inflate(-1, -1);
            using (GraphicsPath path = (new RoundRectShape(1)).CreatePath(rect))
            {
                if (backgroundInfo.BackColor2 != Color.Empty)
                {
                    using (LinearGradientBrush gradientBrush = new LinearGradientBrush(rect,
                                                                                   backgroundInfo.BackColor,
                                                                                   backgroundInfo.BackColor2,
                                                                                   backgroundInfo.GradientAngle))
                    {
                        graphics.FillPath(gradientBrush, path);
                    }
                }
                else
                {
                    using (SolidBrush solidBrush = new SolidBrush(backgroundInfo.BackColor))
                    {
                        graphics.FillPath(solidBrush, path);
                    }
                }


                using (Pen pen = new Pen(backgroundInfo.BorderColor))
                {
                    graphics.DrawPath(pen, path);
                }
            }

            return image;
        }
    }
}
