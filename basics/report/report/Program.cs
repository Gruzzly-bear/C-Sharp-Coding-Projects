using System;




class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        Console.WriteLine("What course are you on?");
        string yourCourse = Console.ReadLine();
        Console.WriteLine("What page are you on?");
        int yourPage = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\"");
        bool yourHelp = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics");
        string yourExp = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        int yourHours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
    }
}

