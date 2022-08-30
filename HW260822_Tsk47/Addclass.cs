using System;

namespace TwoDimArrayRandom
{
    class InitialSettings : Program47
    {
        public double[,] array2Dimen;
        public InitialSettings()
        {
            this.array2Dimen = new double[this.arrayRow, this.arrayColumn];
            this.InitArray();
        }
        public void InitArray()
        {
            for (int i = 0; i < this.arrayRow; i++)
            {
                for (int j = 0; j < this.arrayColumn; j++)
                {
                    this.array2Dimen[i, j] = this.DigitDblExec();
                }
            }

        }
        public double DigitDblExec()
        {
            Random rnd = new Random();
            double randNumber = rnd.NextDouble() * rnd.Next(this.arrayFirstNum, this.arrayUpperNum);
            return Math.Round(randNumber, 2);
        }
        public void PrintArray()
        {
            string s;
            for (int i = 0; i < this.arrayRow; i++)
            {
                s = "";
                for (int j = 0; j < this.arrayColumn; j++)
                {
                    s += String.Format("{0,-10}", this.array2Dimen[i, j]);
                }
                Console.Write($"\n{s}");
            }

        }

    }
}