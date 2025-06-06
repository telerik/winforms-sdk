using System.Drawing;
using System;
using Telerik.WinControls;
using Telerik.WinControls.UI.Gauges;
using System.Windows.Forms;

namespace Telerik.Gauges.PUG
{
    public partial class MainForm : Telerik.WinControls.UI.RadToolbarForm
    {
        Timer timer = new Timer();

        public float supplyDebit = 0;

        public float tankValue = 0;
        public float flowMeterValue = 0;

        public MainForm()
        {
            InitializeComponent();

            this.supplyDebit = (float)this.supplySpinEditor.Value;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.timer.Interval = 125;
            this.timer.Tick += timer_Tick;
            this.timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.UpdateSupplyPipe();
            this.UpdateTank1(this.supplyDebit);
            this.UpdateFlowMeter1(this.supplyDebit);
        }

        private void UpdateSupplyPipe()
        {
            this.pipeIn1.BackColor = (supplyDebit > 0) ? Color.FromArgb(77, 110, 163) : Color.DarkGray;
            this.pipeIn2.BackColor = (supplyDebit > 0) ? Color.FromArgb(77, 110, 163) : Color.DarkGray;
        }

        private void UpdateTank1(float _value)
        {
            float currentTankValue = this.tank.Value;
            this.tankValue = (this.tankValue > 100) ? 100 : this.tankValue + _value;

            AnimatedPropertySetting setting = new AnimatedPropertySetting(
                                                                 RadLinearGaugeElement.ValueProperty,
                                                                 currentTankValue,
                                                                 tankValue,
                                                                 15,
                                                                 20);

            setting.ApplyEasingType = RadEasingType.Default; //InOutSine
            setting.ApplyValue(tank.GaugeElement);
        }

        private void UpdateFlowMeter1(float _value)
        {
            if (this.tank.Value >= 75)
            {
                UpdateTank1(-10);
                float currentFlowMeterValue = this.flowMeter1.Value;
                this.flowMeterValue = 10 + (this.tankValue - 75);

                this.RedrawFlowMeter1(currentFlowMeterValue, this.flowMeterValue);
            }
            else if (this.flowMeter1.Value > 0)
            {
                this.flowMeterValue = this.flowMeter1.Value;

                this.RedrawFlowMeter1(flowMeterValue, (float)0);
            }

            this.UpdateFlowMeterInPipe();
            this.UpdateFlowMeterOutPipe();
        }

        private void RedrawFlowMeter1(float _currentPosition, float _targetPosition)
        {
            AnimatedPropertySetting setting = new AnimatedPropertySetting(
                                                     RadRadialGaugeElement.ValueProperty,
                                                     _currentPosition,
                                                     _targetPosition,
                                                     15,
                                                     20);

            setting.ApplyEasingType = RadEasingType.InOutSine; //InOutSine
            setting.ApplyValue(flowMeter1.GaugeElement);
        }

        private void UpdateFlowMeterInPipe()
        {
            this.pipeTank1Out.BackColor = (tank.Value >= 75) ? Color.FromArgb(77, 110, 163) : Color.DarkGray;
        }

        private void UpdateFlowMeterOutPipe()
        {
            this.pipeOut1.BackColor = (flowMeterValue > 0.1) ? Color.FromArgb(77, 110, 163) : Color.DarkGray;
            this.pipeOut2.BackColor = (flowMeterValue > 0.1) ? Color.FromArgb(77, 110, 163) : Color.DarkGray;
        }

        private void supplySpinEditor_ValueChanged(object sender, EventArgs e)
        {
            if (sender != null)
                supplyDebit = (float)supplySpinEditor.Value;
        }

        #region Theming

        private void menuItemSystem_Click(object sender, System.EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName =
                WindowsSettings.CurrentWindowsTheme == WindowsTheme.Light ?
                                                        "Windows11" : "Windows11Dark";
            this.radDropDownButtonElement1.Text = "System";
        }

        private void menuItemLight_Click(object sender, System.EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Windows11";
            this.radDropDownButtonElement1.Text = "Light";
        }

        private void menuItemDark_Click(object sender, System.EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Windows11Dark";
            this.radDropDownButtonElement1.Text = "Dark";
        }

        #endregion
    }
}
