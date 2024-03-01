namespace overmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Sum(12,78,29); //  task-1

            //Console.WriteLine("Reqeme gore fesili tap");
            //int a=Convert.ToInt32(Console.ReadLine());   //  task-2
            //Season(a); 




            //Console.WriteLine(Multiplication(23844));  //  task-3


            //ThreeSum(24, 54, 78);  //  task-4

        }
        #region task-1
        //static void Sum(int x, int y, int a)
        //{
        //    if (x >= 10 && x <= 100 && y >= 10 && y <= 100 && a >= 10 && a <= 100)
        //    {
        //        Console.WriteLine(x + y + a);
        //    }
        //    else if (x >= 10 && x <= 100 && y >= 10 && y <= 100)
        //    {
        //        Console.WriteLine(x + y);
        //    }
        //    else if (y >= 10 && y <= 100 && a >= 10 && a <= 100)
        //    {
        //        Console.WriteLine(a + y);
        //    }
        //    else if (x >= 10 && x <= 100 && a >= 10 && a <= 100)
        //    {
        //        Console.WriteLine(x+a);
        //    }
        //    else
        //    {
        //        Console.WriteLine("araliqda olan ededleri daxil et");
        //    }
        //}
        #endregion
        #region task-2
        //static void Season(int a)
        //{
        //    switch (a)
        //    {
        //        case 12:
        //        case 1:
        //        case 2:
        //            Console.WriteLine("Winter");
        //            break;
        //        case 3:
        //        case 4:
        //        case 5:
        //            Console.WriteLine("Spring");
        //            break;
        //        case 6:
        //        case 7:
        //        case 8:
        //            Console.WriteLine("Summer");
        //            break;
        //        case 9:
        //        case 10:
        //        case 11:
        //            Console.WriteLine("Autumn");
        //            break;
        //        default:
        //            Console.WriteLine("aylara uygun eded daxil edin");
        //            break ;
        //    }
        //}
        #endregion
        #region task-3
        //static int Multiplication(int number)
        //{
        //    int result = 1;
        //    while (number>1)
        //    {
        //        int netice = number % 10;
        //        result *= netice;
        //        number /= 10;
        //    }
        //    return result;
        //}
        #endregion
        #region task-4
        //static void ThreeSum(int x, int y,int a)
        //{
        //    if (x > a && y > a)
        //    {
        //        Console.WriteLine(x+y);
        //    }
        //    else if (y > x && a > x)
        //    {
        //        Console.WriteLine(y+a);
        //    }
        //    else if (x > y && a > y)
        //    {
        //        Console.WriteLine(x+a);
        //    }
        //    else
        //    {
        //        Console.WriteLine("reqemden basqa hecbirsey daxil etmeyin");
        //    }
        //}
        #endregion
    }
}
