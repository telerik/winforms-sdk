using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PreserveUserTextMessageHistory
{
    public partial class Form1 : RadForm
    {
        private BindingList<Author> authors = new BindingList<Author>();
        private Dictionary<Author, List<BaseChatDataItem>> chatHistory = new Dictionary<Author, List<BaseChatDataItem>>();
        private RadScrollBarElement scrollbar;
        private int messageCounter = 0;
        public Author Person { get; set; }
        public Form1()
        {
            InitializeComponent();  
            authors.Add(new Author(Properties.Resources.andrew45x45, "Andrew"));
            authors.Add(new Author(Properties.Resources.bob45x45, "Bob"));
            authors.Add(new Author(Properties.Resources.nancy45x45, "Nancy"));
            chatHistory.Add(authors[0], new List<BaseChatDataItem>());
            chatHistory.Add(authors[1], new List<BaseChatDataItem>());
            chatHistory.Add(authors[2], new List<BaseChatDataItem>());
            this.radListControl1.DataSource = authors;
            this.radListControl1.DisplayMember = "name";
            this.radListControl1.ValueMember = "name";
            this.radChat1.Author = new Author(Properties.Resources.architect, "Morpheus");
        }

        void radListControl1_CreatingVisualListItem(object sender, CreatingVisualListItemEventArgs args)
        {
            args.VisualItem = new CustomVisualItem();
        }

        private void RadListControl1_VisualItemFormatting(object sender, VisualItemFormattingEventArgs args)
        {
            args.VisualItem.ImageLayout = ImageLayout.Zoom;
        }

        private void RadListControl1_SelectedIndexChanging(object sender, Telerik.WinControls.UI.Data.PositionChangingCancelEventArgs e)
        {
            if (this.radListControl1.SelectedItem != null)
            {
                if (Person == null)
                {
                    Person = this.radListControl1.SelectedItem.DataBoundItem as Author;
                }

                List<BaseChatDataItem> currentHistory = new List<BaseChatDataItem>();

                for (int i = 0; i < radChat1.ChatElement.MessagesViewElement.Items.Count; i++)
                {
                    currentHistory.Add(radChat1.ChatElement.MessagesViewElement.Items[0]);
                }

                if (chatHistory[Person].Count < radChat1.ChatElement.MessagesViewElement.Items.Count)
                {
                    chatHistory[Person] = radChat1.ChatElement.MessagesViewElement.Items.ToList<BaseChatDataItem>();
                }

                (this.radListControl1.Items[e.Position].VisualItem as CustomVisualItem).MessageNotification = Telerik.WinControls.ElementVisibility.Hidden;
                radChat1.ChatElement.MessagesViewElement.Items.Clear();
            }
        }

        private void RadListControl1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Person = this.radListControl1.SelectedItem.DataBoundItem as Author;
            this.radChat1.ChatElement.MessagesViewElement.BeginUpdate();
            if (chatHistory.ContainsKey(Person))
            {
                List<BaseChatDataItem> newHistory = chatHistory[Person];
                for (int i = 0; i < newHistory.Count; i++)
                {
                    var addItem = newHistory[i] as BaseChatDataItem;
                    if (!(addItem is ChatTimeSeparatorDataItem))
                    {
                        if (addItem != null)
                        {
                            radChat1.ChatElement.MessagesViewElement.Items.Add(addItem);
                        }
                    }
                }
            }

            this.radChat1.ChatElement.MessagesViewElement.EndUpdate();
            ScrollToLastItem();
        }

        private void RadListControl1_ItemDataBound(object sender, ListItemDataBoundEventArgs args)
        {
            args.NewItem.Image = ((Author)args.NewItem.DataBoundItem).Avatar; ;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.radChat1.ChatElement.MessagesViewElement.BeginUpdate();
            int simulateChatMessageNumber = 1;
            for (int i = 0; i < simulateChatMessageNumber; i++)
            {
                Author currentAuthor = this.radListControl1.SelectedItem.DataBoundItem as Author;
                ChatTextMessage message1 = new ChatTextMessage(currentAuthor.Name + ":" + "Hello : " + messageCounter, currentAuthor, DateTime.Now);
                this.radChat1.AddMessage(message1);
                messageCounter++;
            }

            this.radChat1.ChatElement.MessagesViewElement.EndUpdate();
            ScrollToLastItem();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            if (this.radListControl1.SelectedItem != this.radListControl1.Items[1])
            {
                (this.radListControl1.Items[1].VisualItem as CustomVisualItem).MessageNotification = Telerik.WinControls.ElementVisibility.Visible;
                var bobUser = authors[1];
                var bobUserMessages = chatHistory[bobUser];
                bobUserMessages.Add(new TextMessageDataItem(new ChatTextMessage("Are you here?", bobUser, DateTime.Now)));
                chatHistory[authors[1]] = bobUserMessages;
            }
            else
            {
                Author currentAuthor = this.radListControl1.SelectedItem.DataBoundItem as Author;
                ChatTextMessage message1 = new ChatTextMessage(currentAuthor.Name + ":" + "Are you here : " + messageCounter, currentAuthor, DateTime.Now);
                this.radChat1.AddMessage(message1);
            }

            ScrollToLastItem();
        }

        void ScrollToLastItem()
        {
            RadScrollBarElement scrollbar = radChat1.ChatElement.MessagesViewElement.Scroller.Scrollbar;
            scrollbar.Value = 0;
            while (scrollbar.Value < scrollbar.Maximum - scrollbar.LargeChange + 1)
            {
                scrollbar.PerformSmallIncrement(1);
                radChat1.ChatElement.MessagesViewElement.Scroller.UpdateScrollRange();
                Application.DoEvents();
            }

            scrollbar.PerformLast();
        }
    }
}
