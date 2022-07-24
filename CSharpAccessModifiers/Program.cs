using DemoLibrary;

class Program
{
    static void Main(string[] args)
    {
        // DRY - DONT REPEAT YOURSELF
        // MEANING - Create a method that can be used more than once, instead of re-writing that method - 
        // - under different variants
        AccessDemo demo = new();

        BadClass bad = new();

        bad.Age = 150;

        // This will overwrite the age property - DO NOT DO THIS
        bad._age = 150;

        demo.PublicDemo();

    }

    private static void SayHello()
    {
        Console.WriteLine("Hello World!");
    }
}