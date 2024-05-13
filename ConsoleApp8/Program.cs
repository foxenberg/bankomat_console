using System.Security.Principal;

class Program
{
    // Максимальное количество попыток ввода неверного PIN-кода
    private const int MaxInvalidPinAttempts = 3;

    // Объект Account, представляющий учетную запись пользователя
    private static Account _account;

    // Количество попыток ввода неверного PIN-кода
    private static int _invalidPinAttempts;

    static void Main(string[] args)
    {
        // Создание нового объекта Account с начальным балансом 1000 и PIN-кодом 1234
        _account = new Account(1000, 1234);

        Console.WriteLine("Добро пожаловать в банкомат.");

        while (true)
        {
            // Проверка, не достигнуто ли максимальное количество попыток ввода неверного PIN-кода
            if (_invalidPinAttempts >= MaxInvalidPinAttempts)
            {
                Console.WriteLine("Карта заблокирована.");
                break;
            }

            Console.Write("Введите PIN-код: ");
            if (!int.TryParse(Console.ReadLine(), out int pin))
            {
                Console.WriteLine("Неверный формат PIN-кода.");
                _invalidPinAttempts++;
                continue;
            }

            if (pin != _account.Pin)
            {
                Console.WriteLine("Неверный PIN-код.");
                _invalidPinAttempts++;
            }
            else
            {
                _invalidPinAttempts = 0;

                Console.WriteLine("Введите команду:");
                Console.WriteLine("1. Узнать баланс");
                Console.WriteLine("2. Снять/Положить деньги");
                Console.WriteLine("3. Поменять PIN-код");
                Console.WriteLine("4. Выйти");

                if (!int.TryParse(Console.ReadLine(), out int command))
                {
                    Console.WriteLine("Неверный формат команды.");
                    continue;
                }

                switch (command)
                {
                    case 1:
                        // Вывод текущего баланса
                        Console.WriteLine("Баланс: {0}", _account.Balance);
                        break;
                    case 2:
                        Console.Write("Введите сумму: ");
                        if (!int.TryParse(Console.ReadLine(), out int amount))
                        {
                            Console.WriteLine("Неверный формат суммы.");
                            break;
                        }

                        Console.Write("Снять/Положить (1/2): ");
                        if (!int.TryParse(Console.ReadLine(), out int action) || (action != 1 && action != 2))
                        {
                            Console.WriteLine("Неверный формат действия.");
                            break;
                        }

                        if (action == 1)
                        {
                            // Снятие денег с текущего баланса
                            _account.Withdraw(amount);
                        }
                        else if (action == 2)
                        {
                            // Пополнение текущего баланса
                            _account.Deposit(amount);
                        }
                        break;
                    case 3:
                        Console.Write("Введите новый PIN-код: ");
                        if (!int.TryParse(Console.ReadLine(), out int newPin))
                        {
                            Console.WriteLine("Неверный формат PIN-кода.");
                            break;
                        }// Изменение PIN-кода

                        _account.ChangePin(newPin);
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

    private class Account
    {
        // Свойство Balance представляет текущий баланс счета
        // Доступ к изменению имеет только класс Account
        public int Balance { get; private set; }
        public int Pin { get; private set; }
        // Свойство Pin представляет пин-код счета
        // Доступ к изменению имеет только класс Account
        public Account(int balance, int pin)
        {
            Balance = balance;
            Pin = pin;
        }

        // Конструктор класса Account инициализирует баланс и пин-код
        public void Withdraw(int amount)
        {
            // Метод Withdraw снимает указанную сумму со счета
            // Если на счете недостаточно средств, выводится сообщение:
            // public void Withdraw(int amount)

            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Недостаточно средств.");
            }
        }

        // Метод Deposit пополняет счет на указанную сумму
        public void Deposit(int amount)
        {
            Balance += amount;
        }
        /// <summary>
        /// Метод ChangePin изменяет пин-код счета на новый
        /// </summary>
        /// <param name="newPin">Новый пин-код</param>
        public void ChangePin(int newPin)
        {
            Pin = newPin;

        }
    }
}
  