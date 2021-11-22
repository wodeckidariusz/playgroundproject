using System;

namespace PlaygroundProject
{
    public class Vehicle //internal by default
    {
        private string _name;

        public Vehicle()
        {
        }
        internal string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void describe()
        {
            Console.WriteLine("Generic vehicle. Some wheels and driving gear.");
        }
        protected virtual void display()
        {
            Console.WriteLine("Just a random vehicle with some name.");
        }
    }

    internal class Car : Vehicle
    {
        private int _capacity;

        internal int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }
        protected override void display()
        {
            Console.WriteLine("4 wheels and fuel engine.");
        }
    }

    internal class SportCar : Car
    {
        internal void displayCapacity()
        {
            Console.WriteLine($"Sport car capacity is: { base.Capacity }"); //Capacity available while SportCar derives from Car
        }
    }

    class Bike
    {
        public Vehicle vehicle = new Vehicle();
        protected void display()
        {
            vehicle.Name = "Bike"; //vehicle name accessible while it's just internal (not protected) so deriving from base class not needed
        }
        
    }
}
