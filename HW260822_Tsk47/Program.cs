using System;

namespace TwoDimArrayRandom
{
    class Program47
    {
        public int arrayFirstNum = -10;
        public int arrayUpperNum = 10;
        public int arrayRow;
        public int arrayColumn;
        static void Main(string[] args) 
        {
            Console.Clear();
            InitialSettings init = new InitialSettings();
            init.PrintArray();
        }
    }
}