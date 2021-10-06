using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.TaskBoard;

namespace TaskBoardEditDialog
{
    public partial class TaskCardEditDialog : Telerik.WinControls.UI.RadForm
    {
        private RadTaskCardElement taskCardToEdit; 
        private RadTaskBoard taskBoard;
        private Size imageSize = new Size(16, 16);
        private BindingList<string> teams = new BindingList<string>() { "WinForms", "WPF", "Reporting", "Blazor", "DocumentProcessing" };

        private TaskCardEditDialog()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;

            this.Text = "Edit Card";
        }

        public TaskCardEditDialog(RadTaskCardElement defaultTaskCard, RadTaskBoard taskBoardControl) : this()
        { 
            this.taskCardToEdit = defaultTaskCard;
            this.taskBoard = taskBoardControl; 

            this.usersCheckedDropDownList.DataSource = this.taskBoard.Users;
            this.usersCheckedDropDownList.ValueMember = "Initials";

            this.usersCheckedDropDownList.CheckedDropDownListElement.ItemHeight = 26;
            this.usersCheckedDropDownList.CheckedDropDownListElement.AutoCompleteEditableAreaElement.AutoCompleteTextBox.CreateTextBlock += AutoCompleteTextBox_CreateTextBlock;
            this.usersCheckedDropDownList.CheckedDropDownListElement.AutoCompleteEditableAreaElement.AutoCompleteTextBox.TextBlockFormatting += AutoCompleteTextBox_TextBlockFormatting;
            this.usersCheckedDropDownList.VisualListItemFormatting += usersCheckedDropDownList_VisualListItemFormatting;

            this.tagsAutoCompleteBox.AutoCompleteDataSource = teams;
            LoadSettings(this.taskCardToEdit);
        }

        private void LoadSettings(RadTaskCardElement taskCard)
        {
            this.titleTextBox.Text = taskCard.TitleText;
            this.descriptionTextBox.Text = taskCard.DescriptionText;
            foreach (UserInfo user in taskCard.Users)
            { 
                RadCheckedListDataItem item = this.usersCheckedDropDownList.Items.FirstOrDefault(x => x.Value.Equals(user.Initials)) as RadCheckedListDataItem;
                item.Checked = true;      
            }
            foreach (RadTaskCardTagElement tag in taskCard.TagElements)
            {
                this.tagsAutoCompleteBox.Text += tag.Text + ";";
            }
        }

        private void AutoCompleteTextBox_TextBlockFormatting(object sender, TextBlockFormattingEventArgs e)
        {
            ImageTokenizedTextBlockElement imageToken = e.TextBlock as ImageTokenizedTextBlockElement;
            if (imageToken != null)
            {
                RadCheckedListDataItem dataItem = imageToken.Item.Value as RadCheckedListDataItem;
                if (dataItem != null)
                {
                    UserInfo user = dataItem.DataBoundItem as UserInfo;
                    if (user != null)
                    {
                        imageToken.Image.Image = ResizeImage(user.Avatar, imageSize); 
                    }
                }
            }
        }

        private void AutoCompleteTextBox_CreateTextBlock(object sender, CreateTextBlockEventArgs e)
        {
            if (e.TextBlock is TokenizedTextBlockElement)
            {
                e.TextBlock = new ImageTokenizedTextBlockElement();
            }
        }

        private void usersCheckedDropDownList_VisualListItemFormatting(object sender, VisualItemFormattingEventArgs args)
        {
            UserInfo user = args.VisualItem.Data.DataBoundItem as UserInfo;
            if (user != null)
            {
                RadCheckedListVisualItem visualItem = args.VisualItem as RadCheckedListVisualItem;
                visualItem.CheckBox.Text = user.FirstName + " " + user.LastName;
                visualItem.CheckBox.Image = user.Avatar;
                visualItem.CheckBox.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

        private void radButtonOK_Click(object sender, EventArgs e)
        {
            this.taskCardToEdit.TitleText = this.titleTextBox.Text;
            this.taskCardToEdit.DescriptionText = this.descriptionTextBox.Text;
            this.taskCardToEdit.Users.Clear();
            foreach (RadCheckedListDataItem checkedUser in this.usersCheckedDropDownList.CheckedItems)
            {
                this.taskCardToEdit.Users.Add(checkedUser.DataBoundItem as UserInfo);
            }
            this.taskCardToEdit.TagElements.Clear();
            foreach (RadTokenizedTextItem token in this.tagsAutoCompleteBox.Items)
            {
                RadTaskCardTagElement tag = new RadTaskCardTagElement();
                tag.Text = token.Text;
                this.taskCardToEdit.TagElements.Add(tag);
            }
        }

        public class ImageTokenizedTextBlockElement : TokenizedTextBlockElement
        {
            private ImagePrimitive image;

            public ImagePrimitive Image
            {
                get
                {
                    return this.image;
                }
            }

            protected override void CreateChildElements()
            {
                base.CreateChildElements();
                this.image = new ImagePrimitive();
                this.image.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.image.StretchVertically = false;
                this.image.StretchHorizontally = false;
                this.image.MaxSize = new Size(0, 20);
                this.Children.Insert(0, this.image);
            }

            protected override RadTokenizedTextItem CreateTokenizedTextItem(string text, object value)
            {
                RadTokenizedTextItem item = base.CreateTokenizedTextItem(text, value);
                return item;
            }

            protected override Type ThemeEffectiveType
            {
                get
                {
                    return typeof(TokenizedTextBlockElement);
                }
            }
        }

        public static Bitmap ResizeImage(Image image, Size s)
        {
            int width = s.Width;
            int height = s.Height;
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}