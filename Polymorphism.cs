using System;

namespace PlaygroundProject
{
    public class Animal
    {
        private int _animalAge;

        public Animal(int age)
        {
            _animalAge = age;
        }
        public int AnimalAge
        {
            get { return _animalAge; }
            set { _animalAge = value; }
        }
        public virtual void makeNoise()
        {
            Console.WriteLine("Generic animal's noise: sssss");
        }
    }

    public class Cat : Animal
    {
        private int _animalAge;
        private string _behavior;

        public Cat(int age, string behavior) : base(age)
        {
            _animalAge = age;
        }
        public string Behavior
        {
            get { return _behavior; }
            set { Behavior = _behavior; }
        }

        public override void makeNoise()
        {
            Console.WriteLine("Cat's noise: meowwww!");
        }
    }

    public class Wolf : Animal
    {
        private int _animalAge;
        private string _behavior;

        public Wolf(int age, string behavior) : base(age)
        {
            _animalAge = age;
        }
        public string Behavior
        {
            get { return _behavior; }
            set { Behavior = _behavior; }
        }

        public override void makeNoise()
        {
            Console.WriteLine("Wolf's noise: auuuuuu!");
        }
    }

    public class Dog : Wolf
    {
        public Dog(int age, string behavior) : base(age, behavior)
        {

        }

        public override void makeNoise()
        {
            Console.WriteLine("Dog's noise: wow wow!");
        }
    }
}
