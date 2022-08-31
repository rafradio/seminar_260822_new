using System;

namespace FindElementArray
{
    class InitialSettings : Program50
    {
        public double[,] array2Dimen;
        public int findItem;
        public InitialSettings()
        {
            this.Initsets(0);
            this.array2Dimen = new double[this.arrayRow, this.arrayColumn];
            this.InitArray();
        }
        public void Initsets(int iType)
        {
            if (iType < 3)
            {
                string[] dataType = {"строки", "столбца", "поиска числа от 0 до 20"};
                Console.Write($"Введите пожалуйста целое число для {dataType[iType]}: ");
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
                        case 2:
                            this.findItem = number;
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
                    this.array2Dimen[i, j] = new Random().Next(this.arrayFirstNum, this.arrayUpperNum);
                }
            }

        }
        public void PrintExec() 
        {
            string s;
            Console.WriteLine("\nВаш массив:");
            for (int i = 0; i < this.arrayRow; i++)
            {
                s = "";
                for (int j = 0; j < this.arrayColumn; j++)
                {
                    s += String.Format("{0,-7}", this.array2Dimen[i, j]);
                }
                Console.Write($"\n{s}");
            }
        }
    }
    class FindDigitPos : Program50
    {
        public bool findIt;
        public FindDigitPos(InitialSettings init)
        {
            this.findIt = false;
            this.FindDigitExec(init);

        }
        public void FindDigitExec(InitialSettings init)
        {
            int posColumn = 0;
            int posRow = 0;
            for (int i = 0; i < init.arrayRow; i++)
            {
                for (int j = 0; j < init.arrayColumn; j++)
                {
                    if (init.array2Dimen[i, j] == init.findItem)
                    {
                        this.findIt = true;
                        posColumn = i + 1;
                        posRow = j + 1;
                        break;

                    }
                    if (this.findIt) break;
                }
            }
            if (this.findIt)
            {
                Console.Write($"\n\nВаше число ({init.findItem}) входит в данный массив, и находится в строке {posColumn} и ряду {posRow}");   
            }
            else
            {
                Console.Write($"\n\nВаше число ({init.findItem}) не входит в данный массив");
            }

        }
    }
}