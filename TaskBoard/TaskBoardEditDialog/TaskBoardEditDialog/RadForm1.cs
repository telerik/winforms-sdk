using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.TaskBoard;

namespace TaskBoardEditDialog
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        UserInfo user1 = new UserInfo();
        UserInfo user2 = new UserInfo();
        UserInfo user3 = new UserInfo();
        UserInfo user4 = new UserInfo();

        public RadForm1()
        {
            InitializeComponent();
            
            user1.FirstName = "Anne";
            user1.LastName = "Dodsworth";
            user1.Avatar = Properties.Resources.AnneDodsworth22;
            
            user2.FirstName = "Andrew";
            user2.LastName = "Fuller";
            user2.Avatar = Properties.Resources.AndrewFuller22;

            user3.FirstName = "Bob";
            user3.LastName = "Smill";
            user3.Avatar = Properties.Resources.BobSmill22;
            
            user4.FirstName = "Nancy";
            user4.LastName = "Fuller";
            user4.Avatar = Properties.Resources.nancy22;

            this.radTaskBoard1.Users.Add(user1);
            this.radTaskBoard1.Users.Add(user2);
            this.radTaskBoard1.Users.Add(user3);
            this.radTaskBoard1.Users.Add(user4);

            AddTaskCards();

            foreach (RadTaskBoardColumnElement col in this.radTaskBoard1.Columns)
            {
                col.TaskCardAdding += col_TaskCardAdding;
            }
            this.radTaskBoard1.MouseDown += radTaskBoard1_MouseDown;
            this.radTaskBoard1.MouseDoubleClick += radTaskBoard1_MouseDoubleClick;
        }

        private void radTaskBoard1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                RadTaskCardElement taskCard = this.radTaskBoard1.ElementTree.GetElementAtPoint(e.Location) as RadTaskCardElement;
                if (taskCard != null)
                { 
                    TaskCardEditDialog editDialog = new TaskCardEditDialog(taskCard, this.radTaskBoard1);
                    editDialog.ShowDialog();
                }
            }
        }

        private void radTaskBoard1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.radContextMenu1.Items[0].Tag = null;
                RadTaskCardElement taskCard = this.radTaskBoard1.ElementTree.GetElementAtPoint(e.Location) as RadTaskCardElement;
                if (taskCard != null)
                {
                    Point pt = this.radTaskBoard1.PointToScreen(e.Location);
                    this.radContextMenu1.Items[0].Tag = taskCard;
                    this.radContextMenu1.DropDown.ClosePopup(RadPopupCloseReason.CloseCalled);
                    this.radContextMenu1.Show(pt);
                }
            }
        }

        private void col_TaskCardAdding(RadTaskBoardColumnElement.TaskCardAddingEventArgs args)
        {
            RadTaskCardElement defaultTaskCard = new RadTaskCardElement();
            TaskCardEditDialog editDialog = new TaskCardEditDialog(defaultTaskCard, this.radTaskBoard1);
            if (editDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                args.TaskCard = defaultTaskCard;
            }
            else
            {
                args.Cancel = true;
            }
        }
 
        private void AddTaskCards()
        {
            RadTaskCardElement card = new RadTaskCardElement();
            RadTaskBoardColumnElement c1 = new RadTaskBoardColumnElement();
            c1.Title = "Backlog";
            c1.Subtitle = "Internal Issues";
            RadTaskBoardColumnElement c2 = new RadTaskBoardColumnElement();
            c2.Title = "In Development";
            c2.Subtitle = "Prioritized Issues";
            c2.IsCollapsed = true;
            this.radTaskBoard1.Columns.Add(c1);
            this.radTaskBoard1.Columns.Add(c2);
            card.TitleText = "ListView improvements"; 
            card.DescriptionText = "Research phase";
            card.AccentSettings.Color = Color.Red;

            card.Users.Add(user1);
            card.Users.Add(user2);
            RadTaskCardTagElement tagWF = new RadTaskCardTagElement();
            tagWF.Text = "WinForms";
            RadTaskCardTagElement tagWPF = new RadTaskCardTagElement();
            tagWPF.Text = "WPF";
            card.TagElements.Add(tagWF);
            card.TagElements.Add(tagWPF);
            card.SubTasks.Add(new SubTask(card));
            card.SubTasks.Add(new SubTask(card));
            card.SubTasks.Add(new SubTask(card));
            SubTask x = new SubTask(card);
            x.Completed = true;
            card.SubTasks.Add(x);
            c1.TaskCardCollection.Add(card);
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            RadMenuItem item = sender as RadMenuItem;
            RadTaskCardElement taskCardToEdit = item.Tag as RadTaskCardElement;
            TaskCardEditDialog editDialog = new TaskCardEditDialog(taskCardToEdit, this.radTaskBoard1);
            editDialog.ShowDialog();
        }
    }
}