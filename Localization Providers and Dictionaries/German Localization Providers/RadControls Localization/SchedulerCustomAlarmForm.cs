using System.Drawing;
using Telerik.WinControls.UI;

namespace GermanRadControlsLocalization
{
    public partial class SchedulerCustomAlarmForm : RadAlarmForm
    {
        public SchedulerCustomAlarmForm( )
        {
            InitializeComponent( );

            this.radGridViewEvents.Size = new Size( 550 , 200 );

            this.radGridViewEvents.Columns[ 2 ].MinWidth = 200;
            this.radGridViewEvents.Columns[ 2 ].MaxWidth = 200;
            this.radGridViewEvents.Columns[ 2 ].Width = 200;
        }

    }
}
