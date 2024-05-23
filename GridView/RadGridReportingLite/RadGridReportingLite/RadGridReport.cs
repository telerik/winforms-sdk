using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using Telerik.ReportViewer.WinForms;
using Telerik.Reporting;
using Telerik.WinControls.UI;

namespace RadGridReportingLite
{
    public class RadGridReport
    {

        private Form reportForm;
        private Report report;
        private DataSet reportDataSet;
        private string reportName;

        /// <summary>
        /// Get report name
        /// </summary>
        public string ReportName
        {
            get { return reportName; }
        }

        private PageHeaderSection pageHeader;
        private ReportHeaderSection reportHeader;
        private DetailSection detail;
        private PageFooterSection pageFooter;

        //dimension
        private int tableHeaderHeight;
        private int tableRowsHeight;

        #region Page Settings API

        private bool useGridColors = false;

        public bool UseGridColors
        {
            get 
            { 
                return useGridColors; 
            }
            set 
            { 
                useGridColors = value; 
            }
        }


        private bool pageLandScape = false;

        /// <summary>
        /// Get or set the page landscape layout 
        /// </summary>
        public bool PageLandScape
        {
            get 
            { 
                return pageLandScape; 
            }
            set 
            {
                pageLandScape = value;
            }
        }

        private System.Drawing.Printing.PaperKind paperKind =
            System.Drawing.Printing.PaperKind.A4;

        /// <summary>
        /// Get or set paper kind (A3, A4 etc.)
        /// </summary>
        public System.Drawing.Printing.PaperKind PaperKind
        {
            get { return paperKind; }
            set { paperKind = value; }
        }

        private Telerik.Reporting.Drawing.Unit leftMargin = Telerik.Reporting.Drawing.Unit.Mm(0);

        /// <summary>
        /// Set report's left margin in milimeters
        /// </summary>
        public int LeftMargin
        {
            set 
            { 
                leftMargin = Telerik.Reporting.Drawing.Unit.Mm(value); 
            }
        }

        private Telerik.Reporting.Drawing.Unit rightMargin = Telerik.Reporting.Drawing.Unit.Mm(0);

        /// <summary>
        /// Set report's right margin in milimeters
        /// </summary>
        public int RightMargin
        {
            set 
            { 
                rightMargin = Telerik.Reporting.Drawing.Unit.Mm(value);
            }
        }

        private Telerik.Reporting.Drawing.Unit topMargin = Telerik.Reporting.Drawing.Unit.Mm(0);

        /// <summary>
        /// Set report's top margin in milimeters
        /// </summary>
        public int TopMargin
        {
            set 
            {
                topMargin = Telerik.Reporting.Drawing.Unit.Mm(value);
            }
        }

        private Telerik.Reporting.Drawing.Unit bottomMargin = Telerik.Reporting.Drawing.Unit.Mm(0);

        /// <summary>
        /// Set report's bottom margin in milimeters
        /// </summary>
        public int BottomMargin
        {
            set 
            {
                bottomMargin = Telerik.Reporting.Drawing.Unit.Mm(value);  
            }
        }

        /// <summary>
        /// Set report's all margins in milimeters
        /// </summary>
        public int AllMargins
        {
            set
            {
                topMargin = Telerik.Reporting.Drawing.Unit.Mm(value);
                bottomMargin = Telerik.Reporting.Drawing.Unit.Mm(value);
                leftMargin = Telerik.Reporting.Drawing.Unit.Mm(value);
                rightMargin = Telerik.Reporting.Drawing.Unit.Mm(value);
            }
        }

        private bool fitToPageSize = false;

        /// <summary>
        /// Set report to fit to paper size page
        /// </summary>
        public bool FitToPageSize
        {
            set 
            { 
                fitToPageSize = value; 
            }
        }

        private FormWindowState windowState;

        public FormWindowState ReportWindowState
        {
            set 
            { 
                windowState = value; 
            }
        }

        private Size reportSize = new Size(800, 600);

        public Size ReportSize
        {
            set { reportSize = value; }
        }

        private bool repeatTableHeader = false;

        /// <summary>
        /// Repeat Table header on all pages
        /// </summary>
        public bool RepeatTableHeader
        {
            set { repeatTableHeader = value; }
        }


        #endregion

        public RadGridReport(string reportName)
        {
            this.reportName = reportName;
            reportDataSet = new DataSet();

        }

        private void CreateReportForm(string formTitle)
        {
            this.reportForm = new Form();
            this.reportForm.Size = reportSize;
            this.reportForm.WindowState = windowState;

            this.reportForm.StartPosition = FormStartPosition.CenterParent;
            this.reportForm.FormBorderStyle = FormBorderStyle.Sizable;
            this.reportForm.MinimizeBox = false;
            this.reportForm.Text = formTitle;
            this.reportForm.ShowInTaskbar = false;
            this.reportForm.ShowIcon = false;

            ReportViewer reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.Name = "ReportViewer";

            this.reportForm.Controls.Add(reportViewer);
        }

        /// <summary>
        /// Create and show a form containig report
        /// </summary>
        /// <param name="owner">The owner of report form</param>
        /// <param name="radGridView">The grid which will be present in report</param>
        public void ReportFormShow(IWin32Window owner, RadGridView radGridView)
        {
            GetGridDimensions(radGridView);
            CreateReportForm(reportName);
            CreateTelerikReport();
            CreateDataSet(radGridView);
            AddReportData(radGridView);

            ((ReportViewer)reportForm.Controls["ReportViewer"]).Report = this.report;
            ((ReportViewer)reportForm.Controls["ReportViewer"]).RefreshReport();
            reportForm.ShowDialog(owner);
        }

        /// <summary>
        /// Create report instance and its attributes
        /// </summary>
        private void CreateTelerikReport()
        {
            this.report = new Report();

            pageHeader = new PageHeaderSection();
            detail = new DetailSection();
            pageFooter = new PageFooterSection();

            Telerik.Reporting.TextBox reportTitleTextBox = new Telerik.Reporting.TextBox();
            Telerik.Reporting.TextBox currentTimeTextBox = new Telerik.Reporting.TextBox();
            Telerik.Reporting.TextBox pageInfoTextBox = new Telerik.Reporting.TextBox();

            ((System.ComponentModel.ISupportInitialize)report).BeginInit();

            // 
            // reportTitleTextBox
            //
            reportTitleTextBox.Name = "reportTitleTextBox";
            reportTitleTextBox.Dock = DockStyle.Fill;
            reportTitleTextBox.Style.Font.Style = (Telerik.Drawing.FontStyle)(FontStyle.Bold | FontStyle.Italic);
            reportTitleTextBox.Style.Font.Size =
                new Telerik.Reporting.Drawing.Unit(14, Telerik.Reporting.Drawing.UnitType.Pixel);
            reportTitleTextBox.Value = this.reportName;
            // 
            //pageHeader
            // 
            this.pageHeader.Height = 
                new Telerik.Reporting.Drawing.Unit(25, Telerik.Reporting.Drawing.UnitType.Pixel);
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
                    reportTitleTextBox
                    });
            // 
            // detail
            // 
            detail.Height = new Telerik.Reporting.Drawing.Unit(this.tableRowsHeight, Telerik.Reporting.Drawing.UnitType.Pixel);
            detail.Name = "detail";
            // 
            // pageFooter
            // 
            pageFooter.Height = new Telerik.Reporting.Drawing.Unit(20, Telerik.Reporting.Drawing.UnitType.Pixel);
            pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
                pageInfoTextBox});
            pageFooter.Name = "pageFooter";
            //
            //pageInfoTextBox
            //
            pageInfoTextBox.Name = "pageInfoTextBox";
            pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(
                new Telerik.Reporting.Drawing.Unit(100, Telerik.Reporting.Drawing.UnitType.Pixel),
                new Telerik.Reporting.Drawing.Unit(20, Telerik.Reporting.Drawing.UnitType.Pixel));
            pageInfoTextBox.Dock = DockStyle.Left;
            pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            pageInfoTextBox.Value = "=PageNumber + ' of '+ PageCount";
            // 
            // report
            // 
            this.report.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
                pageHeader,
                detail,
                pageFooter});
            this.report.PageSettings.Landscape = pageLandScape;
            this.report.PageSettings.Margins.Bottom = bottomMargin;
            this.report.PageSettings.Margins.Left = leftMargin;
            this.report.PageSettings.Margins.Right = rightMargin;
            this.report.PageSettings.Margins.Top = topMargin;
            this.report.PageSettings.PaperKind = paperKind;


            if (!repeatTableHeader)
            {
                reportHeader = new ReportHeaderSection();

                //
                //reportHeader
                //
                reportHeader.Height =
                    new Telerik.Reporting.Drawing.Unit(
                    this.tableHeaderHeight, Telerik.Reporting.Drawing.UnitType.Pixel);
                reportHeader.Name = "reportHeader";

                this.report.Items.Add(reportHeader);
            }
            
            ((System.ComponentModel.ISupportInitialize)report).EndInit();
        }

        /// <summary>
        /// Genarate a DataSet from RadGridView data
        /// </summary>
        /// <param name="grid">Source RadGridView</param>
        private void CreateDataSet(RadGridView grid)
        {
            DataTable masterTable = CreateTableFromTemplate(grid.MasterTemplate, "MasterReportTable");
            
            this.reportDataSet.Tables.Add(masterTable);
        }

        /// <summary>
        /// Create DataTable form GridViewTemplate
        /// </summary>
        /// <param name="gridViewTemplate">GridViewTemplate which contains data</param>
        /// <param name="tableName">Table name</param>
        /// <returns>DataTable which contains data from GridViewTemplate</returns>
        private DataTable CreateTableFromTemplate(GridViewTemplate gridViewTemplate, string tableName)
        {
            if ((gridViewTemplate != null) && (tableName != ""))
            {
                DataTable table = new DataTable(tableName);

                for (int col = 0; col < gridViewTemplate.ColumnCount; col++)
                {
                    table.Columns.Add(gridViewTemplate.Columns[col].HeaderText, gridViewTemplate.Columns[col].DataType);
                }

                for (int row = 0; row < gridViewTemplate.RowCount; row++)
                {
                    DataRow tableRow = table.NewRow();
                    for (int cell = 0; cell < gridViewTemplate.ColumnCount; cell++)
                    {
                        tableRow[cell] = gridViewTemplate.Rows[row].Cells[cell].Value;
                    }

                    table.Rows.Add(tableRow);
                }

                return table;
            }
            else
            {
                return null;
            }
        }

        private void AddReportData(RadGridView grid)
        {
            if ((grid != null) && (this.reportDataSet.Tables["MasterReportTable"] != null))
            {
                #region CALCULATE REPORT WIDTH

                this.report.DataSource = this.reportDataSet.Tables["MasterReportTable"];

                Telerik.Reporting.Drawing.Unit reportWidth = Telerik.Reporting.Drawing.Unit.Mm(0);
                double columnWidthSum = 0;

                if (fitToPageSize)
                {
                    foreach (GridViewDataColumn column in grid.Columns)
                    {
                        if (!column.IsGrouped)
                        {
                            columnWidthSum += (double)column.Width;
                        }
                    }
                }

                #endregion

                Group unboundGroup = new Group(true);
                unboundGroup.GroupHeader.Height =
                        Telerik.Reporting.Drawing.Unit.Pixel(tableHeaderHeight);
                unboundGroup.GroupHeader.PrintOnEveryPage = true;
                unboundGroup.GroupFooter.Visible = false;

                if (repeatTableHeader)
                {
                    report.Groups.Add(unboundGroup);
                }

                for (int i = 0; i < grid.ColumnCount; i++)
                {
                    if (!grid.Columns[i].IsGrouped && grid.Columns[i].IsVisible)
                    {
                        #region REPORT HEADER ROW


                        GridCellElement headerCell; //= grid.MasterView.TableHeaderRow.Cells[i];
                       
                       foreach(GridRowElement rowElement in grid.TableElement.VisualRows)
                        {
                            if (rowElement is GridTableHeaderRowElement)
                            {
                                 headerCell = rowElement.VisualCells[i];
                            }
                        }


                        Telerik.Reporting.TextBox captionTextBox = new Telerik.Reporting.TextBox();
                        captionTextBox.Name = "TextBox";

                        Telerik.Reporting.Drawing.Unit reportTableSize;

                        if (pageLandScape)
                        {
                            reportTableSize = 
                                report.PageSettings.PaperSize.Height.Subtract(leftMargin).Subtract(rightMargin);
                        }
                        else
                        {
                            reportTableSize =
                                report.PageSettings.PaperSize.Width.Subtract(leftMargin).Subtract(rightMargin);
                        }
                        if (fitToPageSize)
                        {
                        //    captionTextBox.Width = reportTableSize.Multiply(
                        //        ((double)headerCell.Size.Width / columnWidthSum));
                        }
                        else
                        {
                           // captionTextBox.Width = Telerik.Reporting.Drawing.Unit.Pixel(headerCell.Size.Width);
                        }
                       // captionTextBox.Value = headerCell.Text;
                        captionTextBox.Dock = DockStyle.Left;
                        
                       // captionTextBox.Style.Font.Style = headerCell.Font.Style;
                        captionTextBox.Style.BorderStyle.Default = 
                            Telerik.Reporting.Drawing.BorderType.Solid;

                        #region REPORT HEADER CELLS COLORS

                        if (useGridColors)
                        {
                          
                            captionTextBox.Style.BackgroundColor = ColorMixer(
                                //headerCell.BackColor2,
                                //headerCell.BackColor3,
                                //headerCell.BackColor4
                                );
                        }
                        else
                        {
                            captionTextBox.Style.BackgroundColor = Color.Gray;
                            captionTextBox.Style.Color = Color.White;
                        }

                        #endregion

                      //  captionTextBox.Format = headerCell.FormatString;

                        captionTextBox.Multiline = true;
                        captionTextBox.TextWrap = true;

                        if (repeatTableHeader)
                        {
                            unboundGroup.GroupHeader.Items.Add(captionTextBox);
                        }
                        else
                        {
                            this.reportHeader.Items.Add(captionTextBox);
                        }

                        #endregion

                        #region REPORT TABLE ROWS

                        Telerik.Reporting.TextBox dataTextBox = new Telerik.Reporting.TextBox();
                        dataTextBox.Name = grid.Columns[i].HeaderText + "FieldTextBox";
                        dataTextBox.Size = captionTextBox.Size;
                        dataTextBox.Value = "=Fields.[" + grid.Columns[i].HeaderText + "]";
                        dataTextBox.Dock = DockStyle.Left;
                        dataTextBox.Format = grid.Columns[i].FormatString;

                        dataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;

                        this.detail.Items.Add(dataTextBox);

                        reportWidth = reportWidth.Add(dataTextBox.Width);

                        #endregion
                    }
                }

                this.report.Width = reportWidth;

                #region GROUPS

                for (int i = 0; i < grid.MasterTemplate.Templates.Count; i++)
                {
                    //for (int j = 0; j < grid.MasterGridViewTemplate.GroupByExpressions[i].SelectFields.Count; j++)
                    //{
                    //    Group group = new Group(true);

                    //    Telerik.Reporting.TextBox groupTitleTextBox = new Telerik.Reporting.TextBox();
                    //    groupTitleTextBox.Dock = DockStyle.Fill;
                    //    groupTitleTextBox.Width = reportWidth;
                    //    groupTitleTextBox.Value = String.Format("=\"{0}: \" + CStr(IsNull(Fields.[{1}],\"\"))",
                    //        grid.MasterGridViewTemplate.GroupByExpressions[i].SelectFields[j].HeaderText,
                    //        grid.MasterGridViewTemplate.GroupByExpressions[i].SelectFields[j].FieldName);
                    //    groupTitleTextBox.Style.Font.Style = FontStyle.Bold;
                    //    groupTitleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom;
                    //    group.GroupHeader.Items.Add(groupTitleTextBox);
                    //    group.GroupHeader.Height = Telerik.Reporting.Drawing.Unit.Pixel(tableHeaderHeight);
                    //    group.GroupHeader.KeepTogether = true;
                    //    group.GroupFooter.Height = Telerik.Reporting.Drawing.Unit.Pixel(tableHeaderHeight);
                    //    group.GroupFooter.Visible = false;

                    //    group.Grouping.Add(String.Format("=Fields.[{0}]",
                    //        grid.MasterGridViewTemplate.GroupByExpressions[i].SelectFields[j].FieldName));

                    //    report.Groups.Add(group);
                    //}
                }

                #endregion
            }
        }

        /// <summary>
        /// Get Header and Row sizes for Report from provided RadGridView
        /// </summary>
        /// <param name="grid">Source RadGridView</param>
        private void GetGridDimensions(RadGridView grid)
        {
            this.tableHeaderHeight =
                ((GridTableHeaderRowElement)(grid.RootElement.Children[0].Children[1].Children[0])).Size.Height;

            this.tableRowsHeight = GetRowHeight(grid);
        }


        /// <summary>
        /// Get average DataRows height
        /// </summary>
        /// <param name="grid">Source RadGridView</param>
        /// <returns>Average height</returns>
        private int GetRowHeight(RadGridView grid)
        {
            int rowHeightSum = 0;
            int rowSum = 0;

            for (int i = 0; i < grid.RowCount; i++)
            {
                rowHeightSum += grid.Rows[i].GetActualHeight(grid.TableElement);
                rowSum++;
            }

            int childTemplatesCount = grid.MasterTemplate.Templates.Count;

            for (int i = 0; i < childTemplatesCount; i++)
			{
                int rowCount = grid.MasterTemplate.Templates[i].RowCount;
                for (int j = 0; j < rowCount; j++)
                {
                    rowHeightSum += grid.MasterTemplate.Templates[i].Rows[j].GetActualHeight(grid.TableElement);
                    rowSum++;
                }
			}

            int averageHeight = rowHeightSum / rowSum;

            int height = 20;

            if (averageHeight > 0)
            {
                height = averageHeight;
            } 
          
            return height;
        }

        private Telerik.Reporting.Drawing.HorizontalAlign GetHorisontalAlign(ContentAlignment align)
        {
            if ((align == ContentAlignment.BottomRight) || (align == ContentAlignment.MiddleRight) ||
                (align == ContentAlignment.TopRight))
            {
                return Telerik.Reporting.Drawing.HorizontalAlign.Right;
            }
            else if ((align == ContentAlignment.BottomLeft) || (align == ContentAlignment.MiddleLeft) ||
                (align == ContentAlignment.TopLeft))
            {
                return Telerik.Reporting.Drawing.HorizontalAlign.Left;
            }
            else 
            {
                return Telerik.Reporting.Drawing.HorizontalAlign.Center;
            }
        }

        private Telerik.Reporting.Drawing.VerticalAlign GetVerticalAlign(ContentAlignment align)
        {
            if ((align == ContentAlignment.BottomCenter) || (align == ContentAlignment.BottomLeft) ||
                            (align == ContentAlignment.BottomRight))
            {
                return Telerik.Reporting.Drawing.VerticalAlign.Bottom;
            }
            else if ((align == ContentAlignment.TopCenter) || (align == ContentAlignment.TopLeft) ||
                            (align == ContentAlignment.TopRight))
            {
                return Telerik.Reporting.Drawing.VerticalAlign.Top;
            }
            else
            {
                return Telerik.Reporting.Drawing.VerticalAlign.Middle;
            }
        }

        /// <summary>
        /// Color blend fuction to mix several colors
        /// </summary>
        /// <param name="colors">Color to include in mixer</param>
        /// <returns>Blended colors</returns>
        private Color ColorMixer(params Color[] colors)
        {
            int colorR = 0;
            int colorG = 0;
            int colorB = 0;

            for (int i = 0; i < colors.Length; i++)
            {
                colorR += colors[i].R;
                colorG += colors[i].G;
                colorB += colors[i].B;
            }

            colorR = colorR / colors.Length;
            colorG = colorG / colors.Length;
            colorB = colorB / colors.Length;

            Color mixedColor = Color.FromArgb(colorR, colorG, colorB);

            return mixedColor;
        }
    }
}
