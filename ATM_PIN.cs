using System;
class Program
{
    static void Main()
    {
        int correctPin = 1234;
        bool accessGranted = false;
        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Enter PIN: ");
            int pin = Convert.ToInt32(Console.ReadLine());
            if (pin == correctPin)
            {
                Console.WriteLine("Access Granted");
                accessGranted = true;
                break;
            }
            else
            {
                Console.WriteLine("Wrong PIN");
            }
        }
        if (!accessGranted)
        {
            Console.WriteLine("Card Blocked");
        }
    }
}
