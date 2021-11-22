using System;

namespace PlaygroundProject
{
    public abstract class Building
    {
        private int _size;

        public Building(int size)
        {
            _size = size;
        }
        public int BuildingSize
        {
            get { return _size; }
            set { _size = value; }
        }

        public virtual void describe()
        {
            Console.WriteLine("Just 4 walls and roof. Used for storing anything.");
        }
        public abstract void display();
    }

    public class Stock : Building
    {
        private int _capacity;

        public Stock(int size, int capacity) : base(size)
        {
            _capacity = capacity;
        }
        public int Capacity
        {
            get { return _capacity; }
            set { Capacity = _capacity; }
        }

        public override void display()
        {
            Console.WriteLine("4 walls, roof, shelves");
        }
    }
}
