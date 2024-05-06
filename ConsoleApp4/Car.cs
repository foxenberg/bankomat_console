using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Car
    {
        private string brand;
        private int productionYear;
        private double price;

        public Car(string brand, int productionYear, double price)
        {
            this.brand = brand;
            this.productionYear = productionYear;
            this.price = price;
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int ProductionYear
        {
            get { return productionYear; }
            set
            {
                if (value <= DateTime.Now.Year)
                {
                    productionYear = value;
                }
                else
                {
                    Console.WriteLine("Invalid production year input.");
                }
            }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {brand}, Year: {productionYear}, Price: {price}");
        }

        public void CalculateValue(string currency)
        {
            double exchangeRate = GetExchangeRate(currency);
            Console.WriteLine($"Price in {currency}: {price * exchangeRate}");
        }

        private double GetExchangeRate(string currency)
        {
            // Simulated method to get exchange rate
            if (currency == "USD")
            {
                return 0.85;
            }
            else if (currency == "EUR")
            {
                return 1.13;
            }
            else
            {
                return 1.0;
            }
        }

        public static Car operator +(Car car1, Car car2)
        {
            return new Car($"Combined {car1.Brand} {car2.Brand}",
                           Math.Max(car1.ProductionYear, car2.ProductionYear),
                           car1.Price + car2.Price);
        }

        public static Car operator -(Car car1, double discount)
        {
            return new Car(car1.Brand, car1.ProductionYear, car1.Price - discount);
        }
    }

    internal class Car2 : Car
    {
        private int speed;

        public Car2(string brand, int productionYear, double price, int speed)
            : base(brand, productionYear, price)
        {
            this.speed = speed;
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public void DisplaySpeed()
        {
            Console.WriteLine($"Speed: {speed} km/h");
        }
    }
}