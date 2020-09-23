using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladdTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Volvo", 2010);
            Console.WriteLine($"En {car.model} som är {car.year} och är nu {car.age} år {(car.age < 5?"ny":"gammal")}");
        }
    }

   
    class Car
    {
        public string model;
        public int year;
        public int age; 
        public Car(string modelName, int modelYear)
        {
            model = modelName;
            year = modelYear;
            age = 2020 - modelYear;
        }
    }
    
}