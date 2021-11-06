using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T17
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> bankAccount1 = new BankAccount<int>(125, 1500.5, "Иванов Иван Иванович");
            Print<int>(bankAccount1.AccountId);
            Print2(bankAccount1.AccountInfo, bankAccount1.AccountHolder);

            Console.WriteLine();

            BankAccount<string> bankAccount2 = new BankAccount<string>("А120", 25000.0, "Петров Петр Петрович");
            Print<string>(bankAccount2.AccountId);
            Print2(bankAccount2.AccountInfo, bankAccount2.AccountHolder);

            Console.ReadKey();
        }
        static void Print<T>(T value)
        {
            Console.WriteLine("Номер счета: {0}", value);
        }
        static void Print2(double value1, string value2)
        {
            Console.WriteLine("Баланс: {0}", value1);
            Console.WriteLine("ФИО владельца: {0}", value2);
        }
    }
    class BankAccount<T>
    {
        private T accountId;
        private double accountInfo;
        public string AccountHolder { get; set; }
        public T AccountId
        {
            set
            {
                if (value != null)
                {
                    accountId = value;
                }
                else
                {
                    Console.WriteLine("Баланс не может быть отрицательным");
                }
            }
            get
            {
                return accountId;
            }
        }
        public double AccountInfo
        {
            set
            {
                if (value >= 0)
                {
                    accountInfo = value;
                }
                else
                {
                    Console.WriteLine("Баланс не может быть отрицательным");
                }
            }
            get
            {
                return accountInfo;
            }
        }
        public BankAccount(T accountId, double accountInfo, string accountHolder)
        {
            AccountId = accountId;
            AccountInfo = accountInfo;
            AccountHolder = accountHolder;
        }
    }
}
