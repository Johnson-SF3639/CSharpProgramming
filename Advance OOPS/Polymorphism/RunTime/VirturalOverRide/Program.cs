using System;
namespace SealedMethod{
    class Program{
        public static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.MakeSound();

            Dog dog = new Dog();
            dog.MakeSound();

        }
    }
}