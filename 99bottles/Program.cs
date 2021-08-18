using System;

namespace _99bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottleNumber = 99;
            for (int i = bottleNumber; i >=0  ; i--)
            {
                
                Console.WriteLine(GetFirstLine(i));
                if (i == 0)
                {
                    break;
                }
            }
            Console.WriteLine(GetFinalLine(bottleNumber));
            Console.ReadLine();
        }

        public static string GetFirstLine(int num)
        {
            string line = $"{num} bottles of beer on the wall, {num} bottles of beer\n {GetSecondLine(num-1)}";
            return num ==0 ? "":line;
        }
        public static string GetSecondLine(int num)
        {
            string line = $"Take one down and pass it around, {num} bottles of beer on the wall".Replace("0", "no more");
            return num < 0 ? "" : line; 
        }
        public static string GetFinalLine(int num)
        {
            string line = $"No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, {num} bottles of beer on the wall.";
            return line;
        }
    }
}
