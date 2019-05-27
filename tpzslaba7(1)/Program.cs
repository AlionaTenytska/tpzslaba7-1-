using System;

namespace tpzslaba7_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество фигур (квадрат): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Square[] square = new Square[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("-------Квадрат # {0} ----------\n", i + 1);
                Console.Write("Введите сторону квадрата: ");
                double side = double.Parse(Console.ReadLine());
                square[i] = new Square(side);
            }
            Console.WriteLine("\n\t\tРАССЧЕТ ПЕРИМЕТРА И ПЛОЩАДИ КВАДРАТОВ");
            foreach (IGeometrical a in square)
            {
                a.GetPerimeter();
                a.GetArea();
            }
            Array.Sort(square);
            Console.WriteLine("\n\t\tСОРТИРОВКА КВАДРАТОВ ПО КРИТЕРИЮ (ПЕРИМЕТР)");
            foreach (Square b in square)
            {
                Console.WriteLine("___________________________________________________\n");
                Console.WriteLine("Квадрат со стороной - {0} и периметром {1}", b.Side, b.Perimeter);
            }
            Console.ReadKey();
        }
    }
}
