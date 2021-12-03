using System;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BankAccount<int> account1 = new BankAccount<int>();
            account1.AccountNumber = 354687;
            account1.AccountBalance = 354.44;
            account1.AccountFio = "Иванов Иван Иваныч";
            account1.Read();
            BankAccount<string> account2 = new BankAccount<string>();
            account2.AccountNumber = "225432";
            account2.AccountBalance = 634.11;
            account2.AccountFio = "Васильев Василий Васильевич";
            account2.Read();

        }
    }
    class BankAccount<T>
    {
        public T AccountNumber { get; set; }
        public double AccountBalance { get; set; }
        public string AccountFio { get; set; }

        public void Read()
        {
            Console.WriteLine("Номер аккаунта: {0}",AccountNumber);
            Console.WriteLine("Ваш баланс: {0}",AccountBalance);
            Console.WriteLine("Фамилия Имя Отчество: {0}",AccountFio);
        }
        
    }
}
