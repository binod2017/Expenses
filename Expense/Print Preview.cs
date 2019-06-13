using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Expense
{
    public partial class Print_Preview : Form
    {
        public Print_Preview()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Instance of DataGridViewPrinter
        /// </summary>
        private DataGridViewPrinter dataGridViewPrinter;
        private IExpenseBusiness expenseService;

        #region Form Details
        string[] ldmonth = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        string[] ldyear = new string[] { "2015", "2016", "2017", "2018", "2019", "2020" };
        private void Printpreview_Load(object sender, EventArgs e)
        {
            lblSpent.Text = "";
            cmbMonth.Items.AddRange(ldmonth);
            cmbYear.Items.AddRange(ldyear);
            expenseService = new ExpenseBusiness();

            //Load the values as per the requirements
            DataTable data = this.expenseService.GetAllExpense();
            this.LoadDataGridView(data);
        }
        private void LoadDataGridView(DataTable data)
        {
            //dataGridViewMembers.DataSource = null;
            // Data grid view column setting            
            dataGridViewMembers.DataSource = data;
            dataGridViewMembers.DataMember = data.TableName;
            dataGridViewMembers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        /// <summary>
        /// Initializes data grid view style
        /// </summary>
        private void InitializeDataGridViewStyle()
        {
            // Setting the style of the DataGridView control

            dataGridViewMembers.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewMembers.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            dataGridViewMembers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewMembers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMembers.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewMembers.DefaultCellStyle.BackColor = Color.Empty;
            dataGridViewMembers.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Info;
            dataGridViewMembers.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewMembers.GridColor = SystemColors.ControlDarkDark;
        }
        private void ShowErrorMessage(Exception ex)
        {
            MessageBox.Show(
               ex.Message, "Alert Message",
                //Resources.System_Error_Message, 
                //Resources.System_Error_Message_Title,
               MessageBoxButtons.OK,
               MessageBoxIcon.Error
               );
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Old
        private void cmbMonth_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //string months = cmbMonth.SelectedItem.ToString();
            //DataTable data = this.expenseService.SearchExpenseMonth(months);
            //dataGridView2.DataSource = data;
            //dataGridView2.DataMember = data.TableName;
            //dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string years = cmbYear.SelectedItem.ToString();
            //DataTable data = this.expenseService.SearchExpenseYear(years);
            //dataGridView2.DataSource = data;
            //dataGridView2.DataMember = data.TableName;
            //dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        #endregion
        #region CheckBoxes status
        private void chkSearchByYear_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchByYear.Checked)
            {
                cmbYear.Visible = true;
                cmbYear.Enabled = true;

                dtpFrom.Visible = false;
                dtpFrom.Enabled = false;
                dtpTo.Visible = false;
                dtpTo.Enabled = false;
                label1.Visible = false;
                label2.Visible = false;
                chkSearchByDate.Checked = false;
            }
            else
            {
                cmbYear.Visible = false;
                cmbYear.Enabled = false;
            }
        }

        private void chkSearchByMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchByMonth.Checked)
            {
                cmbMonth.Visible = true;
                cmbMonth.Enabled = true;

                dtpFrom.Visible = false;
                dtpFrom.Enabled = false;
                dtpTo.Visible = false;
                dtpTo.Enabled = false;
                label1.Visible = false;
                label2.Visible = false;
                chkSearchByDate.Checked = false;
            }
            else
            {
                cmbMonth.Visible = false;
                cmbMonth.Enabled = false;
            }
        }

        private void chkSearchByDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchByDate.Checked)
            {
                dtpFrom.Visible = true;
                dtpFrom.Enabled = true;
                dtpTo.Visible = true;
                dtpTo.Enabled = true;
                label1.Visible = true;
                label2.Visible = true;

                cmbYear.Visible = false;
                cmbYear.Enabled = false;
                chkSearchByMonth.Checked = false;

                cmbMonth.Visible = false;
                cmbMonth.Enabled = false;
                chkSearchByYear.Checked = false;
            }
            else
            {
                dtpFrom.Visible = false;
                dtpFrom.Enabled = false;
                dtpTo.Visible = false;
                dtpTo.Enabled = false;
                label1.Visible = false;
                label2.Visible = false;
            }
        }
        #endregion
        #region Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //conditions
            DateTime fromdate;
            DateTime todate;
            string month;
            int year;
            string operand;
            if (chkSearchByDate.Checked)
            {
                fromdate = dtpFrom.Value;
                todate = dtpTo.Value;
                LoadData(fromdate, todate);
            }
            else
            {
                if (chkSearchByMonth.Checked)
                {
                    month = cmbMonth.SelectedItem.ToString();
                }
                else { month = null; }
                if (chkSearchByYear.Checked)
                {
                    year = int.Parse(cmbYear.SelectedItem.ToString());
                }
                else { year = 0; }
                if (chkSearchByMonth.Checked && chkSearchByYear.Checked)
                {
                    operand = "AND";
                }
                else { operand = "OR"; }
                Search(month, year, operand);
            }
        }
        private void Search(string month, int year, string operand)
        {
            DataTable data = expenseService.GetExpenseByParameters(month, year, operand);
            this.LoadDataGridView(data);
        }
        private void LoadData(DateTime fromdate, DateTime todate)
        {
            // Data grid view column setting 
            DataTable data = this.expenseService.SearchExpense(fromdate, todate);

            dataGridViewMembers.DataSource = data;
            dataGridViewMembers.DataMember = data.TableName;
            dataGridViewMembers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            int total, Total = 0;
            if (data != null)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    total = int.Parse(data.Rows[i]["Expense"].ToString());
                    Total = Total + total;
                }
            }
            lblSpent.Text = "Rs " + Total.ToString();
        }

        #endregion

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SetupPrinting(false))
                {
                    PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                    printPreviewDialog.Document = this.PrintReport;
                    printPreviewDialog.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        private bool SetupPrinting(bool isPrint)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.AllowCurrentPage = false;
            printDialog.AllowPrintToFile = false;
            printDialog.AllowSelection = false;
            printDialog.AllowSomePages = false;
            printDialog.PrintToFile = false;
            printDialog.ShowHelp = false;
            printDialog.ShowNetwork = false;

            if (isPrint)
            {
                if (printDialog.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }
            }

            string title = "Expense Report for " + DateTime.Now.Year;
            this.PrintReport.DocumentName = "Expense Report";
            this.PrintReport.PrinterSettings = printDialog.PrinterSettings;
            this.PrintReport.DefaultPageSettings = printDialog.PrinterSettings.DefaultPageSettings;
            this.PrintReport.DefaultPageSettings.Margins = new Margins(40, 40, 40, 40);
            this.dataGridViewPrinter = new DataGridViewPrinter(dataGridViewMembers, PrintReport, true, true, title, new Font("Tahoma", 13, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
            return true;
        }

        #endregion

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SetupPrinting(true))
                {
                    this.PrintReport.Print();
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                bool hasMorePages = this.dataGridViewPrinter.DrawDataGridView(e.Graphics);

                if (hasMorePages == true)
                {
                    e.HasMorePages = true;
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }
    }
}
