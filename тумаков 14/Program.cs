using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 14.1");
            Console.WriteLine("метод DumpToScreen");
            BankAccount account = new BankAccount(1000, bank.tecuchy);
            account.DumpToScreen();

            Console.WriteLine("Домашнее задание 14.1");
            Console.WriteLine("Создать аттрибут");
            Console.ReadKey();
        }
    }
}
