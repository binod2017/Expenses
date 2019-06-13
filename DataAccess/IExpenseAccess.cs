using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IExpenseAccess
    {
        DataRow GetExpenseById(int Id);
        DataTable GetAllExpense();
        DataTable SearchExpense(DateTime fromdate, DateTime todate);
        DataTable SearchExpensebyMonth(string month);
        DataTable SearchExpensebyYear(string year);
        bool AddExpense(Expenses expense);
        bool UpdateExpense(Expenses expense);
        bool DeleteExpense(int id);
        DataTable GetExpenseByParameters(object month, object year, string operand);
        DataRow GetAllExpensebyDate(string date, string dateto, string month);
        DataSet GetAllExpensebyDates(object date, object dateto);
        DataTable SearchExpensebyMonth(string month, int year);
        DataTable GetLastIdInt();
        DataTable GetAllItems();
        int GetLastIdItem();
        bool AddNewItems(Expenses item);
        int GetLastIdDeposits();
        bool AddNewDeposits(Deposits deposit);
        DataTable GetDeposits();
        bool AddNewCredits(Credits credit);
        DataTable GetCredits();
        int GetLastIdCredits();
    }

    public class ExpenseAccess : IExpenseAccess
    {
        //ExpenseConnection
        /// <summary>
        /// Method to get all Expense
        /// 
        /// </summary>
        /// <returns>Data table</returns>
        public DataTable GetAllExpense()
        {
            DataTable dataTable = new DataTable();

            using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                oleDbDataAdapter.SelectCommand = new OleDbCommand();
                oleDbDataAdapter.SelectCommand.Connection = new OleDbConnection(this.ExpenseConnection);
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.Text;

                // Assign the SQL to the command object
                oleDbDataAdapter.SelectCommand.CommandText = "Select Id, Item, Expense, Quantity, DateSpent" +
                " From [ExpensesDB$] where [Active] = true order by DateSpent desc, Id desc"; ;// Scripts.sqlGetAllExpense;

                // Fill the datatable from adapter
                oleDbDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }
        /// <summary>
        /// Method to get Expense by Id
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>Data row</returns>
        public DataRow GetExpenseById(int id)
        {
            DataTable dataTable = new DataTable();
            DataRow dataRow;

            using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                dataAdapter.SelectCommand = new OleDbCommand();
                dataAdapter.SelectCommand.Connection = new OleDbConnection(this.ExpenseConnection);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                dataAdapter.SelectCommand.CommandText = "Select Id, Item, Expense, Quantity, DateSpent" +
                " From [ExpensesDB$] Where Id = @Id and [Active] = true";// Scripts.sqlGetExpenseById;

                // Add the parameter to the parameter collection
                dataAdapter.SelectCommand.Parameters.AddWithValue("@id", id);

                // Fill the datatable From adapter
                dataAdapter.Fill(dataTable);

                // Get the datarow from the table
                dataRow = dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;

                return dataRow;
            }
        }
        /// <summary>
        /// Method to search Expense by multiple parameters
        /// </summary>
        /// <param name="datefrom">datefrom</param>
        /// <param name="dateto">dateto</param>
        /// <returns>Data table</returns>
        public DataTable SearchExpense(DateTime fromdate, DateTime todate)
        {
            DataTable dataTable = new DataTable();

            using (OleDbDataAdapter DataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                DataAdapter.SelectCommand = new OleDbCommand();
                DataAdapter.SelectCommand.Connection = new OleDbConnection(this.ExpenseConnection);
                DataAdapter.SelectCommand.CommandType = CommandType.Text;

                // Assign the SQL to the command object
                //DataAdapter.SelectCommand.CommandText = "Select Item, Expense, DateSpent" +
                //        //" From Expenses Where DateSpent BETWEEN ('01-Dec-15') AND ('01-Jan-16')";
                //        " From Expenses Where DateSpent BETWEEN @fromdate AND @todate";
                DataAdapter.SelectCommand.CommandText = "Select Item, Expense,Quantity, DateSpent" +
                " From [ExpensesDB$] Where [Active] = true and DateSpent BETWEEN @fromdate AND @todate order by DateSpent desc";// Scripts.sqlSearchExpense;

                // Add the input parameters to the parameter collection
                DataAdapter.SelectCommand.Parameters.AddWithValue("@fromdate", fromdate.ToShortDateString());
                DataAdapter.SelectCommand.Parameters.AddWithValue("@todate", todate.ToShortDateString());

                // Fill the table from adapter
                DataAdapter.Fill(dataTable);
            }

            return dataTable;
        }
        /// <summary>
        /// Method to add new member
        /// </summary>
        /// <param name="expense">expense</param>
        /// <returns>true or false</returns>
        public bool AddExpense(Expenses expense)
        {
            using (OleDbCommand oleDbCommand = new OleDbCommand())
            {
                // Set the command object properties
                oleDbCommand.Connection = new OleDbConnection(this.ExpenseConnection);
                oleDbCommand.CommandType = CommandType.Text;
                oleDbCommand.CommandText = "Insert Into" +
                " [ExpensesDB$] (Id, Item, Expense, Quantity, DateSpent, Days, Months, Years, Active)" +
                " Values (@id, @item, @expense, @quantity, @dateSpent, @days, @months, @years, @active)";// Scripts.sqlInsertExpense;

                // Add the input parameters to the parameter collection
                oleDbCommand.Parameters.AddWithValue("@id", expense.ID);
                oleDbCommand.Parameters.AddWithValue("@item", expense.Item);
                oleDbCommand.Parameters.AddWithValue("@expense", expense.Price);
                oleDbCommand.Parameters.AddWithValue("@quantity", expense.Quantity);
                oleDbCommand.Parameters.AddWithValue("@dateSpent", expense.DateSpent.ToShortDateString());
                oleDbCommand.Parameters.AddWithValue("@days", expense.Days);
                oleDbCommand.Parameters.AddWithValue("@months", expense.Months);
                oleDbCommand.Parameters.AddWithValue("@years", expense.Years);
                oleDbCommand.Parameters.AddWithValue("@active", true);

                // Open the connection, execute the query and close the connection
                oleDbCommand.Connection.Open();
                var rowsAffected = oleDbCommand.ExecuteNonQuery();
                oleDbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }
        /// <summary>
        /// Method to update Expense
        /// </summary>
        /// <param name="expense">expense</param>
        /// <returns>true / false</returns>
        public bool UpdateExpense(Expenses expense)
        {
            using (OleDbCommand oleDbCommand = new OleDbCommand())
            {

                // Set the command object properties
                oleDbCommand.Connection = new OleDbConnection(this.ExpenseConnection);
                oleDbCommand.CommandType = CommandType.Text;
                oleDbCommand.CommandText = "Update [ExpensesDB$] " +
                " Set [Item] = @item, [Expense] = @expense, [Quantity] = @quantity, [DateSpent] = @dateSpent, [Days] = @days, [Months] = @months, [Years] = @years" +
                " Where ([Id] = @id) ";// Scripts.sqlUpdateExpense;

                // Add the input parameters to the parameter collection
                oleDbCommand.Parameters.AddWithValue("@item", expense.Item);
                oleDbCommand.Parameters.AddWithValue("@expense", expense.Price);
                oleDbCommand.Parameters.AddWithValue("@quantity", expense.Quantity);
                oleDbCommand.Parameters.AddWithValue("@dateSpent", expense.DateSpent.ToShortDateString());
                oleDbCommand.Parameters.AddWithValue("@days", expense.Days);
                oleDbCommand.Parameters.AddWithValue("@months", expense.Months);
                oleDbCommand.Parameters.AddWithValue("@years", expense.Years);
                oleDbCommand.Parameters.AddWithValue("@id", expense.ID);

                // Open the connection, execute the query and close the connection
                oleDbCommand.Connection.Open();
                var rowsAffected = oleDbCommand.ExecuteNonQuery();
                oleDbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }
        /// <summary>
        /// Method to delete a Expense
        /// </summary>
        /// <param name="id">Expense id</param>
        /// <returns>true / false</returns>
        public bool DeleteExpense(int id)
        {
            using (OleDbCommand dbCommand = new OleDbCommand())
            {

                // Set the command object properties
                dbCommand.Connection = new OleDbConnection(this.ExpenseConnection);
                dbCommand.CommandType = CommandType.Text;

                //You cannot delete a record in the Excel file
                //dbCommand.CommandText = "Delete From [ExpensesDB$] Where [Id] = @id";// Scripts.sqlDeleteExpense;
                dbCommand.CommandText = "Update [ExpensesDB$] " +
                " Set [Active] = false Where ([Id] = @id)";// Scripts.sqlUpdateExpense; //Active = false

                // Add the input parameter to the parameter collection
                dbCommand.Parameters.AddWithValue("@id", id);

                // Open the connection, execute the query and close the connection
                dbCommand.Connection.Open();
                var rowsAffected = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }
        public DataTable SearchExpensebyMonth(string param)
        {
            DataTable dataTable = new DataTable();

            using (OleDbDataAdapter DataAdapter = new OleDbDataAdapter())
            {

                // Create the command and set its properties
                DataAdapter.SelectCommand = new OleDbCommand();
                DataAdapter.SelectCommand.Connection = new OleDbConnection(this.ExpenseConnection);
                DataAdapter.SelectCommand.CommandType = CommandType.Text;

                // Assign the SQL to the command object
                DataAdapter.SelectCommand.CommandText = "Select Item as ITEMS, Expense as PRICE, Quantity as QUANTITY, DateSpent as SPENTON From [ExpensesDB$] Where Months = @param and [Active] = true";// Scripts.sqlSearchExpensebyMonth;

                // Add the input parameters to the parameter collection
                DataAdapter.SelectCommand.Parameters.AddWithValue("@param", param);//, datefrom == null ? DBNull.Value : datefrom);

                // Fill the table from adapter
                DataAdapter.Fill(dataTable);
            }

            return dataTable;
        }
        public DataTable SearchExpensebyYear(string param)
        {
            DataTable dataTable = new DataTable();

            using (OleDbDataAdapter DataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                DataAdapter.SelectCommand = new OleDbCommand();
                DataAdapter.SelectCommand.Connection = new OleDbConnection(this.ExpenseConnection);
                DataAdapter.SelectCommand.CommandType = CommandType.Text;

                // Assign the SQL to the command object
                DataAdapter.SelectCommand.CommandText = "Select Item as ITEMS, Expense as PRICE,Quantity as QUANTITY, Months as SPENTON From [ExpensesDB$] Where Years = @param and [Active] = true";// Scripts.sqlSearchExpensebyYear;

                // Add the input parameters to the parameter collection
                DataAdapter.SelectCommand.Parameters.AddWithValue("@param", param);//, datefrom == null ? DBNull.Value : datefrom);

                // Fill the table from adapter
                DataAdapter.Fill(dataTable);
            }

            return dataTable;
        }
        /// <summary>
        /// Method to search Expense by multiple parameters
        /// </summary>
        /// <param name="datefrom">datefrom</param>
        /// <param name="dateto">dateto</param>
        /// <param name="month">month</param>
        /// <param name="year">year</param>
        /// <returns>Data table</returns>
        public DataTable GetExpenseByParameters(object month, object year, string operand)
        {
            DataTable dataTable = new DataTable();

            using (OleDbDataAdapter DataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                DataAdapter.SelectCommand = new OleDbCommand();
                DataAdapter.SelectCommand.Connection = new OleDbConnection(this.ExpenseConnection);
                DataAdapter.SelectCommand.CommandType = CommandType.Text;

                // Assign the SQL to the command object

                DataAdapter.SelectCommand.CommandText = string.Format("Select " +
                " Item, Expense, Quantity, DateSpent" +
                " From [ExpensesDB$] Where (@months Is NULL OR @months = Months) {0} " +
                " (@years Is NULL OR @years = Years) order by DateSpent desc", operand);// string.Format(Scripts.sqlSearchbyParameters, operand);

                // Add the input parameters to the parameter collection                
                DataAdapter.SelectCommand.Parameters.AddWithValue("@months", month == null ? DBNull.Value : month);
                DataAdapter.SelectCommand.Parameters.AddWithValue("@years", year == null ? DBNull.Value : year);


                // Fill the table from adapter
                DataAdapter.Fill(dataTable);
            }

            return dataTable;
        }
        public DataRow GetAllExpensebyDate(string date, string dateto, string month)
        {
            DataTable dataTable = new DataTable();
            DataRow dataRow;

            using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                dataAdapter.SelectCommand = new OleDbCommand();
                dataAdapter.SelectCommand.Connection = new OleDbConnection(this.ExpenseConnection);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                if (@dateto == null)
                {
                    dataAdapter.SelectCommand.CommandText = "Select Item as ITEMS, Expense as PRICE, Quantity as QUANTITY " +
                    " From [ExpensesDB$] Where DateSpent = @date and [Active] = true";// Scripts.GetAllExpensebyDate;
                }
                else
                {
                    dataAdapter.SelectCommand.CommandText = "Select Item as ITEMS, Expense as PRICE, Quantity as QUANTITY, DateSpent as SPENTON From [ExpensesDB$] WHERE [Active] = true and DateSpent BETWEEN @date AND @dateto";// Scripts.GetAllExpensebetweenDate;
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@dateto", dateto);
                    //dataAdapter.SelectCommand.Parameters.AddWithValue("@month", month == null ? "" : (month));
                }

                // Add the parameter to the parameter collection
                dataAdapter.SelectCommand.Parameters.AddWithValue("@date", date);

                // Fill the datatable From adapter
                dataAdapter.Fill(dataTable);

                // Get the datarow from the table
                dataRow = dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;

                return dataRow;
            }
        }
        public DataSet GetAllExpensebyDates(object date, object dateto)
        {
            DataSet ds = new DataSet();
            DataRow dataRow;

            using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                dataAdapter.SelectCommand = new OleDbCommand();
                dataAdapter.SelectCommand.Connection = new OleDbConnection(this.ExpenseConnection);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                if (@dateto == null)
                {
                    dataAdapter.SelectCommand.CommandText = "Select Item as ITEMS, Expense as PRICE,Quantity as QUANTITY" +
                    " From [ExpensesDB$] Where DateSpent = @date and [Active] = true";// Scripts.GetAllExpensebyDate;
                }
                else
                {
                    dataAdapter.SelectCommand.CommandText = "Select Item as ITEMS, Expense as PRICE,Quantity as QUANTITY, DateSpent as SPENTON From [ExpensesDB$] WHERE [Active] = true and DateSpent BETWEEN @date AND @dateto";// Scripts.GetAllExpensebetweenDate;
                }

                // Add the parameter to the parameter collection
                dataAdapter.SelectCommand.Parameters.AddWithValue("@date", Convert.ToDateTime(date).ToShortDateString());
                dataAdapter.SelectCommand.Parameters.AddWithValue("@dateto", dateto == null ? DBNull.Value : (dateto));


                // Fill the datatable From adapter
                dataAdapter.Fill(ds, "Test");

                // Get the datarow from the table
                dataRow = ds.Tables[0].Rows.Count > 0 ? ds.Tables[0].Rows[0] : null;

                return ds;
            }
        }
        public DataTable SearchExpensebyMonth(string month, int year)
        {
            DataTable dataTable = new DataTable();

            using (OleDbDataAdapter DataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                DataAdapter.SelectCommand = new OleDbCommand();
                DataAdapter.SelectCommand.Connection = new OleDbConnection(this.ExpenseConnection);
                DataAdapter.SelectCommand.CommandType = CommandType.Text;

                // Assign the SQL to the command object
                DataAdapter.SelectCommand.CommandText = "Select Item as ITEMS, Expense as PRICE,Quantity as QUANTITY, DateSpent as SPENTON From [ExpensesDB$] Where [Active] = true and Months = @month and Years = @year";// Scripts.sqlSearchExpensebyMonthandYear;

                // Add the input parameters to the parameter collection
                DataAdapter.SelectCommand.Parameters.AddWithValue("@month", month);//, datefrom == null ? DBNull.Value : datefrom);
                DataAdapter.SelectCommand.Parameters.AddWithValue("@year", year);//, datefrom == null ? DBNull.Value : datefrom);

                // Fill the table from adapter
                DataAdapter.Fill(dataTable);
            }

            return dataTable;
        }
        public string ExpenseConnection
        {
            get
            {
                return ConfigurationManager
                    .ConnectionStrings["ExpenseDBConnection"]
                    .ToString();
            }
        }
        public DataTable GetLastIdInt()
        {
            DataTable dataTable = new DataTable();
            using (OleDbDataAdapter OleDbDbDataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                OleDbDbDataAdapter.SelectCommand = new OleDbCommand();
                OleDbDbDataAdapter.SelectCommand.Connection = new OleDbConnection(ExpenseConnection);
                OleDbDbDataAdapter.SelectCommand.CommandType = CommandType.Text;
                // Assign the SQL to the command object
                OleDbDbDataAdapter.SelectCommand.CommandText = " SELECT COUNT(*) From [ExpensesDB$]";
                // Fill the datatable from adapter
                OleDbDbDataAdapter.Fill(dataTable);
            }
            return dataTable;
        }
        public DataTable GetAllItems()
        {
            DataTable dataTable = new DataTable();

            using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                oleDbDataAdapter.SelectCommand = new OleDbCommand();
                oleDbDataAdapter.SelectCommand.Connection = new OleDbConnection(this.ExpenseConnection);
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.Text;

                // Assign the SQL to the command object
                oleDbDataAdapter.SelectCommand.CommandText = "Select Item" +
                " From [MasterList$] order by Item"; ;// Scripts.sqlGetAllExpense;

                // Fill the datatable from adapter
                oleDbDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }
        public int GetLastIdItem()
        {
            int result = 0;
            DataTable dataTable = new DataTable();
            using (OleDbDataAdapter OleDbDbDataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                OleDbDbDataAdapter.SelectCommand = new OleDbCommand();
                OleDbDbDataAdapter.SelectCommand.Connection = new OleDbConnection(ExpenseConnection);
                OleDbDbDataAdapter.SelectCommand.CommandType = CommandType.Text;
                // Assign the SQL to the command object
                OleDbDbDataAdapter.SelectCommand.CommandText = " SELECT COUNT(*) From [MasterList$]";
                // Fill the datatable from adapter
                OleDbDbDataAdapter.Fill(dataTable);
            }
            if (dataTable.Rows.Count > 0)
            {
                result = int.Parse(dataTable.Rows[0][0].ToString());
            }

            return result;
        }
        public bool AddNewItems(Expenses item)
        {
            using (OleDbCommand oleDbCommand = new OleDbCommand())
            {
                // Set the command object properties
                oleDbCommand.Connection = new OleDbConnection(this.ExpenseConnection);
                oleDbCommand.CommandType = CommandType.Text;
                oleDbCommand.CommandText = "Insert Into" +
                " [MasterList$] (Id, Item)" +
                " Values (@id, @item)";// Scripts.sqlInsertExpense;

                // Add the input parameters to the parameter collection
                oleDbCommand.Parameters.AddWithValue("@id", item.ID);
                oleDbCommand.Parameters.AddWithValue("@item", item.Item);

                // Open the connection, execute the query and close the connection
                oleDbCommand.Connection.Open();
                var rowsAffected = oleDbCommand.ExecuteNonQuery();
                oleDbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }
        public int GetLastIdDeposits()
        {
            int result = 0;
            DataTable dataTable = new DataTable();
            using (OleDbDataAdapter OleDbDbDataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                OleDbDbDataAdapter.SelectCommand = new OleDbCommand();
                OleDbDbDataAdapter.SelectCommand.Connection = new OleDbConnection(ExpenseConnection);
                OleDbDbDataAdapter.SelectCommand.CommandType = CommandType.Text;
                // Assign the SQL to the command object
                OleDbDbDataAdapter.SelectCommand.CommandText = " SELECT COUNT(*) From [DepositDB$]";
                // Fill the datatable from adapter
                OleDbDbDataAdapter.Fill(dataTable);
            }
            if (dataTable.Rows.Count > 0)
            {
                result = int.Parse(dataTable.Rows[0][0].ToString());
            }

            return result;
        }
        public bool AddNewDeposits(Deposits deposit)
        {
            using (OleDbCommand oleDbCommand = new OleDbCommand())
            {
                // Set the command object properties
                oleDbCommand.Connection = new OleDbConnection(this.ExpenseConnection);
                oleDbCommand.CommandType = CommandType.Text;
                oleDbCommand.CommandText = "Insert Into" +
                " [DepositDB$] (Id, Name, Amount, Deposited_On)" +
                " Values (@id, @name, @amount, @depositon)";// Scripts.sqlInsertExpense;

                // Add the input parameters to the parameter collection
                oleDbCommand.Parameters.AddWithValue("@id", deposit.Id);
                oleDbCommand.Parameters.AddWithValue("@name", deposit.Name);
                oleDbCommand.Parameters.AddWithValue("@amount", deposit.Amount);
                oleDbCommand.Parameters.AddWithValue("@depositon", deposit.DepositedOn);

                // Open the connection, execute the query and close the connection
                oleDbCommand.Connection.Open();
                var rowsAffected = oleDbCommand.ExecuteNonQuery();
                oleDbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }
        public DataTable GetDeposits()
        {
            DataTable dataTable = new DataTable();

            using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                oleDbDataAdapter.SelectCommand = new OleDbCommand();
                oleDbDataAdapter.SelectCommand.Connection = new OleDbConnection(this.ExpenseConnection);
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.Text;

                // Assign the SQL to the command object
                oleDbDataAdapter.SelectCommand.CommandText = "Select Id, Name, Amount, Deposited_On" +
                " From [DepositDB$] order by Deposited_On desc"; ;// Scripts.sqlGetAllExpense;

                // Fill the datatable from adapter
                oleDbDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }
        public bool AddNewCredits(Credits credit)
        {
            using (OleDbCommand oleDbCommand = new OleDbCommand())
            {
                // Set the command object properties
                oleDbCommand.Connection = new OleDbConnection(this.ExpenseConnection);
                oleDbCommand.CommandType = CommandType.Text;
                oleDbCommand.CommandText = "Insert Into" +
                " [CreditDB$] (Id, Name, Amount, Credited_On)" +
                " Values (@id, @name, @amount, @crediton)";// Scripts.sqlInsertExpense;

                // Add the input parameters to the parameter collection
                oleDbCommand.Parameters.AddWithValue("@id", credit.Id);
                oleDbCommand.Parameters.AddWithValue("@name", credit.Name);
                oleDbCommand.Parameters.AddWithValue("@amount", credit.Amount);
                oleDbCommand.Parameters.AddWithValue("@crediton", credit.CreditedOn);

                // Open the connection, execute the query and close the connection
                oleDbCommand.Connection.Open();
                var rowsAffected = oleDbCommand.ExecuteNonQuery();
                oleDbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }
        public DataTable GetCredits()
        {
            DataTable dataTable = new DataTable();

            using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                oleDbDataAdapter.SelectCommand = new OleDbCommand();
                oleDbDataAdapter.SelectCommand.Connection = new OleDbConnection(this.ExpenseConnection);
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.Text;

                // Assign the SQL to the command object
                oleDbDataAdapter.SelectCommand.CommandText = "Select Id, Name, Amount, Credited_On" +
                " From [CreditDB$] order by Credited_On desc"; ;// Scripts.sqlGetAllExpense;

                // Fill the datatable from adapter
                oleDbDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }
        public int GetLastIdCredits()
        {
            int result = 0;
            DataTable dataTable = new DataTable();
            using (OleDbDataAdapter OleDbDbDataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                OleDbDbDataAdapter.SelectCommand = new OleDbCommand();
                OleDbDbDataAdapter.SelectCommand.Connection = new OleDbConnection(ExpenseConnection);
                OleDbDbDataAdapter.SelectCommand.CommandType = CommandType.Text;
                // Assign the SQL to the command object
                OleDbDbDataAdapter.SelectCommand.CommandText = " SELECT COUNT(*) From [CreditDB$]";
                // Fill the datatable from adapter
                OleDbDbDataAdapter.Fill(dataTable);
            }
            if (dataTable.Rows.Count > 0)
            {
                result = int.Parse(dataTable.Rows[0][0].ToString());
            }

            return result;
        }
    }
}

