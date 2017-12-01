using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication59
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> liczby = new List<int>();
            //liczby.Add(5);
            //liczby.Add(-2);
            //liczby.Add(3);
            //liczby.Add(-10);
            //liczby.Sort();
            //foreach(var element in liczby)
            //{
            //    Console.WriteLine(element);
            //}

            List<Car> cars = new List<Car>();
            cars.Add(new Car(2010, "Ford"));
            cars.Add(new Car(2016, "Fiat"));
            cars.Add(new Car(2012, "Skoda"));
            cars.Add(new Car(2010, "BMW"));
            cars.Sort();
            foreach(var element in cars)
            {
                Console.WriteLine(element.Info());
            }
            Console.ReadKey();
        }
    }
}
