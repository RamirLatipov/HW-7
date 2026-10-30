using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_упр_7._2
{



    // Тип банковского счета — перечислимый тип из упр. 3.1
    public enum BankAccountType
    {
        Current,   // текущий
        Savings    // сберегательный
    }

    public class BankAccount
    {
        // Статическая переменная для генерации уникальных номеров счетов
        private static long _nextAccountNumber = 1_000_000_000L;

        private readonly long _accountNumber; // генерируется автоматически
        private decimal _balance;
        private BankAccountType _type;

        public BankAccount(BankAccountType type, decimal initialBalance)
        {
            if (initialBalance < 0)
                throw new ArgumentException("Начальный баланс не может быть отрицательным");

            _accountNumber = GenerateAccountNumber();
            _type = type;
            _balance = initialBalance;
        }

        // Статический метод увеличивает счетчик и возвращает новый уникальный номер
        private static long GenerateAccountNumber()
        {
            return ++_nextAccountNumber;
        }

        // Методы чтения
        public long AccountNumber => _accountNumber;
        public decimal Balance => _balance;
        public BankAccountType Type => _type;

        // Методы заполнения/изменения
        public void SetType(BankAccountType type)
        {
            _type = type;
        }

        public void SetBalance(decimal balance)
        {
            if (balance < 0)
                throw new ArgumentException("Баланс не может быть отрицательным");
            _balance = balance;
        }

        public override string ToString()
        {
            return $"BankAccount{{ AccountNumber = {_accountNumber}, Balance = {_balance}, Type = {_type} }}";
        }
    }

    public class Program
    {
        public static void Main()
        {
            var account1 = new BankAccount(BankAccountType.Savings, 1000m);
            var account2 = new BankAccount(BankAccountType.Current, 500m);

            Console.WriteLine(account1);
            Console.WriteLine(account2);
        }
    }


}


