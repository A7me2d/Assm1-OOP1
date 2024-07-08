//using Assm1_OOP1;

using static Assm1_OOP1.Program;

namespace Assm1_OOP1
{
     class Program
    {
        static void DoSomeCode()
        {
            try
            {
                int x, y, z;
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                z = x / y;

                int[] Numbers = { 1, 2, 3 };
                Numbers[10] = 100;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void DoSomeProtectCode()
        {

            int x, y, z;
            bool Flag;
            do
            {
                Console.WriteLine("Enter Firt Num");
                Flag = int.TryParse(Console.ReadLine(), out x);
            } while (!Flag);

            do 
            {
                Console.WriteLine("Enter Firt Num");
                Flag = int.TryParse(Console.ReadLine(), out y);
            } while (!Flag || y == 0);
            //x = int.Parse(Console.ReadLine());
            //int.TryParse(Console.ReadLine(), out x);
            //y = int.Parse(Console.ReadLine());
            z = x / y;

            int[] Numbers = { 1, 2, 3 };
            if(Numbers.Length > 10 )
            {
                Numbers[10] = 100;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                DoSomeProtectCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finaly");
            }
            //DoSomeCode();

            #region Access Modifiers
            TypeA obj = new TypeA();
            //TypeB obj2 = new TypeB();
            #endregion


            #region EX01
            Grades x = Grades.A;
            if (x == Grades.A)
                Console.WriteLine(":(");
            else
                Console.WriteLine(":(");

            Grades y = (Grades)2;
            Console.WriteLine(y);

            Grades z = (Grades)10;
            Console.WriteLine(z);

            #endregion
        }







    }

    #region Enum
    public enum Days
    {
        Sat,
        Sun,
        Mon,
        Tues,
        Wed,
        Ther,
        Friday
    }

    public enum Grades : int
    {
        A, B, C, D, E, F
    }

    public enum Gender : int
    {
        Male, Female
    }

    enum Roles
    {
        Admin = 10 , Editor = 20 , Viewer = 30
    }

    #endregion

    class Employee
    {
        String Name;
        int Age;
        Double Salary;
        Gender Gender;
        Roles Role;
    }
}
