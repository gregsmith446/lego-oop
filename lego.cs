using System;

namespace MakeCar
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            var car = new Cars();
            car.color = "Red";
            car.manufacturer = "Toyota";
            console.WriteLine ("Car is a: " + car.color + car.manufacturer);
        }
    }

    public class Cars
    {
        public string color { get; set; }
        public string manufacturer { get; set; }
    }
}
