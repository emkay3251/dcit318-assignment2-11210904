using System;

namespace OOPConceptsDemo
{
    //   INHERITANCE & METHOD OVERRIDING 
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }


    // ABSTRACT CLASSES & METHODS 
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }


    // 3. INTERFACES
    interface IMovable
    {
        void Move();
    }

    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    // MAIN METHOD 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Inheritance & Method Overriding ===");
            Animal genericAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            genericAnimal.MakeSound();  
            dog.MakeSound();            
            cat.MakeSound();            

            Console.WriteLine("\n=== Abstract Classes & Methods ===");
            Shape circle = new Circle(5); 
            Shape rectangle = new Rectangle(4, 6); 

            Console.WriteLine($"Area of Circle: {circle.GetArea():F2}");
            Console.WriteLine($"Area of Rectangle: {rectangle.GetArea():F2}");

            Console.WriteLine("\n=== Interfaces ===");
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();       
            bicycle.Move();   

            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}