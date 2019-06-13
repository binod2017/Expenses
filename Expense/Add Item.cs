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
    public partial class Add_Item : Form
    {
        private IExpenseBusiness expenseService;
        public Add_Item()
        {
            InitializeComponent();
            this.expenseService = new ExpenseBusiness();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string itemname = txtItemName.Text.Trim();
            int id = expenseService.GetLastIdItem() + 1;
            Expenses item = new Expenses()
            {
                ID = id,
                Item = itemname
            };
            bool result = expenseService.AddNewItems(item);
            if (result)
            {
                MessageBox.Show("Item Name updated in Master List");
                txtItemName.Text = "";
            }
            LoadAllItemsList();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Item_Load(object sender, EventArgs e)
        {
            LoadAllItemsList();
        }

        private void LoadAllItemsList()
        {
            //Load All Items
            dgvItemList.DataSource = expenseService.GetAllItems();
            dgvItemList.Refresh();
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
