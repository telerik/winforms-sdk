using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;
using System.Collections.ObjectModel;

namespace RadTreeView_ReadOnly_CS
{
    class RadReadOnlyTreeView : RadTreeView
    {

        private bool m_ReadOnly = false;

        public RadReadOnlyTreeView()
        {
            base.NodeFormatting +=new TreeNodeFormattingEventHandler(RadReadOnlyTreeView_NodeFormatting);
        }

        public override string ThemeClassName  
        { 
            get 
            {  
                return typeof(RadTreeView).FullName;  
            }  
        }  

        void RadReadOnlyTreeView_NodeFormatting(object sender, TreeNodeFormattingEventArgs e)
        {
            if (base.CheckBoxes)
            {
                if (m_ReadOnly)
                {
                    ((RadCheckBoxElement)e.NodeElement.Children[2]).Enabled = false;
                }
                else
                {
                    ((RadCheckBoxElement)e.NodeElement.Children[2]).Enabled = true;
                }
            }
        }

        [System.ComponentModel.Browsable(true)] 
        [System.ComponentModel.DefaultValue(false)] 
        [System.ComponentModel.Category("Behavior")]
        [System.ComponentModel.Description("If the tree view has checkboxes, then allows the treeview checkboxes to be read only")]
        public bool CheckBoxReadOnly
        {
            get
            {
                return m_ReadOnly;
            }
            set
            {
                m_ReadOnly = value;
            }
        }

    }
}

