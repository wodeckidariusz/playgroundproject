using System;

namespace PlaygroundProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Animal
    {
        private string _animalAge;
        public string AnimalAge
        {
            get { return _animalAge; }
            set { _animalAge = value; }
        }
    }
}
