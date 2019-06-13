using DataAccess;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IExpenseBusiness
    {
        DataRow GetExpenseById(int Id);
        DataTable GetAllExpense();
        DataTable SearchExpense(DateTime datefrom, DateTime dateto);
        DataTable SearchExpensebyMonth(string month);
        DataTable SearchExpensebyMonth(string month, int year);
        DataTable SearchExpensebyYear(string year);
        bool RegisterExpense(Expenses expense);
        bool UpdateExpense(Expenses expense);
        bool DeleteExpense(int id);
        DataTable GetExpenseByParameters(object month, object year, string operand);
        DataRow GetAllExpensebyDate(string date, string dateto, string month);
        DataSet GetAllExpensebyDates(string date, string dateto);
        DataTable GetLastIdInt();
        DataTable GetAllItems();
        int GetLastIdItem();
        bool AddNewItems(Expenses item);
        DataTable GetDeposits();
        int GetLastIdDeposits();
        bool AddNewDeposits(Deposits deposit);
        bool AddNewCredits(Credits credit);
        DataTable GetCredits();

        int GetLastIdCredits();
    }

    public class ExpenseBusiness : IExpenseBusiness
    {
        public IExpenseAccess expenseAccess;
        public ExpenseBusiness()
        {
            expenseAccess = new ExpenseAccess();
        }
        public bool RegisterExpense(Expenses expense)
        {
            return this.expenseAccess.AddExpense(expense);
        }
        public bool DeleteExpense(int id)
        {
            return this.expenseAccess.DeleteExpense(id);
        }
        public DataTable GetAllExpense()
        {
            return this.expenseAccess.GetAllExpense();
        }
        public DataRow GetAllExpensebyDate(string date, string dateto, string month)
        {
            return this.expenseAccess.GetAllExpensebyDate(date, dateto, month);
        }
        public DataSet GetAllExpensebyDates(string date, string dateto)
        {
            return this.expenseAccess.GetAllExpensebyDates(date, dateto);
        }
        public DataRow GetExpenseById(int id)
        {
            return this.expenseAccess.GetExpenseById(id);
        }
        public DataTable GetExpenseByParameters(object month, object year, string operand)
        {
            return this.expenseAccess.GetExpenseByParameters(month, year, operand);
        }
        public DataTable SearchExpense(DateTime fromdate, DateTime todate)
        {
            return this.expenseAccess.SearchExpense(fromdate, todate);
        }
        public DataTable SearchExpensebyMonth(string month)
        {
            return this.expenseAccess.SearchExpensebyMonth(month);
        }
        public DataTable SearchExpensebyMonth(string month, int year)
        {
            return this.expenseAccess.SearchExpensebyMonth(month, year);
        }
        public DataTable SearchExpensebyYear(string year)
        {
            return this.expenseAccess.SearchExpensebyYear(year);
        }
        public bool UpdateExpense(Expenses expense)
        {
            return this.expenseAccess.UpdateExpense(expense);
        }
        public DataTable GetLastIdInt()
        {
            return this.expenseAccess.GetLastIdInt();
        }
        public DataTable GetAllItems()
        {
            return this.expenseAccess.GetAllItems();
        }
        public int GetLastIdItem()
        {
            return this.expenseAccess.GetLastIdItem();
        }
        public bool AddNewItems(Expenses item)
        {
            return this.expenseAccess.AddNewItems(item);
        }
        public int GetLastIdDeposits()
        {
            return this.expenseAccess.GetLastIdDeposits();
        }
        public bool AddNewDeposits(Deposits deposit)
        {
            return this.expenseAccess.AddNewDeposits(deposit);
        }
        public DataTable GetDeposits()
        {
            return this.expenseAccess.GetDeposits();
        }
        public bool AddNewCredits(Credits credit)
        {
            return this.expenseAccess.AddNewCredits(credit);
        }
        public DataTable GetCredits()
        {
            return this.expenseAccess.GetCredits();
        }
        public int GetLastIdCredits()
        {
            return this.expenseAccess.GetLastIdCredits();
        }
    }
}
