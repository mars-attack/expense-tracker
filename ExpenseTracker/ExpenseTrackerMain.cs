using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;


namespace ExpenseTracker
{
    public partial class ExpenseTrackerMain : Form
    {
        public static double total;
        public static double budgetAmount;
        public static double remainBudget;
        public List<Expense> expenses = new List<Expense>();
        DataTable dt = new DataTable();

        public ExpenseTrackerMain()
        {
            // threading used for handling the slashscreen form
            Thread t = new Thread(new ThreadStart(StartSplashScreen));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            t.Abort();

            // to bring form to the front
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;

            ExpenseTypeBox.DataSource = Enum.GetValues(typeof(ExpenseType));

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            TextReader reader = new StreamReader("myfile.json");
            expenses = serializer.Deserialize<List<Expense>>(reader.ReadToEnd());
            reader.Close();
            UpdateDataGrid();
        }

        // Runs the SplashScreen
        public void StartSplashScreen()
        {
            Application.Run(new SplashScreen());
        }

        public void UpdateDataGrid()
        {
            //using my generic class
            MyList<string, string, string> headings = new MyList<string, string, string>("Expense", "Amount", "Type");
            dt = new DataTable();
            dt.Columns.Add(headings.Item1);
            dt.Columns.Add(headings.Item2);
            dt.Columns.Add(headings.Item3);
            foreach (Expense e in expenses)
            {
                dt.Rows.Add(e.ItemName, e.Amount, e.Type);
            }
            dataGridView1.DataSource = dt;
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            // Exception handling for empty and zero values
            try
            {
                string itemname = ItemNameBox.Text;
                double amount = Convert.ToDouble(AmountBox.Text);
                budgetAmount = Convert.ToDouble(BudgetBox.Text);


                string expenseType = ExpenseTypeBox.Text != ""? ExpenseTypeBox.Text: "";


                if (itemname != "" && amount != 0 && budgetAmount != 0 && expenseType != "")
                {

                    expenses.Add(new Expense(itemname, amount, (ExpenseType)Enum.Parse(typeof(ExpenseType), expenseType)));
                    UpdateTotal();
                    UpdateDataGrid();
                }
                else
                {
                    throw new Exception();
                }
            }

            catch
            {
                summaryBox.Text = "Please fill in all details.";
                summaryBox.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))); // color for error
            }
        }

        public void UpdateTotal()
        {
            summaryBox.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))); // reset color
            total = 0;
            foreach (Expense exp in expenses)
            {
                total += exp.Amount;
            }
            remainBudget = budgetAmount - total;
            summaryBox.Text = $"You spent ${total:f2}. You have ${remainBudget:f2} left.";
        }
        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            // error handling for item not found
            try
            {
                bool itemFound = false;
                budgetAmount = Convert.ToDouble(BudgetBox.Text);
                foreach (Expense exp in expenses)
                {

                    if (ItemNameBox.Text == exp.ItemName)
                    {
                        exp.ItemName = ItemNameBox.Text;
                        exp.Amount = Convert.ToDouble(AmountBox.Text);
                        string type = ExpenseTypeBox.Text != "" ? ExpenseTypeBox.Text : "";
                        exp.Type = (ExpenseType)Enum.Parse(typeof(ExpenseType), type);
                        itemFound = true;
                        break;
                    }
                }

                if (!itemFound)
                {
                    throw new Exception();
                }

                UpdateTotal();
                UpdateDataGrid();
            }
            catch
            {
                summaryBox.Text = "Item not found.";
                summaryBox.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))); // color for error
            }
        }


        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            // error handling for item not found
            try
            {
                bool itemFound = false;
                foreach (Expense exp in expenses)
                {
                    if (ItemNameBox.Text == exp.ItemName)
                    {
                        expenses.Remove(exp);
                        itemFound = true;
                        break;
                    }
                }

                if (!itemFound)
                {
                    throw new Exception();
                }

                UpdateTotal();
                UpdateDataGrid();
            }
            catch
            {
                summaryBox.Text = "Item not found.";
                summaryBox.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))); // color for error
            }
          
        }

        // Serializes and opens second form
        private void SaveBTN_Click(object sender, EventArgs e)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            TextWriter writer = new StreamWriter("myfile.json");
            writer.WriteLine(serializer.Serialize(expenses));
            writer.Close();

            var myForm = new Form2();
            myForm.Show();
        }

        // Clear the text boxes
        private void ClearBTN_Click(object sender, EventArgs e)
        {
            BudgetBox.Text = "";
            AmountBox.Text = "";
            ItemNameBox.Text = "";
            summaryBox.Text = "";
        }
    }
}
