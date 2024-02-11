using System;
using System.Threading;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int columns = Convert.ToInt32(Console.ReadLine());
            int rows = Convert.ToInt32(Console.ReadLine());
            Massive massiveFirst = new Massive(columns, rows);
            Massive massiveSecond = new Massive(columns, rows);
            Massive massiveThird = new Massive(columns, rows, massiveFirst._arr, massiveSecond._arr);
        }
    }

    class Massive
    {
        public int _x { get; private set; }
        public int _y { get; private set; }
        public int[,] _arr { get; private set; }

        readonly Random rand = new Random();

        public Massive(int X, int Y)
        {
            Thread.Sleep(10);
            _x = X;
            _y = Y;
            _arr = new int[_x, _y];

            Console.WriteLine("Отрисовка массива...");
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    _arr[i, j] = rand.Next(0, 11);
                    Console.Write($"{_arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public Massive(int X, int Y, int[,] arrayFirst, int[,] arraySecond)
        {
            _x = X;
            _y = Y;
            _arr = new int[_x, _y];
            Console.WriteLine("Сложение элементов массивов...");

            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    _arr[i, j] = arrayFirst[i, j] + arraySecond[i, j];
                    Console.Write($"{_arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
