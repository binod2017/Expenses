using Business;
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
    public partial class Deposit : Form
    {
        private IExpenseBusiness expenseService;
        public Deposit()
        {
            InitializeComponent();
            txtName.Focus();
            this.expenseService = new ExpenseBusiness();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            //load all the details from the database
            DataTable result = expenseService.GetDeposits();
            //save it to database
            if (result.Rows.Count > 0)
            {
                dgvResult.DataSource = result;
                dgvResult.Refresh();
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only Alphabets
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only numerics and "."
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != string.Empty || txtAmount.Text.Trim() != string.Empty)
            {
                Deposits deposit = new Deposits()
                {
                    Id = expenseService.GetLastIdDeposits() + 1,
                    Name = txtName.Text.Trim(),
                    Amount = txtAmount.Text.Trim(),
                    DepositedOn = DateTime.Now.ToShortDateString()
                };
                bool result = expenseService.AddNewDeposits(deposit);
                //save it to database
                if (result)
                {
                    dgvResult.DataSource = expenseService.GetDeposits();
                    dgvResult.Refresh();
                    txtName.Text = txtAmount.Text = "";
                }
            }
            else { MessageBox.Show("Please check the Name and Amount", "Alert"); }
            
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            //print preview
        }
        string[] allfiles = new string[] 
            { 
                "Expense.xlsx"
            };
        private void btnClose_Click(object sender, EventArgs e)
        {
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
        }
    }
}
