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
            Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter):");
            string input = Console.ReadLine();
            if (Enum.TryParse(input, true, out Season season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                    default:
                        Console.WriteLine("Invalid season");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid season name.");
            }
            #endregion
        }



    }
}
