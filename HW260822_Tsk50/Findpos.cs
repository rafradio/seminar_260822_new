using System;

namespace FindElementArray
{
    class Program50
    {
        public int arrayFirstNum = 0;
        public int arrayUpperNum = 21;
        public int arrayRow;
        public int arrayColumn;
        static void Main(string[] args) 
        {
            Console.Clear();
            InitialSettings init = new InitialSettings();
            init.PrintExec();
            FindDigitPos digitPos = new FindDigitPos(init);
        }
    }
}