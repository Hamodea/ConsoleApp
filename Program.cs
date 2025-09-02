internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Vad heter du?");
        String name = Console.ReadLine();
        Console.WriteLine("Hur gamal är du?");
        int age = Console.ReadLine();
        Console.WriteLine(name, age);
    }
}