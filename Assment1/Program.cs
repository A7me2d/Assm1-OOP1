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
    public enum Colors
    {
        Red,
        Green,
        Blue
    }

    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
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

            #region Q4 : Create an enum called "Colors" with the basic colors (Red, Green, Blue)
            //Console.WriteLine("Enter a color name (Red, Green, Blue):");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Colors color))
            //{
            //    switch (color)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            Console.WriteLine($"{color} is a primary color.");
            //            break;
            //        default:
            //            Console.WriteLine($"{color} is not a primary color.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid color name.");
            //}
            #endregion

            #region Q5 : Create a struct called "Point"
            //Console.WriteLine("Enter the coordinates for the first point (x y):");
            //string[] firstPointInput = Console.ReadLine().Split();
            //double x1 = double.Parse(firstPointInput[0]);
            //double y1 = double.Parse(firstPointInput[1]);

            //Point point1 = new Point(x1, y1);

            
            //Console.WriteLine("Enter the coordinates for the second point (x y):");
            //string[] secondPointInput = Console.ReadLine().Split();
            //double x2 = double.Parse(secondPointInput[0]);
            //double y2 = double.Parse(secondPointInput[1]);

            //Point point2 = new Point(x2, y2);

            //double distance = CalculateDistance(point1, point2);

         
            //Console.WriteLine($"The distance between the two points is: {distance}");
            

        }
        static double CalculateDistance(Point p1, Point p2)
        {
            double dx = p1.X - p2.X;
            double dy = p1.Y - p2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        #endregion


    }
}
