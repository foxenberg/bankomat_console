Transport car = new Car("Tesla");
Transport ship = new Ship("Titanic");
Transport aeroplain = new Aircraft("B19");


car.Move();
ship.Move();
aeroplain.Move();

var rectangle = new Rectangle
{
    Height = 200,
    Weight = 200,
};
var circle = new Circle
{
    Radius = 10,
};

Console.WriteLine(rectangle.ToString());
Console.WriteLine(circle.GetType());
if (circle.GetType() == typeof(Circle))
{
    Console.WriteLine("Верно");
}
Console.WriteLine(rectangle.Equals(circle)); 

Clock clock = new Clock { Hours = 15, Minutes = 34, Seconds = 53 };
Console.WriteLine(clock.ToString()); // выведет 15:34:53

class Clock
{

    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }
    public override string ToString()
    {
        return $"{Hours}:{Minutes}:{Seconds}";
    }
}
//void PrintShape(Shape shape)
//{
//    Console.WriteLine($"Perimeter: {shape.GetPerimetr()}  Area: {shape.GetArea()}");
//}
//PrintShape(circle);
//PrintShape(rectangle);
abstract class Transport
{
    public string Name { get; }
    // конструктор абстрактного класса Transport
    public Transport(string name)
    {
        Name = name;
    }
    public void Move() => Console.WriteLine($"{Name} движется");
}
// класс корабля
class Ship : Transport
{
    // вызываем конструктор базового класса
    public Ship(string name) : base(name) { }
}
// класс самолета
class Aircraft : Transport
{
    public Aircraft(string name) : base(name) { }
}
// класс машины
class Car : Transport
{
    public Car(string name) : base(name) { }
}

abstract class Shape()
{
    public abstract double GetPerimetr();
    public abstract double GetArea();
}
class Rectangle : Shape
{
    public double Weight { get; set; }
    public double Height {  get; set; }
    public override double GetArea()
    {
        return Weight * Height;
    }
    public override double GetPerimetr()
    {
        return (Weight+Height) * 2;
    }
    public string Name { get; set; } = "";
    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }

}
class Circle : Shape
{
    public double Radius {  get; set; }

    public override double GetArea()
    {
        return Math.PI * Radius*Radius;
    }
    public override double GetPerimetr()
    {
        return 2 * Math.PI * Radius;
    }
}