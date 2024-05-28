#region "Imports"

using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

#endregion "Imports"

[Designer(typeof(RadGridViewSmartTagsControlDesigner))]
public class RadGridViewSmartTags : Telerik.WinControls.UI.RadGridView
{
    private bool m_MyContextMenuEnabled;

    private bool m_MyContextMenuVisible = true;
    [Category("Context Menus")]
    [Browsable(true)]
    [Description("Occurs when the sample context menu item is clicked")]
    public event EventHandler<EventArgs> SampleContextMenu_Clicked;

    #region "Constructor"

    /// <summary>Initializes a new instance of the GridView class.</summary>
    /// <remarks></remarks>
    public RadGridViewSmartTags()
    {
        this.ThemeClassName = "Telerik.WinControls.UI.RadGridView";
    }

    #endregion "Constructor"

    #region " Public Properties "

    #region "ThemeName"

    /// <summary>Theme Name</summary>
    /// <value>The name of the theme</value>
    /// <returns>Theme name as string</returns>
    /// <remarks>Ensures the Theme name cannot be changed in the designer</remarks>
    [ReadOnly(true)]
    public string ThemeName
    {
        get { return base.ThemeName; }
    }

    #endregion "ThemeName"

    #region "AllowColumnChooser"

    [Browsable(true)]
    [Category("Columns")]
    [DefaultValue(true)]
    public bool AllowColumnChooser
    {
        get { return this.MasterTemplate.AllowColumnChooser; }
        set { this.MasterTemplate.AllowColumnChooser = value; }
    }

    #endregion "AllowColumnChooser"

    #region "MyContextMenuEnabled"

    [Browsable(true)]
    [Category("Context Menus")]
    public bool MyContextMenuEnabled
    {
        get { return m_MyContextMenuEnabled; }
        set { m_MyContextMenuEnabled = value; }
    }

    #endregion "MyContextMenuEnabled"

    #region "MyContextMenuVisible"

    [Browsable(true)]
    [Category("Context Menus")]
    public bool MyContextMenuVisible
    {
        get { return m_MyContextMenuVisible; }
        set { m_MyContextMenuVisible = value; }
    }

    #endregion "MyContextMenuVisible"

    #endregion " Public Properties "

    #region "GridView_ContextMenuOpening"

    /// <summary>Grid View Context Menu Opening Event Handler.</summary>
    /// <param name="sender">The event source</param>
    /// <param name="e">The event arguments.</param>
    /// <remarks></remarks>

    private void  // ERROR: Handles clauses are not supported in C#
GridView_ContextMenuOpening(System.Object sender, ContextMenuOpeningEventArgs e)
    {
        // if this is not the filter menu

        if (e.ContextMenuProvider is Telerik.WinControls.UI.GridDataCellElement && this.SelectedRows.Count > 0)
        {
            if (m_MyContextMenuVisible)
            {
                RadMenuItem contextMenuItemSample = new RadMenuItem();
                {
                    contextMenuItemSample.Text = "My Sample Context Menu";
                    contextMenuItemSample.ToolTipText = "Some tooltip";
                    contextMenuItemSample.Enabled = m_MyContextMenuEnabled;
                }
                e.ContextMenu.Items.Insert(0, contextMenuItemSample);
                contextMenuItemSample.Click += ContextMenuItemSample_Click;
            }
        }
    }

    #endregion "GridView_ContextMenuOpening"

    #region "ContextMenuItemSendToSample_Click"

    /// <summary>Send to Branches Context Menu Item Click Event Handler.</summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">The event arguments.</param>
    /// <remarks></remarks>

    private void ContextMenuItemSample_Click(System.Object sender, System.EventArgs e)
    {
        if (SampleContextMenu_Clicked != null)
        {
            SampleContextMenu_Clicked(this, new EventArgs());
        }
        this.Focus();
    }

    #endregion "ContextMenuItemSendToSample_Click"
}

#region " Smart Tag "

#region "GridView Control Designer Class"

public class RadGridViewSmartTagsControlDesigner : System.Windows.Forms.Design.ControlDesigner
{
    private DesignerActionListCollection lists;

    public override DesignerActionListCollection ActionLists
    {
        get
        {
            if (lists == null)
            {
                lists = new DesignerActionListCollection();
                lists.Add(new RadGridViewSmartTagsControlActionList(this.Component));
            }
            return lists;
        }
    }
}

#endregion "GridView Control Designer Class"

#region "GridView Control Action List Class"

[ComplexBindingProperties("DataSource", "DataMember")]
public class RadGridViewSmartTagsControlActionList : System.ComponentModel.Design.DesignerActionList
{
    #region " Variables "

    private RadGridViewSmartTags m_GridView;
    /// <summary>Reference to DesignerActionUIService</summary>
    /// <remarks></remarks>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields", Justification = "This field only requires an assigned value.")]

    private DesignerActionUIService m_DesignerActionSvc;

    #endregion " Variables "

    #region "Constructor"

    /// <summary>Initialises a new instance of the GridViewStandardControlActionList class.</summary>
    /// <param name="component"></param>
    /// <remarks></remarks>

    public RadGridViewSmartTagsControlActionList(IComponent component)
        : base(component)
    {
        this.m_GridView = (RadGridViewSmartTags)component;

        this.m_DesignerActionSvc = (DesignerActionUIService)GetService(typeof(DesignerActionUIService));
    }

    #endregion "Constructor"

    #region "GridView"

    /// <summary>Gets or sets the GridView.</summary>
    [CLSCompliant(false)]
    public RadGridViewSmartTags GridView
    {
        get { return m_GridView; }
        set { m_GridView = value; }
    }

    #endregion "GridView"

    #region "GetPropertyByName"

    /// <summary></summary>
    /// <param name="propName"></param>
    /// <returns></returns>
    /// <remarks></remarks>
    private PropertyDescriptor GetPropertyByName(string propName)
    {
        PropertyDescriptor prop = TypeDescriptor.GetProperties(m_GridView)[propName];

        if (prop == null)
        {
            throw new ArgumentException("Invalid property.", propName);
        }
        else
        {
            return prop;
        }
    }

    #endregion "GetPropertyByName"

    #region "Dock"

    public System.Windows.Forms.DockStyle Dock
    {
        get { return m_GridView.Dock; }
        set { GetPropertyByName("Dock").SetValue(m_GridView, value); }
    }

    #endregion "Dock"

    #region "AllowColumnChooser"

    public bool AllowColumnChooser
    {
        get { return m_GridView.AllowColumnChooser; }
        set { GetPropertyByName("AllowColumnChooser").SetValue(m_GridView, value); }
    }

    #endregion "AllowColumnChooser"

    #region "MyContextMenuEnabled"

    public bool MyContextMenuEnabled
    {
        get { return m_GridView.MyContextMenuEnabled; }
        set { GetPropertyByName("MyContextMenuEnabled").SetValue(m_GridView, value); }
    }

    #endregion "MyContextMenuEnabled"

    #region "MyContextMenuVisible"

    public bool MyContextMenuVisible
    {
        get { return m_GridView.MyContextMenuVisible; }
        set { GetPropertyByName("MyContextMenuVisible").SetValue(m_GridView, value); }
    }

    #endregion "MyContextMenuVisible"

    #region "DataSource"

    [RefreshProperties(RefreshProperties.Repaint)]
    [Editor("System.Windows.Forms.Design.DataSourceListEditor", "System.Drawing.Design.UITypeEditor")]
    public object DataSource
    {
        get { return m_GridView.DataSource; }
        set { GetPropertyByName("DataSource").SetValue(m_GridView, value); }
    }

    #endregion "DataSource"

    #region "DataMember"

    [Editor("System.Windows.Forms.Design.DataMemberListEditor", "System.Drawing.Design.UITypeEditor")]
    public string DataMember
    {
        get { return m_GridView.DataMember; }
        set { GetPropertyByName("DataMember").SetValue(m_GridView, value); }
    }

    #endregion "DataMember"

    #region "get Sorted Action Items"

    public override DesignerActionItemCollection GetSortedActionItems()
    {
        DesignerActionItemCollection items = new DesignerActionItemCollection();

        items.Add(new DesignerActionHeaderItem("Columns"));
        items.Add(new DesignerActionPropertyItem("AllowColumnChooser", "Allow Column Chooser", "Columns", "Determines if the column chooser is available"));

        items.Add(new DesignerActionHeaderItem("Context Menu"));
        items.Add(new DesignerActionPropertyItem("MyContextMenuEnabled", "My Menu Enabled", "Context Menus", "Determines if my context menu is enabled"));
        items.Add(new DesignerActionPropertyItem("MyContextMenuVisible", "My Menu Visible", "Context Menus", "Determines if my context menu is visible"));

        items.Add(new DesignerActionHeaderItem("Data"));
        items.Add(new DesignerActionPropertyItem("DataSource", "Data Source", "Data", "Sets the data source"));
        items.Add(new DesignerActionPropertyItem("DataMember", "Data Member", "Data", "Sets the data member"));

        items.Add(new DesignerActionHeaderItem("Layout"));
        items.Add(new DesignerActionPropertyItem("Dock", "Dock position", "Layout", "Determines the dock position"));

        items.Add(new DesignerActionHeaderItem("Advanced"));
        items.Add(new DesignerActionMethodItem(this, "OnLaunchBuilder", "Property Builder", "Advanced", "Launches the Telerik Property Builder", false));

        return items;
    }

    #endregion "get Sorted Action Items"

    #region "Launch Property Builder"

    /// <summary>
    /// This launches the property builder
    /// </summary>
    /// <remarks></remarks>

    public void OnLaunchBuilder()
    {
        IDesignerHost service = m_GridView.Site.GetService(typeof(IDesignerHost)) as IDesignerHost;
        DesignerTransaction transaction = service.CreateTransaction(string.Format(CultureInfo.InvariantCulture, "RadGridView{0}LaunchBuilderTransaction", ((RadGridView)m_GridView).Name));

        Telerik.WinControls.UI.Design.RadGridViewPropertyBuilder propertyBuilder = new Telerik.WinControls.UI.Design.RadGridViewPropertyBuilder((RadGridView)m_GridView);
        try
        {
            if (propertyBuilder.ShowDialog() == DialogResult.OK)
            {
                transaction.Commit();
                transaction = null;

                DesignerActionUIService actionUIService = m_GridView.Site.GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
                if (actionUIService != null)
                {
                    actionUIService.HideUI(m_GridView);
                }
            }
        }
        finally
        {
            if (transaction != null)
            {
                transaction.Cancel();
            }
        }
    }

    #endregion "Launch Property Builder"
}

#endregion "GridView Control Action List Class"

#endregion " Smart Tag "