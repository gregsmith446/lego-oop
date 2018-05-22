using System;

namespace car
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            // 2.) instantiate car1 class with color Red and man. Toyota
            Car car1 = new Car ("Red", "Toyota");

            // 5.) instantiate 3 car objects with different properties, each on own line

            // Create object saloonCar1 with 2 seats
            SaloonCar saloonCar1 = new SaloonCar (2);
            // Create object saloonCar2 with 3 seats and manufacturer Nissan
            SaloonCar saloonCar2 = new SaloonCar (3, "Nissan");
            // Create object saloonCar3 with 4 seats, manufacturer ford, and color purple
            SaloonCar saloonCar3 = new SaloonCar (4, "Ford", "Purple");

            Console.WriteLine ("First Car is: " + car1.color + car1.manufacturer);
            Console.WriteLine("The SaloonCar1 has " + saloonCar1.numberOfSeats + " seats");
            Console.WriteLine("The SaloonCar2 is a " + saloonCar2.manufacturer + " with " + saloonCar2.numberOfSeats + " seats");
            Console.WriteLine("The SaloonCar3 is a " + saloonCar3.color + " " + saloonCar3.manufacturer + " with " + saloonCar3.numberOfSeats + " seats");
        }
    }

    // 1.) Car class with properties color + manufacturer
    public class Car
    {
        public Car (string _color, string _manufacturer){
            this.color = _color;
            this.manufacturer = _manufacturer;
        }

        public string color { get; set; }
        public string manufacturer { get; set; }
    }

    // 3.) new SaloonCar class that inherits from above Car class (inheritance)
    // 4.) Write 3 constructors in the SaloonCar Class (Encapsulation)
    public class SaloonCar : Car
    {
        // Constructor 1 allows assignment of numberOfSeats only
        public SaloonCar (int _numberOfSeats) {
            this.numberOfSeats = _numberOfSeats;
        }
        // Constructor 2 allows assignment of numberOfSeats and manufacturer only
        public SaloonCar (int _numberOfSeats, string _manufacturer) {
            this.numberOfSeats = _numberOfSeats;
            this.manufacturer = _manufacturer;
        }

        // Constructor 3 allows assignment of numberOfSeats, manufacturer and color
        public SaloonCar (int _numberOfSeats, string _manufacturer, string _color) {
        this.numberOfSeats = _numberOfSeats;
        this.manufacturer = _manufacturer;
        this.color = _color;
        }
    }

    public int numberOfSeats { get; set; }
}