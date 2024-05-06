//Animal animal = new Animal();
//animal.name = "horse";
//animal.location = "africa";
//animal.age = 8;
//animal.weight = 65.2;
//animal.predator = false;
//animal.Print();

//class Animal
//{
//    public string name;
//    public string location;
//    public int age;
//    public double weight;
//    public bool predator;
//    public void Print()
//    {
//        Console.WriteLine($"Animal {name} , {age} , {weight} , {predator}");
//    }

//}
//var m = Environment.Version;
//Console.WriteLine(m.GetType());
//string str = m.ToString();
//Console.WriteLine(str);
//Version vers = (Version)m.Clone();
//Console.WriteLine(vers);

//UserInfo user1 = new UserInfo();
//user1.name = "Ivan";
//user1.email = "user@email.com";
//user1.password = "password";
//user1.WriteUserInfo();
//UserInfo user2 = new UserInfo();
//user2.name = "Ruslan";
//user2.email = "user2@email.com";
//user2.password = "password2";
//Console.WriteLine(Object.Equals(user2, user1));
//Console.WriteLine(Object.Equals(user2, user2));
//class UserInfo
//{
//    public string name;
//    public string email;
//    public string password;

//    public void WriteUserInfo()
//    {
//        Console.WriteLine("Имя: {0}\nПочта: {1}\nПароль: {2}", email, name, password);
//    }
//}

Console.WriteLine("Введите, что хотите найти");
string s = Console.ReadLine();
MathOperations mathOperations = new MathOperations();
Console.WriteLine(mathOperations.Printinfo(s));
class MathOperations
{
    double GetLenghtRound(double r) => 2 * Math.PI * r;

    double GetSqrRound(double r) => Math.PI * Math.Pow(r, 2);

    public double Printinfo(string s)
    {
        Console.WriteLine("Введите радиус");
        int r = Convert.ToInt32(Console.ReadLine());

        return s switch
        {
            "Длина" => GetLenghtRound(r),
            "Площадь" => GetSqrRound(r),
            _ => 0.00,
        };
    }
}
//string GetMessege()
//{
//    return "Hello";
//}
//string GetMessege2() => "Hello";

//int Sum(int x, int y)  => x + y;    

//ПЕРЕЧИСЛЕНИЕ
// Daytime daytime = Daytime.morning;

//if (daytime == Daytime.morning)
//{
//    Console.WriteLine("Доброе утро");
//}
//else if (daytime == Daytime.night)
//{
//    Console.WriteLine("Спокойной ночи");
//}
//enum Daytime
//{
//    morning,
//    afternoon,
//    night

//}

//void Main()
//{
//    DoOperation(10, 2, Operation.Addition);
//    DoOperation(10, 2, Operation.Subtraction);
//    DoOperation(10, 2, Operation.Multiplication);
//    DoOperation(10, 2, Operation.Division);
//}

//void DoOperation(double x, double y, Operation operation)
//{
//    double result = operation switch
//    {
//        Operation.Addition  => x + y,
//        Operation.Subtraction  => x - y,
//        Operation.Multiplication  => x * y,
//        Operation.Division  => x / y
//    }(x, y);

//    Console.WriteLine(result);
//};

//enum Operation
//{
//    Addition,
//    Subtraction,
//    Multiplication,
//    Division
//}

//DoOperation(10,2, Operation.Addition, Operation.Subtraction, Operation.Multiplication, Operation.Division);
// void DoOperation(double x, double y, Operation operation)
//{
//    double result = operation switch
//    {
//        Operation.Addition => x + y, 
//        Operation.Subtraction => x - y,
//        Operation.Multiplication => x * y,
//        Operation.Division => x / y,             
//    };
//    Console.WriteLine(result);
//}
//enum Operation
//{
//    Addition,
//    Subtraction,
//    Multiplication,
//    Division
//}

