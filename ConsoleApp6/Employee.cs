using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Employee:Person
    {
        public string Company {  get; set; }
        public Employee(string company, string name) :base(name) 
        {
            Company = company;
        }
        
    }
}
