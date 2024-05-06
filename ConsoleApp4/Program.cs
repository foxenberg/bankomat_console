//Calculate(4);
//static void Calculate(int e)
//{
//    int x = 10;
//    int y = 7;
//    int z = y + e;
//}
//class Country
//{
//    public int x;
//    public int y;     
//}
//struct State
//{
//    public int x;
//    public int y;
//    public Country country;
//    public State() 
//    { 
//        x = 0;
//        y = 0;
//        country = new Country();

//    }
//}
//class Person()
//{
//    string name;
//    void Write()
//    {
//        double weight = 0;
//        Console.WriteLine(name);
//        if (weight > 100) 
//        {
//            string str;
//            Console.WriteLine("go to the gym");
//        }
//    }
//}
//class Status
//{

//    // все равно, что private string defaultVar;
//    string defaultVar = "default";
//    // поле доступно только из текущего класса
//    private string privateVar = "private";
//    // доступно из текущего класса и производных классов, которые определены в этом же проекте
//    protected private string protectedPrivateVar = "protected private";
//    // доступно из текущего класса и производных классов
//    protected string protectedVar = "protected";
//    // доступно в любом месте текущего проекта
//    internal string internalVar = "internal";
//    // доступно в любом месте текущего проекта и из классов-наследников в других проектах
//    protected internal string protectedInternalVar = "protected internal";
//    // доступно в любом месте программы, а также для других программ и сборок
//    public string publicVar = "public";

//    void Print() => Console.WriteLine(defaultVar);
//}
//class StatusConsumer
//{
//    public void PrintStatus()
//    {
//        Status status = new Status();

//        Console.WriteLine(status.);
//    }
//}

using System;
using System.Runtime.Serialization.Formatters.Binary;
using ConsoleApp4;
using Newtonsoft.Json;

public class Diploma:Certificate
{   
    public string Recipient
    {
        get; set;
    }
    public Diploma(string name, string recipient)
        : base(name)
    {
        Recipient = recipient;
    }
    public void Print()
    {
        Console.WriteLine(name);
    }
    
}

public class Certificate
{
    protected string name;
    private int id;
    private DateTime expireDate;
    private bool isExpired;

    public Certificate (string name)
    {
        Name = name;
    }
    public int Id
    {   
        get
        {
            return id; //get-возвращает значение свойства 
        }
        set
        {
            id = value;//set-устанавливает значение свойства
        }
    }
    public DateTime ExpiryDate
    {
        get
        {
            return expireDate;
        }
        set
        {
            if (value > DateTime.Now)
            {
                Console.WriteLine("Error. You cannot enter a future date.");
            }
            else 
                expireDate = value;
        }
    }
    public void Print()
    {
        Console.WriteLine(Name);
    }
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public bool IsExpired 
    {
        get 
        {
            return isExpired;
        }
        set 
        { 
            isExpired = value; 
        }
    }

    public void CheckExpiry()
    {
        if (DateTime.Now > ExpiryDate)
        {
            IsExpired = true;
        }
        else
        {
            IsExpired = false;
        }
    }
    public int Sum(int x,int y)
    {
        return x + y;
    }
    public int Sum(int x, int y, int z) { return x + y + z; }
    public double Sum(double x, double y) {  return x * y + y; }
    public float Sum(float x, float y) {  return x * y + y; }
    public double Sum(double x, int y) { return x * y + y; }
    public double Sum(double x, int y, int z) { return x + y + z; }
}

class Program
{
    static void Main()
    {
        string nameDiploma = "Название диплома";
        string name = "Название сертификата.";
        string recipient = "Участник";
        //экземпляр класса 
        Certificate certificate = new Certificate(name) 
        {
            Id = 1,
            ExpiryDate = new DateTime(2021, 12, 31),
            Name = "Example Certificate",
            IsExpired = false
        };
        Certificate c = new Diploma(nameDiploma, recipient);
        

        Console.WriteLine(certificate.Name);
        certificate.Name = "Real Certificate";
        Console.WriteLine(certificate.Name);
        Console.WriteLine(certificate.Sum(25,2));
        Console.WriteLine(certificate.Sum(25,56));
        Console.WriteLine(certificate.Sum(34,17));
        Console.WriteLine(certificate.Sum(14, 71));
        Console.WriteLine(certificate.Sum(52, 72, 82));
        int id = certificate.Id;
        

        Console.WriteLine("Enter today's date (yyyy-mm-dd):");
        string inputDate = Console.ReadLine();
        DateTime currentDate = Convert.ToDateTime(inputDate);
        DateTime date = DateTime.Now;
        certificate.ExpiryDate = currentDate;
        string json = JsonConvert.SerializeObject(certificate);
        Console.WriteLine(json);
        certificate.CheckExpiry();

        if (certificate.IsExpired)
        {
            Console.WriteLine("The certificate has expired.");
        }
        else
        {
            Console.WriteLine("The certificate is still valid.");
        }
        Car toyota = new Car("Toyota", 2015, 15000.0);
        toyota.DisplayInfo();
        Car2 bmw = new Car2("BMW", 2018, 25000.0, 200);
        bmw.DisplayInfo();
        string jsoncar = JsonConvert.SerializeObject(toyota);
        Console.WriteLine(jsoncar);
    }
}
