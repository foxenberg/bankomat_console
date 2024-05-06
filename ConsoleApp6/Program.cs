using ConsoleApp6;

//восходящее неявное преобразование 
Employee employee = new Employee("Nvidia", "Ruslan");
Person person = employee;
Console.WriteLine(person.Name);
Person david = new Client("Tinkoff", "David");

object person1 = new Employee("name1", "Microsoft");  // от Employee к object
object person2 = new Client("name2", "BankName");  // от Client к object
object person3 = new Person("name3");                 // от Person к object

//нисходящее явное преобразование 
Employee employee1 = new Employee("Nvidia", "Ruslan");
Person person4 = employee;

//Employee employee2 = person4;
Employee employee2 = (Employee)person4;

object obj = new Employee("Ubisoft", "Bob");
Employee empl = (Employee)obj;

Person pers = new Client("Sber", "Oleg");
Client client = (Client)pers;


((Person)obj).PrintInfo();
//Ошибки преобразования типов

//string bank = ((Client)obj).Bank; // !Ошибка
//Employee employee1 = new Person("Tom"); // ! Ошибка
//Person person = new Person("Bob");
//Employee employee2 = (Employee)person; // ! Ошибка


Person andrew = new Person("Andrew");
Employee? employee3 = andrew as Employee;
if  (employee3 == null)
{
    Console.WriteLine("Преобразование прошло неудачно");
}
else
{
    Console.WriteLine(employee3.Company);
}


Person nikita = new Person("Nikita");

if (nikita is Employee employee4)
{
    Console.WriteLine(employee4.Company);
}
else
{
    Console.WriteLine("Преобразование прошло неудачно");
}