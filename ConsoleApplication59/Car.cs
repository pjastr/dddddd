using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication59
{
    class Car:IComparable<Car>
    {
        private int year;
        private string brand;

        public Car(int year, string brand)
        {
            this.year = year;
            this.brand = brand;
        }

        public int CompareTo(Car other)
        {
            return other.brand.CompareTo(this.brand);
        }

        public string Info()
        {
            return brand + " " + year;
        }
    }
}
