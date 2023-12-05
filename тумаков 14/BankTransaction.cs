using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_14
{
    public enum bank : int
    {
        tecuchy = 135000,
        sbereg = 120000
    }
    internal class BankTransaction
    {
        public DateTime Date { get; }
        public int Money { get; }
        public bool Flag { get; }

        public BankTransaction(int money)
        {
            Money = money;
            Date = DateTime.Now;
        }
    }
}
