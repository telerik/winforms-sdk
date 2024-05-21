
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Telerik.WinControls.UI;


namespace LoadOnDemand
{
    /// <summary>
    /// Expansion to create a Load on Demand RadDropDownListEditor in a GridViewComboBoxColumn.
    /// This editor should replace the default editor by replacing it in RadGridview1_EditorRequired event.
    /// </summary>
    /// <remarks></remarks>
    public class LoadOnDemandRadDropDownListEditor : RadDropDownListEditor
    {


        /// <summary>
        /// KeyCodes which fire the KeyUp and keyDown event
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public List<Keys> HandleKeyCodes
        {
            get { return _handleKeyCodes; }
            set { _handleKeyCodes = value; }
        }

        private List<Keys> _handleKeyCodes = new List<Keys>();

        /// <summary>
        /// KeyValues which fire the KeyUp and keyDown event 
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public List<int> HandleKeyValues
        {
            get { return _handleKeyValues; }
            set { _handleKeyValues = value; }
        }

        private List<int> _handleKeyValues = new List<int>();

        /// <summary>
        /// Enter key ends edit mode
        /// </summary>
        /// <value></value>
        /// <remarks>Default true</remarks>
        public bool ConfirmOnEnter
        {
            set { _confirmOnEnter = value; }
        }

        private bool _confirmOnEnter = true;

        /// <summary>
        /// Event after a key is released
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        public event KeyUpEventHandler KeyUp;
        public delegate void KeyUpEventHandler(object sender, LoadOnDemandRadDropDownListEditorEventargs e);

        /// <summary>
        /// Event when a key is hit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        public event KeyDownEventHandler KeyDown;
        public delegate void KeyDownEventHandler(object sender, LoadOnDemandRadDropDownListEditorEventargs e);

        /// <summary>
        /// Bubble up the selected index changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        public event SelectedIndexChangedEventHandler SelectedIndexChanged;
        public delegate void SelectedIndexChangedEventHandler(object sender, LoadOnDemandRadDropDownListEditorEventargs e);

        /// <summary>
        /// Bubble up the selected index changing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        public event SelectedIndexChangingEventHandler SelectedIndexChanging;
        public delegate void SelectedIndexChangingEventHandler(object sender, LoadOnDemandRadDropDownListEditorEventargs e);


        /// <summary>
        /// Set the display memeber of the editor element
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string DisplayMember
        {
            get { return ((RadDropDownListEditorElement)this.EditorElement).DisplayMember; }
            set { ((RadDropDownListEditorElement)this.EditorElement).DisplayMember = value; }
        }

        /// <summary>
        /// Set the display memeber of the editor element
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string Valuemember
        {
            get { return ((RadDropDownListEditorElement)this.EditorElement).ValueMember; }
            set { ((RadDropDownListEditorElement)this.EditorElement).ValueMember = value; }
        }




        /// <summary>
        /// Initialize the handled keys (a-z / 0-9)
        /// </summary>
        /// <remarks></remarks>
        public LoadOnDemandRadDropDownListEditor()
        {
            //char A to Z
            for (Keys handledKeyCode = Keys.A; handledKeyCode <= Keys.Z + 1; handledKeyCode++)
            {
                _handleKeyCodes.Add(handledKeyCode);
            }
            //Numbers 0 to 9
            for (int handledKeyValue = 48; handledKeyValue <= 58; handledKeyValue++)
            {
                _handleKeyValues.Add(handledKeyValue);
            }

            ((RadDropDownListEditorElement)this.EditorElement).SelectedIndexChanged += RaiseSelectedIndexChanged;
            ((RadDropDownListEditorElement)this.EditorElement).SelectedIndexChanging += RaiseSelectedIndexChanging;

        }


        /// <summary>
        /// Overrides the default OnKeyUp van de RadDropDownListEditor
        /// Raises KeyUp event when the entered key is in the keyCode or keyValue collection
        /// </summary>
        /// <param name="e"></param>
        /// <remarks></remarks>

        public override void OnKeyUp(System.Windows.Forms.KeyEventArgs e)
        {
            if (_handleKeyCodes.Contains(e.KeyCode) || _handleKeyValues.Contains(e.KeyValue))
            {
                RadDropDownListEditorElement ddl = (RadDropDownListEditorElement)this.EditorElement;
                if (KeyUp != null)
                {
                    KeyUp(this, new LoadOnDemandRadDropDownListEditorEventargs
                    {
                        KeyEventArgs = e,
                        RadDropDownListEditorElement = ddl
                    });
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (_confirmOnEnter && e.KeyCode.Equals(Keys.Enter))
                base.OnKeyUp(e);
        }

        /// <summary>
        /// Overrides the default OnKeyDown van de RadDropDownListEditor
        /// Raises KeyDown event. 
        /// </summary>
        /// <param name="e"></param>
        /// <remarks></remarks>
        public override void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
        {
            RadDropDownListEditorElement ddl = (RadDropDownListEditorElement)this.EditorElement;
            if (KeyDown != null)
            {
                KeyDown(this, new LoadOnDemandRadDropDownListEditorEventargs
                {
                    KeyEventArgs = e,
                    RadDropDownListEditorElement = ddl
                });
            }
            if (_confirmOnEnter && e.KeyCode.Equals(Keys.Enter))
                base.OnKeyDown(e);
        }


        private void RaiseSelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (SelectedIndexChanged != null)
            {
                SelectedIndexChanged(this, new LoadOnDemandRadDropDownListEditorEventargs
                {
                    RadDropDownListEditorElement = (RadDropDownListEditorElement)this.EditorElement,
                    PositionChangedEventArgs = e
                });
            }
        }

        private void RaiseSelectedIndexChanging(object sender, Telerik.WinControls.UI.Data.PositionChangingCancelEventArgs e)
        {
            if (SelectedIndexChanged != null)
            {
                SelectedIndexChanged(this, new LoadOnDemandRadDropDownListEditorEventargs
                {
                    RadDropDownListEditorElement = (RadDropDownListEditorElement)this.EditorElement,
                    PositionChangingCancelEventArgs = e
                });
            }
        }



    }

    /// <summary>
    /// Custom event argument for <see cref="LoadOnDemandRadDropDownListEditor" /><br/>
    /// Contains the editor element (RadDropDownListEditorElement) and the KeyEventArgs  
    /// </summary>
    /// <remarks></remarks>
    public class LoadOnDemandRadDropDownListEditorEventargs : EventArgs
    {


        public RadDropDownListEditorElement RadDropDownListEditorElement;

        public KeyEventArgs KeyEventArgs;

        public Telerik.WinControls.UI.Data.PositionChangedEventArgs PositionChangedEventArgs;

        public Telerik.WinControls.UI.Data.PositionChangingCancelEventArgs PositionChangingCancelEventArgs;
    }
}
//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik, @toddanglin
//Facebook: facebook.com/telerik
//=======================================================
