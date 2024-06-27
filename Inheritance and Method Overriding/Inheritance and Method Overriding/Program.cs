using System;

namespace OOPDemo
{
    // Define the base class Animal
    class Animal
    {
        // Virtual method to be overridden in derived classes
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Define the derived class Dog
    class Dog : Animal
    {
        // Override the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Define the derived class Cat
    class Cat : Animal
    {
        // Override the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Animal, Dog, and Cat
            Animal myAnimal = new Animal();
            Dog myDog = new Dog();
            Cat myCat = new Cat();

            // Call the MakeSound method on each instance
            myAnimal.MakeSound();
            myDog.MakeSound();
            myCat.MakeSound();
        }
    }
}
