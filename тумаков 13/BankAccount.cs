using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_13
{
    
    internal class BankAccount
    {
        private static int account_number;
        private int balance;
        private bank type;
        private System.Collections.Queue transactions;

        public int AccountNumber { get; }
        public int Balance { get { return balance; } }
        public bank Type { get { return type; } }
        public string Holder { get; set; }
        private List<BankTransaction> transactions1;

        public BankAccount()
        {
            transactions1 = new List<BankTransaction>();
        }

        // Индексатор
        public BankTransaction this[int index]
        {
            get { return transactions1[index]; }
            set { transactions1[index] = value; }
        }

        public void AddTransaction(int money)
        {
            transactions1.Add(new BankTransaction(money));
        }

        private static int SetAccountNumber()
        {
            account_number++;
            return account_number;
        }
        public void increaseMoney(int money)
        {
            BankTransaction transaction = new BankTransaction(money);
            transactions.Enqueue(transaction);
            this.balance = this.balance + money;
        }

        public void decreaseMoney(int money)
        {
            BankTransaction transaction = new BankTransaction(money);
            transactions.Enqueue(transaction);
            this.balance = this.balance + money;
        }
        public BankAccount(int balance)
        {
            BankTransaction transaction = new BankTransaction(this.balance - balance);
            transactions.Enqueue(transaction);
            this.balance = balance;
            SetAccountNumber();
        }

        public BankAccount(bank type)
        {
            this.type = type;
            SetAccountNumber();
        }
        public BankAccount(int balance, bank type)
        {
            BankTransaction transaction = new BankTransaction(this.balance - balance);
            transactions.Enqueue(transaction);
            this.balance = balance;
            this.type = type;
        }
        public void Dispose()
        {
            using (StreamWriter writer = new StreamWriter("transactions.txt"))
            {
                foreach (var transaction in transactions)
                {
                    writer.WriteLine(transaction);
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}
