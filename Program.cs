using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myAnimal.MakeSound();
        myDog.MakeSound();
        myCat.MakeSound();

        Shape myCircle = new Circle(5.0);
        Shape myRectangle = new Rectangle(4.0, 6.0);

        Console.WriteLine($"Circle Area: {myCircle.GetArea()}");
        Console.WriteLine($"Rectangle Area: {myRectangle.GetArea()}");


        IMovable myCar = new Car();
        IMovable myBicycle = new Bicycle();

        myCar.Move();
        myBicycle.Move();


    }
}
