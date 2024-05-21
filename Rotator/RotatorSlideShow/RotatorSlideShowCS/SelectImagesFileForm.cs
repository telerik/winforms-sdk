using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Telerik.WinControls;
using Telerik.WinControls.Themes.Serialization;
using Telerik.WinControls.UI;

namespace RotatorSlideShow
{
    public partial class SelectImagesFileForm : RadForm
    {
        private bool isdirty = false;
        private string path = string.Empty;
        private bool exists;
        private RadRotator radRotator;

        public SelectImagesFileForm()
        {
            InitializeComponent();
        }

        public RadRotator RadRotator
        {
            get { return radRotator; }
            set { radRotator = value; }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = string.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                int index = radListControl1.SelectedIndex;
                for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                {
                    radListControl1.Items.Add(openFileDialog.FileNames[i]);
                    isdirty = true;
                }
                radListControl1.SelectedIndex = index > -1 ? index : 0;
                radListControl1.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (radListControl1.SelectedItem != null)
            {
                radListControl1.Items.Remove(radListControl1.SelectedItem);
                isdirty = true;
            }
        }

        private void btnMoveTop_Click(object sender, EventArgs e)
        {
            RadListDataItem item = radListControl1.SelectedItem;
            radListControl1.Items.Remove(item);
            radListControl1.Items.Insert(0, item);
            radListControl1.SelectedIndex = 0;
            isdirty = true;
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            int index = radListControl1.SelectedIndex - 1;
            if (index >= 0)
            {
                RadListDataItem item = radListControl1.SelectedItem;
                radListControl1.Items.Remove(item);
                radListControl1.Items.Insert(index, item);
                radListControl1.SelectedIndex = index;
                isdirty = true;
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            int index = radListControl1.SelectedIndex + 1;
            if (index <= radListControl1.Items.Count - 1)
            {
                RadListDataItem item = radListControl1.SelectedItem;
                radListControl1.Items.Remove(item);
                radListControl1.Items.Insert(index, item);
                radListControl1.SelectedIndex = index;
                isdirty = true;
            }
        }

        private void btnMoveBottom_Click(object sender, EventArgs e)
        {
            RadListDataItem item = radListControl1.SelectedItem;
            radListControl1.Items.Remove(item);
            radListControl1.Items.Add(item);
            radListControl1.SelectedIndex = radListControl1.Items.Count - 1;
            isdirty = true;
        }

        private void SelectImagesFileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isdirty)
            {
                DialogResult result = MessageBox.Show(" Files has been modified. Do you want to save?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string pathtosave = path;
                    if (!exists)
                    {
                        saveFileDialog1.FileName = string.Empty;
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            pathtosave = saveFileDialog1.FileName;
                        }
                        else
                        {
                            e.Cancel = true;
                            return;
                        }
                    }
                    SaveFile(pathtosave);
                }

                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        public void SaveFile(string path)
        {
            StyleXmlSerializer serializer = new StyleXmlSerializer(false);

            using (XmlTextWriter xmlWriter = new XmlTextWriter(path, Encoding.UTF8))
            {
                xmlWriter.Formatting = Formatting.Indented;
                xmlWriter.WriteStartElement("SlideShow");
                serializer.WriteObjectElement(xmlWriter, this.GetImages());
            }
            isdirty = false;
        }

        private RotatorSlideShowFile GetImages()
        {
            RotatorSlideShowFile images = new RotatorSlideShowFile();
            for (int i = 0; i < radListControl1.Items.Count; i++)
            {
                RadImageItem item = new RadImageItem();
                item.Image = new Bitmap(Image.FromFile(radListControl1.Items[i].ToString()));
                images.Files.Add(item);
            }
            return images;
        }

        private void radListControl1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Image temp = null;
            if (radListControl1.SelectedItem != null)
            {
                temp = Image.FromFile(radListControl1.SelectedItem.Text);
                previewBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }

            previewBox.Image = temp;
            radListControl1.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string pathtosave = path;
            if (!exists)
            {
                saveFileDialog1.FileName = string.Empty;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pathtosave = saveFileDialog1.FileName;
                    SaveFile(pathtosave);
                }
            }
        }
    }
}