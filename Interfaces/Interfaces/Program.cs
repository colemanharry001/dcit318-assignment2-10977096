using System;

namespace MovableDemo
{
    // Define the interface IMovable
    interface IMovable
    {
        void Move();
    }

    // Create a class Car that implements IMovable
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Create a class Bicycle that implements IMovable
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Car and Bicycle
            IMovable myCar = new Car();
            IMovable myBicycle = new Bicycle();

            // Call the Move method on each instance
            myCar.Move();
            myBicycle.Move();
        }
    }
}
