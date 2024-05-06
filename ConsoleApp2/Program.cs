//Console.WriteLine("Введите сумму");
//double sum = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите количество месяцев");
//int months = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= months; i++)
//{
//    sum += sum*0.07;
//}
//Console.WriteLine(sum);

//while(months > 0)
//int sum = 0;
//int i = Convert.ToInt32(Console.ReadLine());
//int n = Convert.ToInt32(Console.ReadLine()); 
//while (i <= n)
//{
//    sum += i;
//    i++;
//}
//Console.WriteLine(sum);
//int[] mass = new int[] {1, 2, 3, 4, 5, 6 };
//string[] names = new string[] { "Joe", "Vladimir", "Ivan" };
//Console.WriteLine(mass[1]);
//Console.WriteLine(mass[2]);
//Console.WriteLine(names[0]);
//Console.WriteLine(names[names.Length-1]);
//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}
//for (int i = 0; i < mass.Length; i++)
//{
//    mass[i] = mass[i]*2;
//    Console.WriteLine(mass[i]);
//}
//int[] array = { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };
//foreach (int i in array)
//{
//    Console.WriteLine(i);
//}
//for (int i = 0; i < array.Length; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    } 
//}
//Console.WriteLine("///////////////////////////////////////////////////////////////////" +
//    "");
//for (int i = 0; i < array.Length; i++)
//{
//    if (i == -1)
//    {
//        Console.WriteLine(i);   
//    }
//}

//foreach(int l in array)
//{
//    if (l != -1)
//    {
//        Console.WriteLine(l);
//    }
//    if (l == -1)
//    {
//        Console.WriteLine(l);
//        break;
//    }
//}

//int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
////int count = 0;
////foreach(int number in numbers)
////{
////    if (number >= 0)
////    {
////        count++;
////        Console.WriteLine(number);
////    }
////}
////Console.WriteLine("Количество:"+count);
//int len = numbers.Length;
//int k = len / 2;
//int c = 0;
//for (int i = 0; i < k; i++)
//{
//    c = numbers[i];
//    numbers[i] = numbers[len-i-1];
//    numbers[len-i-1] = c;
//}
//foreach(int i in numbers)
//{
//    Console.WriteLine(i);
//}
//void PrintMessege(string messege)
//{
//    Console.WriteLine(messege);
//}
//PrintMessege("привет");
//void Mah(int x , int y)
//{
//    int sum = x + y;
//    Console.WriteLine(sum);
//}
//Mah(20, 7);
//void Bank(int mon , double value)
//{
//    for (int i = 1; i <= mon; i++)
//    {
//        value += value*0.07;
//    }
//    Console.WriteLine(value);

//}
//Console.WriteLine("Введите сумму");
//double sum = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите количество месяцев");
//int months = Convert.ToInt32(Console.ReadLine());
//if (sum <= 100)
//{
//    sum += sum * 0.05;
//}
//else if (sum >= 100 &&  sum <= 200)
//{
//    sum += sum * 0.10;
//}
//for (int i = 1; i <= months; i++)
//{
    
//}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество месяцев");
        int months = Int32.Parse(Console.ReadLine());

        Console.Write("Введите сумму вклада: ");
        double deposit = double.Parse(Console.ReadLine());

        double interestRate;

        if (deposit < 100)
        {
            interestRate = 0.05; // 5%
        }
        else if (deposit >= 100 && deposit <= 200)
        {
            interestRate = 0.07; // 7%
        }
        else
        {
            interestRate = 0.10; // 10%
        }
        // Вычисление общей суммы с начисленными процентами путем умножения суммы вклада на процентную ставку и прибавления суммы вклада к этому
        // результату
        double totalAmount = deposit + (deposit * interestRate);
        for (int i = 1; i <= months; i++)
        {
            totalAmount += totalAmount * 0.07;
        }

        Console.WriteLine("Общая сумма с начисленными процентами: " + totalAmount);
        Car car = new Car();
        car.name = "name car";
        car.Print();

       
    }
}
class Car
{
    public string name;
    public string color;
    public int horsePower;
    public void Print()
    {
        Console.WriteLine(name,color,horsePower);
    }
}