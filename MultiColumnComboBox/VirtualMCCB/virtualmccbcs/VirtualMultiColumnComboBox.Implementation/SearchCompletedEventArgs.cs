namespace VirtualMultiColumnComboBox.Implementation
{
    public class SearchCompletedEventArgs : System.EventArgs
    {
        public string Text { get; private set; }
        public System.Collections.Generic.IEnumerable<string> Results {get; private set;}

        public SearchCompletedEventArgs(string text, System.Collections.Generic.IEnumerable<string> results)
        {
            this.Text = text;
            this.Results = results;
        }
    }
}
