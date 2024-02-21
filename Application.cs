using System;
namespace Application;
class Application
{
    static void Main()
    {
    AppStart:
        try
        {
            Operations.Starter();
        }
        catch (Exception e)
        {

            Console.WriteLine($"Exception Occurred ...\n{e.Message}");
            Console.WriteLine($"Restarting the Application ...\nPress any key to Continue ...");
            Console.ReadKey();
            Files.WriteFile();
            goto AppStart;
        }
    }
}
