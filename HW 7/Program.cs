using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_упр_7_1
{


    // Перечислимый тип для видов банковского счёта (из упр. 3.1)
    public enum AccountType
    {
        Current,   // Текущий
        Savings    // Сберегательный
    }

    // Класс "Счёт в банке"
    public class BankAccount
    {
        // Закрытые поля
        private string accountNumber;
        private decimal balance;
        private AccountType accountType;

        // Публичные свойства для доступа к данным (заполнение и чтение)
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public AccountType AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }

        // Конструктор по умолчанию
        public BankAccount() { }

        // Конструктор с параметрами (для удобства заполнения)
        public BankAccount(string number, decimal initialBalance, AccountType type)
        {
            accountNumber = number;
            balance = initialBalance;
            accountType = type;
        }

        // Метод для вывода информации об объекте
        public void PrintInfo()
        {
            Console.WriteLine($"Номер счёта: {accountNumber}");
            Console.WriteLine($"Баланс: {balance:C}");
            Console.WriteLine($"Тип счёта: {accountType}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Создание объекта класса
            BankAccount account = new BankAccount();

            // Заполнение полей через свойства
            account.AccountNumber = "40817810099910004312";
            account.Balance = 15000.75m;
            account.AccountType = AccountType.Savings;

            // Вывод информации об объекте
            Console.WriteLine("Информация о банковском счёте:");
            account.PrintInfo();

            // Демонстрация перечисления (как в упр. 3.1)
            AccountType myType = AccountType.Current;
            Console.WriteLine($"\nПример переменной перечисления: {myType}");
        }
    }

}
gef
