//using Assm1_OOP1;

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
        }


        #region Access Modifiers
        TypeA obj = new TypeA();  
        //TypeB obj2 = new TypeB();
        #endregion


    }
}
