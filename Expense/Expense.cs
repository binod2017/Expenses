using Business;
using Common;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense
{
    public partial class Expense : Form
    {
        /// <summary>
        /// Variable to store error message
        /// </summary>
        //private string errorMessage;

        private IExpenseBusiness expenseService;

        /// <summary>
        /// Expense id
        /// </summary>
        private int expenseId;
        string[] allfiles = new string[] 
            { 
                "Expense.xlsx"
            };
        public Expense()
        {
            this.expenseService = new ExpenseBusiness();
            InitializeComponent();
            this.Text = "Daily Expense Sheet";
            cmbItem.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string item = "";
                string price = "";
                string quantity = "";
                int days = 0;
                int years = 0;
                //Add the expenses and load on the gridview
                if (cmbItem.SelectedIndex != -1 && txtPrice.Text.Trim() != string.Empty && txtQuantity.Text.Trim() != string.Empty)
                {
                    DataTable data = expenseService.GetLastIdInt();
                    {
                        expenseId = int.Parse(data.Rows[0]["Expr1000"].ToString()) + 1;
                    }
                    item = itemselected;
                    price = txtPrice.Text.Trim();
                    quantity = txtQuantity.Text.Trim();
                    DateTime dtpicker = Dtp.Value;
                    days = dtpicker.Day;
                    years = dtpicker.Year;

                    // Assign the values to the model
                    Expenses expenseModel = new Expenses()
                    {
                        ID = expenseId,
                        Item = item,
                        Price = price,
                        Quantity = quantity,
                        DateSpent = dtpicker,
                        Days = days,
                        Months = Format.ConvertIntToMonth(dtpicker.Month),
                        Years = years
                    };

                    // Call the service method and assign the return status to variable
                    var success = this.expenseService.RegisterExpense(expenseModel);

                    // if status of success variable is true then display a information else display the error message
                    if (success)
                    {
                        // display the message box
                        MessageBox.Show("Stored in DB", "Alert Message",
                            //Resources.Registration_Successful_Message,
                            //Resources.Registration_Successful_Message_Title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );

                        // Reset the screen
                        this.ResetRegistration();
                        cmbItem.Focus();
                    }
                    else
                    {
                        // display the error messge
                        MessageBox.Show("Error", "Alert Message",
                            //Resources.Registration_Error_Message,
                            //Resources.Registration_Error_Message_Title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                    }
                }
                else
                {
                    MessageBox.Show("Item is empty or Expense is empty");
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
            LoadRefresh();
        }

        private void ResetRegistration()
        {
            txtPrice.Text = txtQuantity.Text = "";
            cmbItem.Text = "Select";
            cmbItem.Focus();
        }

        /// <summary>
        /// Method to show general error message on any system level exception
        /// </summary>
        private void ShowErrorMessage(Exception ex)
        {
            MessageBox.Show(
                ex.Message, "Alert Message",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }
        /// <summary>
        /// Initializes data grid view style
        /// </summary>
        private void InitializeDataGridViewStyle()
        {
            // Setting the style of the DataGridView control
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.DefaultCellStyle.BackColor = Color.Empty;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Info;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = SystemColors.ControlDarkDark;
        }

        /// <summary>
        /// Method to load data grid view
        /// </summary>
        /// <param name="data">data table</param>
        private void LoadDataGridView(DataTable data)
        {
            // Data grid view column setting            
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = data.TableName;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //btnAdd.Enabled = false;
            //Update it in the database
            try
            {
                Expenses expenseModel = new Expenses()
                {
                    ID = this.expenseId,
                    Item = txtItem1.Text.Trim(),
                    Price = txtPrice1.Text,
                    Quantity = txtQuantity1.Text,
                    DateSpent = Dtp1.Value,
                    Days = Dtp1.Value.Day,
                    Months = Format.ConvertIntToMonth(Dtp1.Value.Month),
                    Years = Dtp1.Value.Year

                };

                var flag = this.expenseService.UpdateExpense(expenseModel);

                if (flag)
                {
                    DataTable data = this.expenseService.GetAllExpense();
                    this.LoadDataGridView(data);

                    MessageBox.Show("Updated Successfully", "Alert Message ",
                        //Resources.Update_Successful_Message,
                        //Resources.Update_Successful_Message_Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "Delete")
            {
                cmbItem.Enabled = true;
                txtPrice.Enabled = true;
                Dtp.Enabled = true;
                try
                {
                    var flag = this.expenseService.DeleteExpense(this.expenseId);

                    if (flag)
                    {
                        DataTable data = this.expenseService.GetAllExpense();
                        this.LoadDataGridView(data);

                        MessageBox.Show("Deleted Successfully", "Alert Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    this.ShowErrorMessage(ex);
                }
            }
            else if (btnDelete.Text == "Cancel")
            {
                ResetRegistration();
            }
        }

        private void btnPrintpreview_Click(object sender, EventArgs e)
        {
            //open other form for display of preview
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            // new form to load the values
            Print_Preview preview = new Print_Preview();
            preview.ShowDialog();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close the Expense form
            bool saveittogoogle = Utilities.SaveItToGoogleDrive(allfiles);
            if (saveittogoogle)
            {
                MessageBox.Show("Updated in Google Drive");
            }
            else { MessageBox.Show("Error in saving"); }
            bool saveittoDbBackup = Utilities.SaveItToDbBackup(allfiles);
            if (saveittoDbBackup)
            {
                MessageBox.Show("Updated in Local Backup");
            }
            else { MessageBox.Show("Error in saving"); }
            this.Close();
        }

        private void Expense_Load(object sender, EventArgs e)
        {
            lblItem.Visible = true;
            cmbItem.Visible = true;
            lblItem1.Visible = false;
            txtItem1.Visible = false;
            lblExpense.Visible = true;
            txtPrice.Visible = true;
            lblExpense1.Visible = false;
            lblQuantity1.Visible = false;
            txtPrice1.Visible = false;
            lblDtp.Visible = true;
            Dtp.Visible = true;
            lblDtp1.Visible = false;
            Dtp1.Visible = false;
            btnAdd.Enabled = true;
            btnClose.Enabled = true;
            btnDelete.Enabled = true;
            btnPrintpreview.Enabled = true;
            btnUpdate.Enabled = false;

            //Load the Xls sheet from google drive
            bool fetchitfromgoogle = Utilities.RestoreItFromGoogleDrive(allfiles);
            if (fetchitfromgoogle)
            {
                //MessageBox.Show("Updated in Google Drive");
            }
            else { MessageBox.Show("Error in fetching the data from google"); }

            LoadRefresh();
        }

        private void LoadRefresh()
        {
            cmbItem.Items.Clear();
            DataTable itemdata = this.expenseService.GetAllItems();
            if (itemdata.Rows.Count > 0)
            {
                for (int i = 0; i < itemdata.Rows.Count; i++)
                {
                    cmbItem.Items.Add(itemdata.Rows[i]["Item"].ToString());
                }
            }
            DataTable expensesdata = this.expenseService.GetAllExpense();
            this.LoadDataGridView(expensesdata);
        }

        /// <summary>
        /// Key press Event to accept only alphabet value
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">key press event data</param>
        private void txtItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 32)
            {
                e.Handled = true;
            }

        }
        /// <summary>
        /// Key press Event to accept only numeric value
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">key press event data</param>
        private void txtExpense_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dataGridView1.SelectedCells[0].RowIndex;
            MessageBox.Show("cell content click");
            try
            {
                string Id = dataGridView1[0, currentRow].Value.ToString();
                expenseId = int.Parse(Id);
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
            lblItem1.Visible = true;
            txtItem1.Visible = true;
            lblExpense1.Visible = true;
            txtPrice1.Visible = true;
            lblDtp1.Visible = true;
            Dtp1.Visible = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    string Id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                    expenseId = int.Parse(Id);

                    DataRow dataRow = this.expenseService.GetExpenseById(expenseId);

                    txtItem1.Text = dataRow["Item"].ToString();
                    txtPrice1.Text = dataRow["Expense"].ToString();
                    txtQuantity1.Text = dataRow["Quantity"].ToString();
                    Dtp1.Value = Convert.ToDateTime(dataRow["DateSpent"]);
                    //txt2Salary.Text = dataRow["Salary"].ToString() == "0.0000" ? string.Empty : dataRow["Salary"].ToString();
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
            if (dgv.SelectedRows.Count > 0)
            {
                lblItem1.Visible = true;
                txtItem1.Visible = true;
                lblExpense1.Visible = true;
                txtPrice1.Visible = true;
                lblQuantity1.Visible = true;
                txtQuantity1.Visible = true;
                lblDtp1.Visible = true;
                Dtp1.Visible = true;
                btnUpdate.Enabled = true;
                btnDelete.Text = "Delete";
                btnAdd.Enabled = false;
            }
            else
            {
                lblItem1.Visible = false;
                txtItem1.Visible = false;
                lblExpense1.Visible = false;
                txtPrice1.Visible = false;
                lblQuantity1.Visible = false;
                txtQuantity1.Visible = false;
                lblDtp1.Visible = false;
                Dtp1.Visible = false;
                btnUpdate.Enabled = false;
                btnDelete.Text = "Cancel";
                btnAdd.Enabled = true;
            }
        }
        string itemselected;
        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemselected = cmbItem.SelectedItem.ToString();
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            Add_Item add = new Add_Item();
            add.ShowDialog();
            LoadRefresh();
        }

    }
}
