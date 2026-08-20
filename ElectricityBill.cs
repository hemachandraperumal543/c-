using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter units consumed: ");
        int units = Convert.ToInt32(Console.ReadLine());
        double bill;
        if (units <= 100)
        {
            bill = units * 2;
        }
        else if (units <= 200)
        {
            bill = units * 3;
        }
        else
        {
            bill = units * 5;
        }
        Console.WriteLine("Total Bill = ₹" + bill);
    }
}
