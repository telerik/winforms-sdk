using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
    public partial class Form1 : RadForm
    {
        private bool running = false;
        private string[] args;

        public Form1(string[] args)
        {
            InitializeComponent();
            this.args = args;
        }

        public RadRotator RadRotator
        {
            get
            {
                return this.radRotator1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radRotator1.Running = false;
            if (args.Length != 0)
            {
                OpenDocument(args[0]);
            }
            SetLocationAnimation("0,-1");
        }

        SelectImagesFileForm selectImagesFileForm = new SelectImagesFileForm();

        private void btnCreateSlideShow_Click(object sender, EventArgs e)
        {
            selectImagesFileForm.RadRotator = this.radRotator1;
            selectImagesFileForm.ShowDialog();
        }

        private void btnLoadSlideShow_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenDocument(openFileDialog1.FileName);
            }
        }

        public bool OpenDocument(string path)
        {
            this.Text = path;
            if (File.Exists(path))
            {
                try
                {
                    StyleXmlSerializer ser = new StyleXmlSerializer();
                    using (StreamReader reader = new StreamReader(path))
                    {
                        using (XmlTextReader textReader = new XmlTextReader(reader))
                        {
                            textReader.Read();
                            RotatorSlideShowFile list = new RotatorSlideShowFile();
                            ser.ReadObjectElement(textReader, list);
                            BuildRotatorItems(list.Files);
                        }
                    }
                }
                catch (SerializationException)
                {
                    MessageBox.Show("The file can not be opened", "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    this.Text = path;
                }
                return true;
            }
            return false;
        }

        private void BuildRotatorItems(ArrayList images)
        {
            this.radRotator1.Stop();
            this.radRotator1.Items.Clear();
            foreach (RadImageItem image in images)
            {
                image.Alignment = ContentAlignment.MiddleCenter;
                RadItemsContainer radItemsContainer = new RadItemsContainer();
                radItemsContainer.Items.Add(image);
                radItemsContainer.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                radItemsContainer.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
                this.radRotator1.Items.Add(radItemsContainer);
            }
            this.radRotator1.Start();
            this.btnStart.Text = "Stop";
            this.running = true;
        }

        private void btnStepBack_Click(object sender, EventArgs e)
        {
            this.radRotator1.Previous();
        }

        private void btnStepForward_Click(object sender, EventArgs e)
        {
            this.radRotator1.Next();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this.running)
            {
                this.btnStart.Text = "Start";
                this.radRotator1.Stop();
                this.running = false;
            }
            else
            {
                this.btnStart.Text = "Stop";
                if (this.radRotator1.Items.Count == 0)
                {
                    openFileDialog1.FileName = "";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        OpenDocument(openFileDialog1.FileName);
                    }
                }
                this.radRotator1.Start();
                this.running = true;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string newFramesValue = SetFramesInterval(tbInterval.Text);
            string newLocationValue = SetLocationAnimation(tbLocationAnimation.Text);

            if (newFramesValue != null)
                this.tbInterval.Text = newFramesValue;

            if (newLocationValue != null)
                this.tbLocationAnimation.Text = newLocationValue;
        }

        private string SetFramesInterval(string value)
        {
            int interval = 0;

            try
            {
                interval = Convert.ToInt32(value);
            }
            catch (Exception)
            {
                return "500";
            }

            string result = null;

            if (interval < 500)
            {
                result = "500";
                interval = 500;
            }

            radRotator1.Interval = interval;

            return result;
        }

        private string SetLocationAnimation(string value)
        {
            string[] values = value.Split(',');

            if (values.Length != 2)
                return SizeFToString(radRotator1.LocationAnimation);

            SizeF newValue = new SizeF(0, 0);

            try
            {
                newValue.Width = float.Parse(values[0], CultureInfo.InvariantCulture);
                newValue.Height = float.Parse(values[1], CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                return SizeFToString(radRotator1.LocationAnimation);
            }

            radRotator1.LocationAnimation = newValue;

            return null;
        }

        private string SizeFToString(SizeF value)
        {
            return string.Format("{0}, {1}", value.Width, value.Height);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}