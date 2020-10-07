using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;


namespace ExpenseTracker
{
    /*
    * Marianne Palmer
    * 301122149
    * COMP123-005
    * Test 2 - Summer 2020
    */
    public partial class Form2 : Form
    {
        public Form2()
        {
            DataTable dt = new DataTable();

            InitializeComponent();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            TextReader reader = new StreamReader("myfile.json");
            List<Expense> expenses = serializer.Deserialize<List<Expense>>(reader.ReadToEnd());

            MyList<string, string, string> headings = new MyList<string, string, string>("Expense", "Amount", "Type");

 
            dt.Columns.Add(headings.Item1);
            dt.Columns.Add(headings.Item2);
            dt.Columns.Add(headings.Item3);
            foreach (Expense e in expenses)
            {
                dt.Rows.Add(e.ItemName, e.Amount, e.Type);
            }
            dataGridView1.DataSource = dt;
            reader.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text += Convert.ToString(ExpenseTrackerMain.budgetAmount);
            label3.Text += Convert.ToString(ExpenseTrackerMain.remainBudget);
        }
    }
}
