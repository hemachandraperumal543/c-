using System;
class Program
{
    static void Main()
    {
        int[] marks = new int[5];
        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter mark " + (i + 1) + ": ");
            marks[i] = Convert.ToInt32(Console.ReadLine());

            sum = sum + marks[i];
        }
        double average = (double)sum / 5;
        Console.WriteLine("Average = " + average);
        if (average >= 40)
            Console.WriteLine("Passed");
        else
            Console.WriteLine("Failed");
    }
}
