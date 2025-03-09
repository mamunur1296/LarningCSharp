using LarningCSharp.Class_14;
using System;



//public class Student
//{
//    // member 1
//    //public Student(int a ,int b) // Constructor
//    //{
//    //    Console.WriteLine(a+b);
//    //}
//    // member 2
//    public int Id { get; set; } // Feeld
//    protected string Name { get; set; }
//    protected int Role { get; set; }
//    // member 3
//    public void DesplaySumething() // Method or Functions
//    {

//        Console.WriteLine($"Student Name  : {Name} ");
//    }
//}


//public class Tahim : Student
//{



//}

//class Parent
//{
//    protected string message = "Hello from Parent class!"; // Protected field

//    protected void ShowMessage()
//    {
//        Console.WriteLine(message);
//    }
//}

//class Child : Parent
//{
//    public void Display()
//    {
//        Console.WriteLine("Accessing protected member from derived class:");
//        ShowMessage(); // Accessing protected method from parent class
//    }
//}






// Storage   
//Instance Fields: Stored inside each object.
//Static Fields: Stored in the class's memory, shared by all objects.
public class Example
{
    public int instanceValue;
    public static int staticValue = 0;

    //static void Main()
    //{
    //    var staticNumber = Example.staticValue = 10;
    //    Example obj = new Example();

    //    Console.WriteLine(obj.instanceValue);
    //}
}


// Related To 
// Instance Fields: Belong to individual objects.
//Static Fields: Belong to the entire class.

public class Car
{
    public string model;  //Instance Fields: Declared without the static keyword.
    public static int totalCars; //Static Fields: Declared using the static keyword.

    public Car(string model)
    {
        this.model = model;
        totalCars++;
    }
}
class Program
{

    //static void Main()
    //{
    //    Car car = new Car("X-Corola");  
    //    Car car2 = new Car("Premio");
    //    Car car3 = new Car("Allion");
    //    Console.WriteLine($"{car.model} , {Car.totalCars}");
    //    Console.WriteLine($"{car2.model} , {Car.totalCars}");
    //    Console.WriteLine($"{car3.model} , {Car.totalCars}");
    //}


    // Memory Allocation
    // Instance Fields: A separate copy is created for each object.
    // Static Fields: A single copy is shared by all objects.
    static void Main()
    {
        //var staticNumber = Example.staticValue = 10;
        //Example obj = new Example(); 

        //Console.WriteLine(obj.instanceValue);//Instance Fields: Accessed using an object.
        //Console.WriteLine(Example.staticValue);//Static Fields: Accessed using the class name.


//        Lifetime
//        Instance Fields: Exist as long as the object exists.
//        Static Fields: Exist throughout the program execution.



        Example obj1 = new Example();
        Example obj2 = new Example();

        obj1.instanceValue = 10;
        obj2.instanceValue = 20;

        Example.staticValue = 100;

        Console.WriteLine(obj1.instanceValue); // Output: 10
        Console.WriteLine(obj2.instanceValue); // Output: 20
        Console.WriteLine(Example.staticValue); // Output: 100 (shared value)


    }
}