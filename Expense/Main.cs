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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            Expense expensesform = new Expense();
            expensesform.ShowDialog();
        }

        private void btnDeposits_Click(object sender, EventArgs e)
        {
            Deposit depositform = new Deposit();
            depositform.ShowDialog();
        }
        string[] allfiles = new string[] 
            { 
                "Expense.xlsx"
            };
        private void Main_Load(object sender, EventArgs e)
        {
            bool restorefromgooglederive = Utilities.RestoreItFromGoogleDrive(allfiles);
            if (restorefromgooglederive)
            {
                MessageBox.Show("Restored from Google Drive");
            }
            else { MessageBox.Show("Error in restoring"); }
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            Credit creditform = new Credit();
            creditform.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
