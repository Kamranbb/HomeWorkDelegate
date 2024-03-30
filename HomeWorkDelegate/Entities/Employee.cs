using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDelegate.Entities
{
    internal class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Addres { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Id {Id} Salary {Salary} Age {Age}";
        }
    }
}
