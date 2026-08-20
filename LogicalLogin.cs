using System;
class Program
{
    static void Main()
    {
        bool usernameValid = true;
        bool passwordValid = true;
        bool loginSuccess = usernameValid && passwordValid;
        if (loginSuccess)
            Console.WriteLine("Access Granted");
        else
            Console.WriteLine("Access Denied");
        Console.WriteLine("At least one condition is true: " + (usernameValid || passwordValid));
        Console.WriteLine("Opposite of username valid: " + (!usernameValid));
    }
}
