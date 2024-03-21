using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;

namespace TelerikCheckers
{
    public partial class MainForm : RadForm
    {
        List<string> alphabet;
        int squareDim = 60;
        int headerRectDim = 30;
        Turn turn = Turn.Black;
        GridDataCellElement draggedCell = null;
        RadDragDropService dragDropService;
        string draggedValue;
        bool DRAGIMAGE;
        bool CANFORMAT;
        bool DRAGRESTRICTIONS;
        bool DROPRESTRICTIONS;
        bool MOVECELLCONTENT;

        #region Initialization

        public MainForm()
        {
            InitializeComponent();

            dragDropService = this.radGridView1.GridViewElement.GetService<RadDragDropService>();

            alphabet = new List<string>();
            alphabet.Add("A");
            alphabet.Add("B");
            alphabet.Add("C");
            alphabet.Add("D");
            alphabet.Add("E");
            alphabet.Add("F");
            alphabet.Add("G");
            alphabet.Add("H");
            alphabet.Add("I");

            this.radCheckBox1.ToggleState = ToggleState.On;
            this.radCheckBox2.ToggleState = ToggleState.On;
            this.radCheckBox3.ToggleState = ToggleState.On;
            this.radCheckBox4.ToggleState = ToggleState.On;
            this.radCheckBox5.ToggleState = ToggleState.On;

            InitializeTheme();
            InitializeEvents();
            InitializeGrid();
        }

        void InitializeTheme()
        {
            ThemeResolutionService.LoadPackageResource("TelerikCheckers.CheckersTheme.tssp");
            string themeName = "CheckersTheme";
            this.radButton1.ThemeName = themeName;
            this.radPanel4.ThemeName = themeName;
            this.radPanel2.ThemeName = themeName;
            this.radPanel5.ThemeName = themeName;
            this.radPanel3.ThemeName = themeName;

            string chThemeName = "Desert";
            this.radCheckBox1.ThemeName = chThemeName;
            this.radCheckBox2.ThemeName = chThemeName;
            this.radCheckBox3.ThemeName = chThemeName;
            this.radCheckBox4.ThemeName = chThemeName;
            this.radCheckBox5.ThemeName = chThemeName;

            this.radGridView1.GridViewElement.BorderBoxStyle = BorderBoxStyle.SingleBorder;
            this.radGridView1.GridViewElement.BorderGradientStyle = GradientStyles.Solid;

            pictureBox1.Image = CheckersBoard.BlackChecker;
        }

        void InitializeEvents()
        {
            this.dragDropService.PreviewDragOver += new EventHandler<RadDragOverEventArgs>(dragDropService_PreviewDragOver);
            this.dragDropService.PreviewDragDrop += new EventHandler<RadDropEventArgs>(dragDropService_PreviewDragDrop);
            this.dragDropService.PreviewDropTarget += new EventHandler<PreviewDropTargetEventArgs>(dragDropService_PreviewDropTarget);
            this.radGridView1.MouseDown += new MouseEventHandler(radGridView1_MouseDown);
            this.dragDropService.PreviewDragHint += new EventHandler<PreviewDragHintEventArgs>(dragDropService_PreviewDragHint);
            this.dragDropService.Stopping += new EventHandler<RadServiceStoppingEventArgs>(dragDropService_Stopping);
            this.radGridView1.ViewCellFormatting += new CellFormattingEventHandler(radGridView1_ViewCellFormatting);
            this.radGridView1.ContextMenuOpening += new ContextMenuOpeningEventHandler(radGridView1_ContextMenuOpening);
        }

        void InitializeGrid()
        {
            this.radGridView1.Padding = new Padding(0);
            this.radGridView1.ReadOnly = true;
            this.radGridView1.AllowAddNewRow = false;
            this.radGridView1.EnableGrouping = false;
            this.radGridView1.EnableSorting = false;
            this.radGridView1.AllowColumnReorder = false;
            this.radGridView1.AllowRowResize = false;
            this.radGridView1.AllowColumnResize = false;
            this.radGridView1.GridViewElement.BorderColor = CheckersBoard.BorderOuterColor;
            this.radGridView1.TableElement.RowHeight = squareDim;
            this.radGridView1.MasterView.TableHeaderRow.Height = headerRectDim;
            this.radGridView1.TableElement.RowHeaderColumnWidth = headerRectDim;

            this.radGridView1.TableElement.CurrentRowHeaderImage = null;

            this.radGridView1.AutoSize = true;

            for (int i = 0; i < 8; i++)
            {
                GridViewTextBoxColumn col = new GridViewTextBoxColumn();
                col.HeaderText = alphabet[i];
                col.Width = squareDim;
                this.radGridView1.Columns.Add(col);
            }

            for (int i = 0; i < 8; i++)
            {
                this.radGridView1.Rows.AddNew();
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    this.radGridView1.Rows[i].Cells[j].Value = null;
                }
            }

            for (int j = 0; j < 8; j++)
            {
                for (int i = 7; i > 4; i--)
                {
                    if ((i + j) % 2 != 0)
                    {
                        this.radGridView1.Rows[i].Cells[j].Value = CheckersBoard.BLACK;
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    if ((i + j) % 2 != 0)
                    {
                        this.radGridView1.Rows[i].Cells[j].Value = CheckersBoard.WHITE;
                    }
                }
            }

            CheckersBoard.blackTaken = 0;
            CheckersBoard.whiteTaken = 0;

            pictureBox1.Image = CheckersBoard.BlackChecker;
            turn = Turn.Black;

            CheckersBoard.shouldTakeChecker = false;
        }

        #endregion

        #region Styling

        void SetTableHeaderCellElementStyle(GridCellElement cell)
        {
            cell.BackColor = Color.FromArgb(82, 38, 11);
            cell.GradientStyle = GradientStyles.Solid;
            cell.BorderBoxStyle = BorderBoxStyle.SingleBorder;
        }

        void SetCommonStyleProperties(GridCellElement cell)
        {
            cell.DrawFill = true;
            cell.ImageLayout = ImageLayout.Stretch;
            cell.BorderColor = CheckersBoard.BorderOuterColor;
            cell.BorderGradientStyle = GradientStyles.Solid;
            cell.BorderBoxStyle = BorderBoxStyle.OuterInnerBorders;
        }

        void SetDataCellElementStyle(GridCellElement cell)
        {
            cell.GradientStyle = GradientStyles.Solid;
            if ((cell.RowIndex + cell.ColumnIndex) % 2 == 0)
            {
                cell.BackColor = CheckersBoard.BackLightColor;
                cell.BorderInnerColor = Color.FromArgb(247, 196, 104);
            }
            else
            {
                cell.BackColor = CheckersBoard.BackDarkColor;
                cell.BorderInnerColor = Color.FromArgb(152, 87, 34);
            }
        }

        void SetHeaderCellElementStyle(GridCellElement cell)
        {
            cell.GradientStyle = GradientStyles.Linear;
            cell.NumberOfColors = 4;
            cell.BackColor = Color.FromArgb(59, 27, 8);
            cell.BackColor2 = Color.FromArgb(65, 30, 9);
            cell.BackColor3 = Color.FromArgb(81, 38, 11);
            cell.BackColor4 = Color.FromArgb(88, 41, 12);
            cell.BorderBoxStyle = BorderBoxStyle.SingleBorder;
            cell.BorderColor = Color.FromArgb(49, 23, 7);
            cell.ForeColor = Color.FromArgb(223, 177, 94);
            cell.GradientPercentage = 0.3f;
            cell.GradientPercentage2 = 0.6f;
        }

        void SetRowHeaderCellElementStyle(GridCellElement cell)
        {
            cell.Text = (8 - cell.RowIndex).ToString();

            cell.GradientAngle = 0;
            cell.GradientStyle = GradientStyles.Linear;
            cell.NumberOfColors = 4;
            cell.BackColor = Color.FromArgb(59, 27, 8);
            cell.BackColor2 = Color.FromArgb(65, 30, 9);
            cell.BackColor3 = Color.FromArgb(81, 38, 11);
            cell.BackColor4 = Color.FromArgb(88, 41, 12);
            cell.BorderBoxStyle = BorderBoxStyle.SingleBorder;
            cell.BorderColor = Color.FromArgb(49, 23, 7);
            cell.ForeColor = Color.FromArgb(223, 177, 94);
            cell.GradientPercentage = 0.3f;
            cell.GradientPercentage2 = 0.6f;
        }

        void SetImages(GridCellElement cell)
        {
            if (cell.Value != null)
            {
                string cellValue = cell.Value.ToString();
                if (cellValue == CheckersBoard.WHITE)
                {
                    cell.Image = CheckersBoard.WhiteChecker;
                }
                else if (cellValue == CheckersBoard.BLACK)
                {
                    cell.Image = CheckersBoard.BlackChecker;
                }
                else if (cellValue == CheckersBoard.BLACKKING)
                {
                    cell.Image = CheckersBoard.BlackCheckerKing;
                }
                else if (cellValue == CheckersBoard.WHITEKING)
                {
                    cell.Image = CheckersBoard.WhiteCheckerKing;
                }
                else
                {
                    cell.Image = null;
                }

                if (cell is GridDataCellElement)
                {
                    cell.Text = String.Empty;
                }
            }
            else
            {
                cell.Image = null;
            }
        }

        void ResetCellValues(GridCellElement cell)
        {
            cell.ResetValue(LightVisualElement.ImageProperty, ValueResetFlags.Local);
            cell.ResetValue(VisualElement.BackColorProperty, ValueResetFlags.Local);
            cell.ResetValue(VisualElement.ForeColorProperty, ValueResetFlags.Local);
            cell.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);
            cell.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local);
            cell.ResetValue(LightVisualElement.ImageLayoutProperty, ValueResetFlags.Local);
            cell.ResetValue(LightVisualElement.BorderColorProperty, ValueResetFlags.Local);
            cell.ResetValue(LightVisualElement.BorderInnerColorProperty, ValueResetFlags.Local);
            cell.ResetValue(LightVisualElement.BorderGradientStyleProperty, ValueResetFlags.Local);
            cell.ResetValue(LightVisualElement.BorderBoxStyleProperty, ValueResetFlags.Local);

            if (cell is GridRowHeaderCellElement)
            {
                cell.ResetValue(RadItem.TextProperty, ValueResetFlags.Local);
            }

            if (cell.Value != null && cell is GridDataCellElement)
            {
                cell.Text = cell.Value.ToString();
            }
        }

        private void radGridView1_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            e.Cancel = true;
        }

        private void radGridView1_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (CANFORMAT)
            {
                SetCommonStyleProperties(e.CellElement);

                if (e.CellElement is GridRowHeaderCellElement && !(e.CellElement is GridTableHeaderCellElement))
                {
                    SetRowHeaderCellElementStyle(e.CellElement);
                }

                if (e.CellElement is GridHeaderCellElement)
                {
                    SetHeaderCellElementStyle(e.CellElement);
                }

                if (e.CellElement is GridTableHeaderCellElement)
                {
                    SetTableHeaderCellElementStyle(e.CellElement);
                }

                if (e.CellElement is GridDataCellElement)
                {
                    SetDataCellElementStyle(e.CellElement);
                }

                SetImages(e.CellElement);
            }
            else
            {
                ResetCellValues(e.CellElement);
            }
        }

        #endregion

        #region Drag'n'Drop implementation

        private void radGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            RadElement element = this.radGridView1.ElementTree.GetElementAtPoint(e.Location);
            GridDataCellElement dataCell = element as GridDataCellElement;
            if (dataCell != null)
            {
                if (dataCell.Value != null)
                {
                    draggedCell = null;

                    if (!DRAGRESTRICTIONS)
                    {
                        dataCell.AllowDrag = true;
                        dragDropService.Start(dataCell);
                        return;
                    }

                    if (CheckersBoard.CanCheckerBeDragged(turn, dataCell))
                    {
                        dataCell.AllowDrag = true;
                        dragDropService.Start(dataCell);
                    }
                }
            }
        }

        private void dragDropService_PreviewDragHint(object sender, PreviewDragHintEventArgs e)
        {
            if (e.DragInstance is GridDataCellElement)
            {
                GridDataCellElement dataCell = (GridDataCellElement)e.DragInstance;
                draggedValue = dataCell.Value.ToString();

                if (MOVECELLCONTENT)
                {
                    dataCell.Value = null;
                }

                if (DRAGIMAGE)
                {
                    if (draggedValue == CheckersBoard.WHITE)
                    {
                        e.DragHint = CheckersBoard.BigWhiteChecker;
                    }
                    else if (draggedValue == CheckersBoard.BLACK)
                    {
                        e.DragHint = CheckersBoard.BigBlackChecker;
                    }
                    else if (draggedValue == CheckersBoard.BLACKKING)
                    {
                        e.DragHint = CheckersBoard.BigBlackCheckerKing;
                    }
                    else if (draggedValue == CheckersBoard.WHITEKING)
                    {
                        e.DragHint = CheckersBoard.BigWhiteCheckerKing;
                    }
                }
            }
        }

        private void dragDropService_PreviewDropTarget(object sender, PreviewDropTargetEventArgs e)
        {
            GridDataCellElement targetCell = e.HitTarget as GridDataCellElement;
            draggedCell = e.DragInstance as GridDataCellElement;
            if (targetCell != null)
            {
                if (targetCell.ColumnInfo is GridViewTextBoxColumn)
                {
                    if (!DROPRESTRICTIONS)
                    {
                        targetCell.AllowDrop = true;
                        return;
                    }

                    targetCell.AllowDrop = CheckersBoard.CanDrop(targetCell, draggedCell, draggedValue.ToString());
                }
            }
        }

        private void dragDropService_PreviewDragOver(object sender, RadDragOverEventArgs e)
        {
            GridDataCellElement targetCell = e.HitTarget as GridDataCellElement;
            if (targetCell != null)
            {
                if (targetCell.ColumnInfo is GridViewTextBoxColumn)
                {
                    e.CanDrop = e.HitTarget is GridDataCellElement;
                }
            }
        }

        private void dragDropService_PreviewDragDrop(object sender, RadDropEventArgs e)
        {
            GridDataCellElement targetCell = e.HitTarget as GridDataCellElement;
            if (targetCell.ColumnInfo is GridViewTextBoxColumn)
            {
                GridDataCellElement dropCell = e.DragInstance as GridDataCellElement;
                if (dropCell != null)
                {
                    if (turn == Turn.Black)
                    {
                        targetCell.Value = draggedValue;

                        TakeWhiteChecker();
                        TurnBlackCheckerIntoKing(targetCell);
                    }
                    else
                    {
                        targetCell.Value = draggedValue;

                        TakeBlackChecker();
                        TurnWhiteCheckerIntoKing(targetCell);
                    }

                    this.radLabel4.Text = CheckersBoard.whiteTaken.ToString() + " x";
                    this.radLabel5.Text = CheckersBoard.blackTaken.ToString() + " x";

                    if (CheckersBoard.rowIndex != -1 && CheckersBoard.columnIndex != -1)
                    {
                        if (!CheckersBoard.CanHitMoreCheckersInRow(turn, targetCell))
                        {
                            ChangeTurn();
                        }
                        else
                        {
                            CheckersBoard.shouldTakeChecker = true;
                        }
                    }
                    else
                    {
                        ChangeTurn();                        
                    }
                   
                    CheckersBoard.IsWinner(turn);
                }
            }
        }

        

        private void dragDropService_Stopping(object sender, RadServiceStoppingEventArgs e)
        {
            if (draggedCell != null)
            {
                if (!e.Commit)
                {
                    if (MOVECELLCONTENT)
                    {
                        draggedCell.Value = draggedValue;
                    }
                }

                draggedCell.AllowDrag = false;
            }
        }

        #endregion

        #region Helper Methods

        private void TurnBlackCheckerIntoKing(GridDataCellElement targetCell)
        {
            if (CheckersBoard.IsLastRow(targetCell))
            {
                if (CheckersBoard.blackTaken > 0)
                {
                    CheckersBoard.blackTaken--;
                    targetCell.Value = CheckersBoard.BLACKKING;
                }
                else
                {
                    targetCell.Value = draggedValue;
                }
            }
        }

        private void TurnWhiteCheckerIntoKing(GridDataCellElement targetCell)
        {
            if (CheckersBoard.IsLastRow(targetCell))
            {
                if (CheckersBoard.whiteTaken > 0)
                {
                    CheckersBoard.whiteTaken--;
                    targetCell.Value = CheckersBoard.WHITEKING;
                }
                else
                {
                    targetCell.Value = draggedValue;
                }
            }
        }

        private void TakeBlackChecker()
        {
            if (CheckersBoard.rowIndex != -1 && CheckersBoard.columnIndex != -1)
            {
                CheckersBoard.blackTaken++;
                if (this.radGridView1.Rows[CheckersBoard.rowIndex].Cells[CheckersBoard.columnIndex].Value.ToString() == CheckersBoard.BLACKKING)
                {
                    CheckersBoard.blackTaken++;
                }

                this.radGridView1.Rows[CheckersBoard.rowIndex].Cells[CheckersBoard.columnIndex].Value = null;

                TurnCheckerOnTheKingRowInKing(turn);
            }
        }

        private void TakeWhiteChecker()
        {
            if (CheckersBoard.rowIndex != -1 && CheckersBoard.columnIndex != -1)
            {
                CheckersBoard.whiteTaken++;
                if (this.radGridView1.Rows[CheckersBoard.rowIndex].Cells[CheckersBoard.columnIndex].Value.ToString() == CheckersBoard.WHITEKING)
                {
                    CheckersBoard.whiteTaken++;
                }

                this.radGridView1.Rows[CheckersBoard.rowIndex].Cells[CheckersBoard.columnIndex].Value = null;

                TurnCheckerOnTheKingRowInKing(turn);
            }
        }

        void TurnCheckerOnTheKingRowInKing(Turn turn)
        {
            if (turn == Turn.Black)
            {
                for (int i = 0; i < this.radGridView1.Columns.Count; i++)
                {
                    if (this.radGridView1.Rows[7].Cells[i].Value != null)
                    {
                        if (this.radGridView1.Rows[7].Cells[i].Value.ToString() == CheckersBoard.WHITE)
                        {
                            this.radGridView1.Rows[7].Cells[i].Value = CheckersBoard.WHITEKING;
                            CheckersBoard.whiteTaken--;
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < this.radGridView1.Columns.Count; i++)
                {
                    if (this.radGridView1.Rows[0].Cells[i].Value != null)
                    {
                        if (this.radGridView1.Rows[0].Cells[i].Value.ToString() == CheckersBoard.BLACK)
                        {
                            this.radGridView1.Rows[0].Cells[i].Value = CheckersBoard.BLACKKING;
                            CheckersBoard.blackTaken--;
                            break;
                        }
                    }
                }
            }
        }

        private void ChangeTurn()
        {
            if (turn == Turn.Black)
            {
                turn = Turn.White;
                pictureBox1.Image = CheckersBoard.WhiteChecker;
            }
            else
            {
                turn = Turn.Black;
                pictureBox1.Image = CheckersBoard.BlackChecker;
            }

            CheckersBoard.shouldTakeChecker = false;
        }

        #endregion

        #region Restrictions

        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                CANFORMAT = true;
            }
            else
            {
                CANFORMAT = false;
            }

            this.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged);
        }

        private void radCheckBox2_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                DRAGIMAGE = true;
            }
            else
            {
                DRAGIMAGE = false;
            }
        }

        private void radCheckBox3_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                MOVECELLCONTENT = true;
            }
            else
            {
                MOVECELLCONTENT = false;
            }
        }

        private void radCheckBox4_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                DRAGRESTRICTIONS = true;
            }
            else
            {
                DRAGRESTRICTIONS = false;
            }
        }

        private void radCheckBox5_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                DROPRESTRICTIONS = true;
            }
            else
            {
                DROPRESTRICTIONS = false;
            }
        }

        #endregion
    }
}
