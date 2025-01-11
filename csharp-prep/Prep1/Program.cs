using System; 
//made by w00f
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?");
        string First = Console.ReadLine();
        Console.Write("What is your Last name?");
        string Last = Console.ReadLine();

        //Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine($"Your name is {Last}, {First} {Last}.");
    }
}