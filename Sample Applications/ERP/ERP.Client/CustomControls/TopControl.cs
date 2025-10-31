using ERP.Client.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;

namespace ERP.Client
{
    public partial class TopControl : UserControl
    {
        private Dictionary<string, bool> loadedThemes = new Dictionary<string, bool>();

        public RadLabel ViewLabel { get { return this.viewLabel; } }

        public TopControl()
        {
            this.InitializeComponent();

            new FluentTheme();
            new CrystalTheme();
            new VisualStudio2012DarkTheme();

            this.InitializeThemesDropDown();
        }

        private void InitializeThemesDropDown()
        {
            this.AddThemeItemToThemesDropDownList("Crystal", Resources.fluent);
            this.AddThemeItemToThemesDropDownList("Fluent", Resources.fluent);
            this.AddThemeItemToThemesDropDownList("FluentDark", Resources.fluent_dark);
            this.AddThemeItemToThemesDropDownList("Material", Resources.material);
            this.AddThemeItemToThemesDropDownList("MaterialPink", Resources.material_pink);
            this.AddThemeItemToThemesDropDownList("MaterialTeal", Resources.material_teal);
            this.AddThemeItemToThemesDropDownList("MaterialBlueGrey",Resources.material_blue_grey);
            this.AddThemeItemToThemesDropDownList("ControlDefault",Resources.control_default);
            this.AddThemeItemToThemesDropDownList("TelerikMetro", Resources.telerik_metro);
            this.AddThemeItemToThemesDropDownList("Windows8", Resources.windows8);

            this.loadedThemes.Add("ControlDefault", true);
            this.loadedThemes.Add("Crystal", true);

            this.chooseThemeDropDown.Text = "Crystal";
            ThemeResolutionService.ApplicationThemeName = "Crystal";
            this.chooseThemeDropDown.SelectedIndexChanged += this.ChooseThemeDropDown_SelectedIndexChanged;
            this.chooseThemeDropDown.DropDownStyle = RadDropDownStyle.DropDownList;


        }

        private void ChooseThemeDropDown_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            var assemblyName = "Telerik.WinControls.Themes." + this.chooseThemeDropDown.SelectedItem.Text + ".dll";
            var themeName = this.chooseThemeDropDown.SelectedItem.Text;
            var strTempAssmbPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), assemblyName );
            if (!System.IO.File.Exists(strTempAssmbPath)) // we are in the case of QSF as exe, so the Path is different
            {
                strTempAssmbPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "..\\..\\..\\..\\Bin40");
                strTempAssmbPath = System.IO.Path.Combine(strTempAssmbPath, assemblyName);

                if (!System.IO.File.Exists(strTempAssmbPath))
                {
                    strTempAssmbPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "..\\..\\..\\..\\bin\\Release");
                    strTempAssmbPath = System.IO.Path.Combine(strTempAssmbPath, assemblyName);
                }
            }

            if (!this.loadedThemes.ContainsKey(themeName))
            {

                Assembly themeAssembly = Assembly.LoadFrom(strTempAssmbPath);
                Activator.CreateInstance(themeAssembly.GetType("Telerik.WinControls.Themes." + themeName + "Theme"));

                this.loadedThemes.Add(themeName, true);
            }

            ThemeResolutionService.ApplicationThemeName = themeName;
        }

        private void AddThemeItemToThemesDropDownList(string themeName, Image image)
        {
            RadListDataItem themeItem = new RadListDataItem();
            themeItem.Text = themeName;
            themeItem.Image = image;
            this.chooseThemeDropDown.Items.Add(themeItem);
        }
    }
}
