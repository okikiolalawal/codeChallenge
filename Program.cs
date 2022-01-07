using System;

namespace c__practices
{
    class Program
    {
        static void Main(string[] args)
        {
          //Q3
          int m = int.Parse(Console.ReadLine());
          int n = int.Parse(Console.ReadLine());
          int initgrid = ([0][0]);
          int finalgrid = ([m -1][n - 1] );
          List<int> movementCount = new List<int>();
            for (int i = initgrid; i <= finalgrid ; i++)
            {
               
            }

            //Q1
            int d ;
            int [] numroot = [10,5,-3,3,2,11,3,-2];
            Console.WriteLine("Enter target sum");
            int targetSum = int.Parse(Console.ReadLine());
            int numberOfWays;
            for(int n = 0; n <=  numroot; n++)
            {
                d += IndexOf(numroot);
                if (d == targetSum)
                {
                    numberOfWays++;
                 Console.WriteLine(numberOfWays);
                }
            }
        }
    }
}
