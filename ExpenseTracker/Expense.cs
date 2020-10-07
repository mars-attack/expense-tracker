using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    public enum ExpenseType
    {
        Home,
        Bills,
        Groceries,
        Personal,
        Transit,
        School,
        Misc
    }

    public class Expense
    {
        public string ItemName { get; set; }
        public double Amount { get; set; }
        public ExpenseType Type { get; set; }

        public Expense()
        {

        }

        public Expense(string itemname, double amount, ExpenseType type)
        {
            ItemName = itemname;
            Amount = amount;
            Type = type;
        }

        public override string ToString()
        {
            return $"{ItemName} - {Amount} - {Type}";
        }

    }


    // Custom Generic Struct (Class with all public members)
    public struct MyList<T1, T2, T3>
    {
        public readonly T1 Item1;
        public readonly T2 Item2;
        public readonly T3 Item3;
        public MyList(T1 item1, T2 item2, T3 item3) { Item1 = item1; Item2 = item2; Item3 = item3; }
    }
}
