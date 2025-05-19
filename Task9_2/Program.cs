namespace Task9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount();
            while (true)
            {
                Console.WriteLine("Введите число чтобы выбрать действие: \n 1 - Пополнить счет \n 2 - Снять со счета \n 3 - Показать общее количество созданных счетов");
                if (!int.TryParse(Console.ReadLine(), out int result))
                {
                    Console.WriteLine("Введите одно из указанных чисел");
                    continue;
                }
                
                if (result == 1)
                {
                    Console.Write("Введите сумму депозита: ");
                    if (int.TryParse(Console.ReadLine(), out int amount))
                    {
                        account2.Deposit(amount);
                        Console.WriteLine($"Счет пополнен на {amount} у.е. Новый баланс счета: {account2.Balance} у.е.");
                    }
                    else
                    {
                        Console.WriteLine("Введите числовое значение");
                    }
                }

                if (result == 2)
                {
                    Console.Write("Введите снимаемую сумму: ");
                    try
                    {
                        if (int.TryParse(Console.ReadLine(), out int amount))
                        {
                            account2.Withdraw(amount);
                            Console.WriteLine($"Со счета снято {amount} у.е. Новый баланс счета: {account2.Balance} у.е.");
                        }
                        else
                        {
                            Console.WriteLine("Введите числовое значение");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                if (result == 3)
                {
                    account2.ShowTotalAccounts();
                }

                Console.WriteLine();
            }

        }
    }
}
