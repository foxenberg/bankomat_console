using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Person
    {
        public string Name { get; set; }
        public Person(string name) 
        { 
             Name = name;
        }
        public void PrintInfo() 
        {
            Console.WriteLine(Name);
        }
    }
}
