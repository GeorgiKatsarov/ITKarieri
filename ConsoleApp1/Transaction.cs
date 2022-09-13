using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Transaction
    {
        private decimal amount;
        private DateTime date;
        private string notes;

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }


        public Transaction(decimal sum, DateTime datenow, string notesf)
        {
            this.Amount = sum;
            this.Date = datenow;
            this.Notes = notesf;
        }
    }
}
