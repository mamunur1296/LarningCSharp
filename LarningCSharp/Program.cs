using LarningCSharp.Class_14;



public class Student
{
    // member 1
    //public Student(int a ,int b) // Constructor
    //{
    //    Console.WriteLine(a+b);
    //}
    // member 2
    public int Id { get; set; } // Feeld
    protected string Name { get; set; }
    protected int Role { get; set; }
    // member 3
    public void DesplaySumething() // Method or Functions
    {

        Console.WriteLine($"Student Name  : {Name} ");
    }
}


public class Tahim : Student
{
    
    

}

class Parent
{
    protected string message = "Hello from Parent class!"; // Protected field

    protected void ShowMessage()
    {
        Console.WriteLine(message);
    }
}

class Child : Parent
{
    public void Display()
    {
        Console.WriteLine("Accessing protected member from derived class:");
        ShowMessage(); // Accessing protected method from parent class
    }
}


class Program
{
    
    static void Main()
    {
        Student student = new Student(); // Object or Instance
      
        Tahim tahim = new Tahim();
       
        tahim.DesplaySumething ();
    }
}