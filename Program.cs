using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the Bill:");
        double bill = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter total persons:");
        int persons = Convert.ToInt32(Console.ReadLine());
        double total =bill/ persons;
        Console.WriteLine("bill on each person is: "+total);
    }
}
