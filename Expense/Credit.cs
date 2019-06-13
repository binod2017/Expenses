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
    public partial class Credit : Form
    {
        private IExpenseBusiness expenseService;
        public Credit()
        {
            InitializeComponent();
            txtName.Focus();
            this.expenseService = new ExpenseBusiness();
            btnPreview.Enabled = false;
        }
        private void Credit_Load(object sender, EventArgs e)
        {
            //load all the details from the database
            DataTable result = expenseService.GetCredits();
            //save it to database
            if (result.Rows.Count > 0)
            {
                dgvResult.DataSource = result;
                dgvResult.Refresh();
            }
            txtName.Focus();
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
                Credits credit = new Credits()
                {
                    Id = expenseService.GetLastIdCredits() + 1,
                    Name = txtName.Text.Trim(),
                    Amount = txtAmount.Text.Trim(),
                    CreditedOn = DateTime.Now.ToShortDateString()
                };
                bool result = expenseService.AddNewCredits(credit);
                //save it to database
                if (result)
                {
                    dgvResult.DataSource = expenseService.GetCredits();
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
