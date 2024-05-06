using System.Security.Principal;

class Program
{
    public const int MaxInvalidPinAttempts = 3;
    public static Account account;
    public static int invalidPinAttempts = 1;
    static void Main(string[] args)
    {
        account = new Account(1000, 1234);
        Console.WriteLine("Добро пожаловать в банкомат.");
        
        while (true)
        {
            if(invalidPinAttempts >=  MaxInvalidPinAttempts)
            {
                Console.WriteLine("Карта заблокирована");
                break;
            }
            Console.WriteLine("Введите PIN-код: ");
            int pin = int.Parse(Console.ReadLine());
            if (pin != account.Pin) 
            {
                invalidPinAttempts++;
                break;
            }
            else { 
                invalidPinAttempts = 1;
                
            }
            Console.WriteLine("Введите команду");
            Console.WriteLine("1.Узнать баланс");
            Console.WriteLine("2.Снять/Положить деньги");
            Console.WriteLine("3.Поменять PIN-код");
            Console.WriteLine("4.Выйти");
            
            int command = int.Parse(Console.ReadLine());
            switch(command)
            {
                case 1:
                    Console.WriteLine("Баланс:{0}",account.Balance);
                    break;
                case 2:
                    Console.Write("Введите сумму: ");
                    int amount = int.Parse(Console.ReadLine());

                    Console.Write("Снять/Положить (1/2): ");
                    int action = int.Parse(Console.ReadLine());

                    if (action == 1)
                    {
                        account.Withdraw(amount);
                    }
                    else if (action == 2)
                    {
                        account.Deposit(amount);
                    }
                    break;
                case 3:
                    Console.Write("Введите новый PIN-код: ");
                    int newPin = int.Parse(Console.ReadLine());

                    account.ChangePin(newPin);
                    break;
                case 4:
                    Console.WriteLine("Всего хорошего.");
                    return;
                default:
                    Console.WriteLine("Неверная команда.");
                    break;
            }
        }
    }
}

public class Account
{
    public int Balance { get; set; }
    public int Pin { get;  set; }

    public Account(int balance, int pin)
    {
        Balance = balance;
        Pin = pin;
    }

    public void Withdraw(int amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Недостаточно средств.");
        }
    }

    public void Deposit(int amount)
    {
        Balance += amount;
    }
    /// <summary>
    /// fdsfdf
    /// </summary>
    /// <param name="newPin"></param>
    public void ChangePin(int newPin)
    {
        Pin = newPin;

    }
} 
  