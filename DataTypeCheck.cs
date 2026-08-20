using System;
class Program
{
    static void Main()
    {
        int age = 25;
        float temperature = 98.6f;
        char grade = 'A';
        bool isPassed = true;
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Data Type: " + age.GetType());
        Console.WriteLine("Temperature: " + temperature);
        Console.WriteLine("Data Type: " + temperature.GetType());
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Data Type: " + grade.GetType());
        Console.WriteLine("Is Passed: " + isPassed);
        Console.WriteLine("Data Type: " + isPassed.GetType());
    }
}
