using System;

namespace AchaoCalculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入出题的个数：");
            int n = Convert.ToInt32(Console.ReadLine());
            PrintCalcuate calcuate1 = new PrintCalcuate(n); 
            Console.ReadKey();
       
        }
    }
}
