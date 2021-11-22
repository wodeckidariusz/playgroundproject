using System;

namespace PlaygroundProject
{
    class Program : Car
    {
        static void Main(string[] args)
        {
            #region Polymorphism

            /*Animal animal = new Animal(10);
            Animal dog = new Dog(12, "Owner's best friend.");
            Animal cat = new Cat(5, "Catching mice.");

            //Cat cat1 = new Animal(12); -> Wrong while parent (base) class doesn't inherit from child (Cat) class

            animal.makeNoise();
            dog.makeNoise();
            cat.makeNoise();

            Dog pureDog = new Dog(12, "Owner's best friend.");
            Cat pureCat = new Cat(12, "Catching mice.");
            Wolf pureWolf = new Wolf(4, "Hunter.");

            animal = (Animal)pureDog; //upcasting - not always possible
            pureWolf = (Wolf)animal; //downcasting - always possible

            Animal animal1 = new Dog(12, "Sth");
            Wolf wolf1 = (Wolf)animal1;
            Dog dog1 = (Dog)wolf1;
            dog1.makeNoise();*/

            #endregion

            #region Abstractions

            /*Stock stock = new Stock(12, 33);
            stock.display(); //calling abstract method*/

            #endregion

            #region Acces modifiers

            /*Car car = new SportCar();
            car.Capacity = 12; //ok while the same assembly
            SportCar sportCar = (SportCar) car;
            sportCar.displayCapacity();

            Console.ReadLine();*/

            #endregion
        }
    }
}
