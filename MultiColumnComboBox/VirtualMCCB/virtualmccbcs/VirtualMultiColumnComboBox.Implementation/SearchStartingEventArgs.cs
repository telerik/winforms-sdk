namespace VirtualMultiColumnComboBox.Implementation
{
    public class SearchStartingEventArgs : System.ComponentModel.CancelEventArgs
    {
        public string Text { get; private set; }

        public SearchStartingEventArgs(string text)
        {
            this.Text = text;
        }
    }
}
