

using System;

#region 
//1 - Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then,
//write a C# program that prints out all the days of the week using this Enum.

//public enum WeekDays
//{
//    Monday,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday,
//    Saturday,
//    Sunday
//}

//public class PrintWeekDays
//{
//    public static void Main(string[] args)
//    {
//        // Get all values of the enum
//        WeekDays[] daysOfWeek = (WeekDays[])Enum.GetValues(typeof(WeekDays));

//        // Print each day of the week
//        foreach (WeekDays day in daysOfWeek)
//        {
//            Console.WriteLine(day);
//        }

//        Console.ReadLine();
//    }
//}
#endregion

#region 
//2-Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
//Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. 
//Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)


//public enum Season
//{
//    Spring,
//    Summer,
//    Autumn,
//    Winter
//}

//public class SeasonProgram
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter):");
//        string seasonInput = Console.ReadLine();

//        try
//        {
//            // Parse the input string to the Season enum. Handles case-insensitivity.
//            Season season = (Season)Enum.Parse(typeof(Season), seasonInput, true);

//            switch (season)
//            {
//                case Season.Spring:
//                    Console.WriteLine("Spring: March to May");
//                    break;
//                case Season.Summer:
//                    Console.WriteLine("Summer: June to August");
//                    break;
//                case Season.Autumn:
//                    Console.WriteLine("Autumn: September to November");
//                    break;
//                case Season.Winter:
//                    Console.WriteLine("Winter: December to February");
//                    break;
//                default:
//                    Console.WriteLine("Invalid season."); // Should not happen due to Enum.Parse
//                    break;
//            }
//        }
//        catch (ArgumentException)
//        {
//            Console.WriteLine("Invalid season name entered.");
//        }

//        Console.ReadKey(); // Keep the console window open
//    }
//}
#endregion
#region

//3 - Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum           .
//Create Variable from previous Enum to Add and Remove Permission from variable,
//check if specific Permission existed inside variable
//public enum Permissions
//{
//    Read = 1,
//    Write = 2,
//    Delete = 4,
//    Execute = 8
//}

//public class PermissionManager
//{
//    private Permissions _permissions;

//    public PermissionManager()
//    {
//        _permissions = 0; // Initialize with no permissions
//    }

//    public void AddPermission(Permissions permission)
//    {
//        _permissions |= permission;
//    }

//    public void RemovePermission(Permissions permission)
//    {
//        _permissions &= ~permission;
//    }

//    public bool HasPermission(Permissions permission)
//    {
//        return (_permissions & permission) == permission;
//    }
//}
#endregion
#region 
//4.Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members. 
//Write a C# program that takes a color name as input from the user and displays a message
//indicating whether the input color is a primary color or not.
//public enum Colors
//{
//    Red,
//    Green,
//    Blue
//}

//public class ColorChecker
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter a color name (Red, Green, Blue):");
//        string inputColor = Console.ReadLine();

//        if (Enum.TryParse(inputColor, true, out Colors color))
//        {
//            Console.WriteLine($"{inputColor} is a primary color.");
//        }
//        else
//        {
//            Console.WriteLine($"{inputColor} is not a primary color.");
//        }

//        Console.ReadKey();
//    }
//}


#endregion