using System;

namespace ColumnAverageArray
{
    class InitialSettings : Program52
    {
        public int[,] array2Dimen;
        public double[] averageForColumn;
        public InitialSettings()
        {
            
            this.Initsets(0);
            this.averageForColumn = new double[this.arrayColumn];
            this.array2Dimen = new int[this.arrayRow, this.arrayColumn];
            this.InitArray();
            this.EverageExec();
        }
        public void Initsets(int iType)
        {
            if (iType < 2)
            {
                string[] dataType = {"строки", "столбца"};
                Console.Write($"Введите пожалуйста целое число для ({dataType[iType]}): ");
                string enterUser = Console.ReadLine();
                if (int.TryParse(enterUser, out int number))
                {
                    switch (iType)
                    {
                        case 0:
                            this.arrayRow = number;
                            break;
                        case 1:
                            this.arrayColumn = number;
                            break;
                    }
                    iType += 1;
                }
                else
                {
                    Console.WriteLine("Вы ввели не число. Повторите!");
                }
                this.Initsets(iType);
            }
            return;
        }
        public void InitArray()
        {
            for (int i = 0; i < this.arrayRow; i++)
            {
                for (int j = 0; j < this.arrayColumn; j++)
                {
                    this.array2Dimen[i, j] = new Random().Next(this.arrayFirstNum, this.arrayUpperNum + 1);
                }
            }

        }
        public void EverageExec()
        {
            for (int j = 0; j < this.arrayColumn; j++) 
            {
                double sum = 0;
                for (int i = 0; i < this.arrayRow; i++)
                {
                    sum += this.array2Dimen[i, j];
                }
                sum = sum / this.arrayRow;
                this.averageForColumn[j] = Math.Round(sum, 2);
            }
        }
        public void PrintExec() 
        {
            string s;
            Console.WriteLine("Ваш массив:");
            for (int i = 0; i < this.arrayRow; i++)
            {
                s = "";
                for (int j = 0; j < this.arrayColumn; j++)
                {
                    s += String.Format("{0,-7}", this.array2Dimen[i, j]);
                }
                Console.Write($"\n{s}");
            }
            Console.WriteLine("\n\nВаши средние по столбцу:");
            s = "";
            for (int j = 0; j < this.arrayColumn; j++)
            {
                s += String.Format("{0,-7}", this.averageForColumn[j]);
            }
            Console.Write($"{s}");
        }
    }
}