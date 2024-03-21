using System;
using Telerik.WinControls.UI;
using System.Drawing;
using TelerikCheckers.Properties;
using Telerik.WinControls;

namespace TelerikCheckers
{
    public class CheckersBoard
    {
        public static Image BigBlackChecker = new Bitmap(Resources.checker_black, new Size(80, 80));
        public static Image BigWhiteChecker = new Bitmap(Resources.checker_white, new Size(80, 80));
        public static Image BigBlackCheckerKing = new Bitmap(Resources.checker_black_king, new Size(80, 80));
        public static Image BigWhiteCheckerKing = new Bitmap(Resources.checker_white_king, new Size(80, 80));
        public static Image BlackChecker = Resources.checker_black;
        public static Image WhiteChecker = Resources.checker_white;
        public static Image BlackCheckerKing = Resources.checker_black_king;
        public static Image WhiteCheckerKing = Resources.checker_white_king;

        public static Color BorderOuterColor = Color.FromArgb(58, 27, 8);
        public static Color BorderInnerColor = Color.FromArgb(248, 229, 196);
        public static Color FontColor = Color.FromArgb(248, 229, 196);
        public static Color BackDarkColor = Color.FromArgb(132, 62, 17);
        public static Color BackLightColor = Color.FromArgb(223, 177, 94);

        public static string WHITE = "W";
        public static string BLACK = "B";
        public static string WHITEKING = "WC";
        public static string BLACKKING = "BC";
        public static int whiteTaken = 0;
        public static int blackTaken = 0;
        public static int rowIndex = -1;
        public static int columnIndex = -1;
        public static bool shouldTakeChecker = false;

        public static bool CanCheckerBeDragged(Turn turn, GridDataCellElement cell)
        {
            string value = cell.Value.ToString();
            if ((value == WHITE && turn == Turn.White)
                || (value == BLACK && turn == Turn.Black)
                || (value == WHITEKING && turn == Turn.White)
                || (value == BLACKKING && turn == Turn.Black))
            {
                return true;
            }
            return false;
        }

        public static bool CanHitMoreCheckersInRow(Turn turn, GridDataCellElement targetCell)
        {
            RadGridView grid = targetCell.GridControl;

            if (turn == Turn.Black)
            {
                // top-right direction
                if (targetCell.RowIndex - 2 > -1 && targetCell.ColumnIndex + 2 < 8)
                {
                    object value = grid.Rows[targetCell.RowIndex - 1].Cells[targetCell.ColumnIndex + 1].Value;
                    if(value != null)
                    {
                        string stringValue = value.ToString();
                        if((stringValue == CheckersBoard.WHITE ||
                            stringValue == CheckersBoard.WHITEKING)
                            && grid.Rows[targetCell.RowIndex - 2].Cells[targetCell.ColumnIndex + 2].Value == null)
                        {
                            return true;
                        }
                    }
                }

                // top-left direction
                if (targetCell.RowIndex - 2 > -1 && targetCell.ColumnIndex - 2 > -1)
                {
                    object value = grid.Rows[targetCell.RowIndex - 1].Cells[targetCell.ColumnIndex - 1].Value;
                    if (value != null)
                    {
                        string stringValue = value.ToString();
                        if ((stringValue == CheckersBoard.WHITE ||
                            stringValue == CheckersBoard.WHITEKING)
                            && grid.Rows[targetCell.RowIndex - 2].Cells[targetCell.ColumnIndex - 2].Value == null)
                        {
                            return true;
                        }
                    }
                }

                if (targetCell.Value.ToString() == CheckersBoard.BLACKKING)
                {                  
                    // bottom-right direction
                    if (targetCell.RowIndex + 2 < 8 && targetCell.ColumnIndex + 2 < 8)
                    {
                        object value = grid.Rows[targetCell.RowIndex + 1].Cells[targetCell.ColumnIndex + 1].Value;
                        if (value != null)
                        {
                            string stringValue = value.ToString();
                            if ((stringValue == CheckersBoard.WHITE ||
                                stringValue == CheckersBoard.WHITEKING)
                                && grid.Rows[targetCell.RowIndex + 2].Cells[targetCell.ColumnIndex + 2].Value == null)
                            {
                                return true;
                            }
                        }
                    }

                    // bottom-left direction
                    if (targetCell.RowIndex + 2 < 8 && targetCell.ColumnIndex - 2 > -1)
                    {

                        object value = grid.Rows[targetCell.RowIndex + 1].Cells[targetCell.ColumnIndex - 1].Value;
                        if (value != null)
                        {
                            string stringValue = value.ToString();
                            if ((stringValue == CheckersBoard.WHITE ||
                                stringValue == CheckersBoard.WHITEKING)
                                && grid.Rows[targetCell.RowIndex + 2].Cells[targetCell.ColumnIndex - 1].Value == null)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            else
            {
                // bottom-right direction
                if (targetCell.RowIndex + 2 < 8 && targetCell.ColumnIndex + 2 < 8)
                {

                    object value = grid.Rows[targetCell.RowIndex + 1].Cells[targetCell.ColumnIndex + 1].Value;
                    if (value != null)
                    {
                        string stringValue = value.ToString();
                        if ((stringValue == CheckersBoard.WHITE ||
                            stringValue == CheckersBoard.WHITEKING)
                            && grid.Rows[targetCell.RowIndex + 2].Cells[targetCell.ColumnIndex + 2].Value == null)
                        {
                            return true;
                        }
                    }
                }

                // bottom-left direction
                if (targetCell.RowIndex + 2 < 8 && targetCell.ColumnIndex - 2 > -1)
                {
                    object value = grid.Rows[targetCell.RowIndex + 1].Cells[targetCell.ColumnIndex - 1].Value;
                    if (value != null)
                    {
                        string stringValue = value.ToString();
                        if ((stringValue == CheckersBoard.WHITE ||
                            stringValue == CheckersBoard.WHITEKING)
                            && grid.Rows[targetCell.RowIndex + 2].Cells[targetCell.ColumnIndex - 1].Value == null)
                        {
                            return true;
                        }
                    }
                }

                if (targetCell.Value.ToString() == CheckersBoard.WHITEKING)
                {
                    // top-right direction
                    if (targetCell.RowIndex - 2 > -1 && targetCell.ColumnIndex + 2 < 8)
                    {
                        object value = grid.Rows[targetCell.RowIndex - 1].Cells[targetCell.ColumnIndex + 1].Value;
                        if (value != null)
                        {
                            string stringValue = value.ToString();
                            if ((stringValue == CheckersBoard.WHITE ||
                                stringValue == CheckersBoard.WHITEKING)
                                && grid.Rows[targetCell.RowIndex - 2].Cells[targetCell.ColumnIndex + 2].Value == null)
                            {
                                return true;
                            }
                        }
                    }

                    // top-left direction
                    if (targetCell.RowIndex - 2 > -1 && targetCell.ColumnIndex - 2 > -1)
                    {
                        object value = grid.Rows[targetCell.RowIndex - 1].Cells[targetCell.ColumnIndex - 1].Value;
                        if (value != null)
                        {
                            string stringValue = value.ToString();
                            if ((stringValue == CheckersBoard.WHITE ||
                                stringValue == CheckersBoard.WHITEKING)
                                && grid.Rows[targetCell.RowIndex - 2].Cells[targetCell.ColumnIndex - 1].Value == null)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        public static bool IsLastRow(GridDataCellElement targetCell)
        {
            if (targetCell.RowIndex == 0 || targetCell.RowIndex == 7)
            {
                return true;
            }

            return false;
        }

        public static bool IsCheckerWhite(string checker)
        {
            if (checker == WHITE
                || checker == WHITEKING)
            {
                return true;
            }
            return false;
        }

        public static bool IsCheckerBlack(string checker)
        {
            if (checker == BLACK
                || checker == BLACKKING)
            {
                return true;
            }
            return false;
        }

        public static bool CanDrop(GridDataCellElement targetCell, GridDataCellElement draggedCell, string draggedValue)
        {
            rowIndex = -1;
            columnIndex = -1;

            // you can't drag one checker on another
            if (targetCell.Value != null)
            {
                return false;
            }

            // you can't drag a checker on a white square
            if ((targetCell.RowIndex + targetCell.ColumnIndex) % 2 == 0)
            {
                return false;
            }

            if (!CheckersBoard.shouldTakeChecker)
            {
                // move only up
                if (draggedValue == BLACK)
                {
                    if (draggedCell.RowIndex - targetCell.RowIndex == 1
                        && Math.Abs(draggedCell.ColumnIndex - targetCell.ColumnIndex) == 1)
                    {
                        return true;
                    }
                }

                // move only down
                if (draggedValue == WHITE)
                {
                    if (targetCell.RowIndex - draggedCell.RowIndex == 1
                        && Math.Abs(draggedCell.ColumnIndex - targetCell.ColumnIndex) == 1)
                    {
                        return true;
                    }
                }

                // king can be moved up and down
                if (draggedValue == BLACKKING)
                {
                    if (Math.Abs(draggedCell.RowIndex - targetCell.RowIndex) == 1
                        && Math.Abs(draggedCell.ColumnIndex - targetCell.ColumnIndex) == 1)
                    {
                        return true;
                    }
                }

                // king can be moved up and down
                if (draggedValue == WHITEKING)
                {
                    if (Math.Abs(draggedCell.RowIndex - targetCell.RowIndex) == 1
                        && Math.Abs(draggedCell.ColumnIndex - targetCell.ColumnIndex) == 1)
                    {
                        return true;
                    }
                }
            }

            // if black checker is dragged over a white (or white king) checker
            if (draggedValue == BLACK)
            {
                // top
                if (targetCell.RowIndex - draggedCell.RowIndex == -2)
                {
                    // top-right possible square
                    if (targetCell.ColumnIndex - draggedCell.ColumnIndex == 2)
                    {
                        object val = targetCell.ViewInfo.Rows[targetCell.RowIndex + 1].Cells[targetCell.ColumnIndex - 1].Value;
                        if (val != null)
                        {
                            string stringValue = val.ToString();
                            if (stringValue == WHITE || stringValue == WHITEKING)
                            {
                                rowIndex = targetCell.RowIndex + 1;
                                columnIndex = targetCell.ColumnIndex - 1;
                                return true;
                            }
                        }
                    }

                    // top-left possible square
                    if (targetCell.ColumnIndex - draggedCell.ColumnIndex == -2)
                    {
                        object val = targetCell.ViewInfo.Rows[targetCell.RowIndex + 1].Cells[targetCell.ColumnIndex + 1].Value;
                        if (val != null)
                        {
                            string stringValue = val.ToString();
                            if (stringValue != null)
                            {
                                if (stringValue == WHITE || stringValue == WHITEKING)
                                {
                                    rowIndex = targetCell.RowIndex + 1;
                                    columnIndex = targetCell.ColumnIndex + 1;
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            // if white checker is dragged over a black (or black king) checker
            if (draggedValue == WHITE)
            {
                // top
                if (targetCell.RowIndex - draggedCell.RowIndex == 2)
                {
                    // bottom-right possible square
                    if (targetCell.ColumnIndex - draggedCell.ColumnIndex == 2)
                    {
                        object val = targetCell.ViewInfo.Rows[targetCell.RowIndex - 1].Cells[targetCell.ColumnIndex - 1].Value;
                        if (val != null)
                        {
                            string stringValue = val.ToString();
                            if (stringValue == BLACK || stringValue == BLACKKING)
                            {
                                rowIndex = targetCell.RowIndex - 1;
                                columnIndex = targetCell.ColumnIndex - 1;
                                return true;
                            }
                        }
                    }

                    // bottom-left possible square
                    if (targetCell.ColumnIndex - draggedCell.ColumnIndex == -2)
                    {
                        object val = targetCell.ViewInfo.Rows[targetCell.RowIndex - 1].Cells[targetCell.ColumnIndex + 1].Value;
                        if (val != null)
                        {
                            string stringValue = val.ToString();
                            if (stringValue == BLACK || stringValue == BLACKKING)
                            {
                                rowIndex = targetCell.RowIndex - 1;
                                columnIndex = targetCell.ColumnIndex + 1;
                                return true;
                            }
                        }
                    }
                }
            }

            // if black king checker is dragged over a white (or white king) checker
            if (draggedValue == BLACKKING)
            {
                // to-bottom
                if (targetCell.RowIndex - draggedCell.RowIndex == 2)
                {
                    // bottom-right possible square
                    if (targetCell.ColumnIndex - draggedCell.ColumnIndex == 2)
                    {
                        object val = targetCell.ViewInfo.Rows[targetCell.RowIndex - 1].Cells[targetCell.ColumnIndex - 1].Value;
                        if (val != null)
                        {
                            string stringValue = val.ToString();
                            if (stringValue == WHITE || stringValue == WHITEKING)
                            {
                                rowIndex = targetCell.RowIndex - 1;
                                columnIndex = targetCell.ColumnIndex - 1;
                                return true;
                            }
                        }
                    }

                    // bottom-left possible square
                    if (targetCell.ColumnIndex - draggedCell.ColumnIndex == -2)
                    {
                        object val = targetCell.ViewInfo.Rows[targetCell.RowIndex - 1].Cells[targetCell.ColumnIndex + 1].Value;
                        if (val != null)
                        {
                            string objectValue = val.ToString();
                            if (objectValue == WHITE || objectValue == WHITEKING)
                            {
                                rowIndex = targetCell.RowIndex - 1;
                                columnIndex = targetCell.ColumnIndex + 1;
                                return true;
                            }
                        }
                    }
                }

                // to-top
                if (targetCell.RowIndex - draggedCell.RowIndex == -2)
                {
                    // top-right possible square
                    if (targetCell.ColumnIndex - draggedCell.ColumnIndex == 2)
                    {
                        object val = targetCell.ViewInfo.Rows[targetCell.RowIndex + 1].Cells[targetCell.ColumnIndex - 1].Value;
                        if (val != null)
                        {
                            string stringValue = val.ToString();
                            if (stringValue == WHITE || stringValue == WHITEKING)
                            {
                                rowIndex = targetCell.RowIndex + 1;
                                columnIndex = targetCell.ColumnIndex - 1;
                                return true;
                            }
                        }
                    }

                    // top-left possible square
                    if (targetCell.ColumnIndex - draggedCell.ColumnIndex == -2)
                    {
                        object val = targetCell.ViewInfo.Rows[targetCell.RowIndex + 1].Cells[targetCell.ColumnIndex + 1].Value;
                        if (val != null)
                        {
                            string objectValue = val.ToString();
                            if (objectValue == WHITE || objectValue == WHITEKING)
                            {
                                rowIndex = targetCell.RowIndex + 1;
                                columnIndex = targetCell.ColumnIndex + 1;
                                return true;
                            }
                        }
                    }
                }
            }

            // if white checker is dragged over a black (or black king) checker
            if (draggedValue == WHITEKING)
            {
                // to-bottom
                if (targetCell.RowIndex - draggedCell.RowIndex == 2)
                {
                    // bottom-right possible square
                    if (targetCell.ColumnIndex - draggedCell.ColumnIndex == 2)
                    {
                        object val = targetCell.ViewInfo.Rows[targetCell.RowIndex - 1].Cells[targetCell.ColumnIndex - 1].Value;
                        if (val != null)
                        {
                            string stringValue = val.ToString();
                            if (stringValue == BLACK || stringValue == BLACKKING)
                            {
                                rowIndex = targetCell.RowIndex - 1;
                                columnIndex = targetCell.ColumnIndex - 1;
                                return true;
                            }
                        }
                    }

                    // bottom-left possible square
                    if (targetCell.ColumnIndex - draggedCell.ColumnIndex == -2)
                    {
                        object val = targetCell.ViewInfo.Rows[targetCell.RowIndex - 1].Cells[targetCell.ColumnIndex + 1].Value;
                        if (val != null)
                        {
                            string objectValue = val.ToString();
                            if (objectValue == BLACK || objectValue == BLACKKING)
                            {
                                rowIndex = targetCell.RowIndex - 1;
                                columnIndex = targetCell.ColumnIndex + 1;
                                return true;
                            }
                        }
                    }
                }

                // to-top
                if (targetCell.RowIndex - draggedCell.RowIndex == -2)
                {
                    // top-right possible square
                    if (targetCell.ColumnIndex - draggedCell.ColumnIndex == 2)
                    {
                        object val = targetCell.ViewInfo.Rows[targetCell.RowIndex + 1].Cells[targetCell.ColumnIndex - 1].Value;
                        if (val != null)
                        {
                            string stringValue = val.ToString();
                            if (stringValue == BLACK || stringValue == BLACKKING)
                            {
                                rowIndex = targetCell.RowIndex + 1;
                                columnIndex = targetCell.ColumnIndex - 1;
                                return true;
                            }
                        }
                    }

                    // top-left possible square
                    if (targetCell.ColumnIndex - draggedCell.ColumnIndex == -2)
                    {
                        object val = targetCell.ViewInfo.Rows[targetCell.RowIndex + 1].Cells[targetCell.ColumnIndex + 1].Value;
                        if (val != null)
                        {
                            string objectValue = val.ToString();
                            if (objectValue == BLACK || objectValue == WHITEKING)
                            {
                                rowIndex = targetCell.RowIndex + 1;
                                columnIndex = targetCell.ColumnIndex + 1;
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public static void IsWinner(Turn turn)
        {
            if (turn == Turn.Black)
            {
                if (blackTaken == 12)
                {
                    RadMessageBox.Show("White wins!");
                }
            }
            else
            {
                if (whiteTaken == 12)
                {
                    RadMessageBox.Show("Black wins!");
                }
            }
        }
    }
}
