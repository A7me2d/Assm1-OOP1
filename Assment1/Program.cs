namespace Assment1
{

    public enum WeekDays
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }

    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    [Flags]
    public enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1 : Create an enum called "WeekDays" with the days of the week
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays))) 
            //{ 
            //Console.WriteLine(day);
            //}
            #endregion

            #region Q2 : Create an enum called "Season" 
            //Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine();
            //if (Enum.TryParse(input, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season name.");
            //}
            #endregion

            #region Q3 : Assign the following Permissions (Read, write, Delete, Execute)
            //Permissions userPermissions = Permissions.None;

            //userPermissions |= Permissions.Read;
            //userPermissions |= Permissions.Write;

            //Console.WriteLine("Current Permissions: " + userPermissions);

            //if ((userPermissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("Read permission is granted.");
            //}

            //if ((userPermissions & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("Delete permission is granted.");
            //}
            //else
            //{
            //    Console.WriteLine("Delete permission is not granted.");
            //}

            //userPermissions &= ~Permissions.Write;

            //Console.WriteLine("Permissions after removal: " + userPermissions);

            //if ((userPermissions & Permissions.Write) != Permissions.Write)
            //{
            //    Console.WriteLine("Write permission is removed.");
            //}
            #endregion


        }



    }
}
