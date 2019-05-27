using System;
using System.Collections.Generic;
using System.Text;

namespace tpzslaba7_1_
{
    class Square : Figure, IGeometrical, IComparable
    {
        public double Side { get; set; }
        public Square(double side) : base()
        {
            Side = side;
        }
        public void GetPerimeter()
        {
            Perimeter = 4 * Side;
            Console.WriteLine("Периметр квадрата со стороной {0} = {1}", Side, Perimeter);
        }
        public void GetArea()
        {
            Area = Math.Pow(Side, 2);
            Console.WriteLine("Площадь квадрата со стороной {0} = {1}\n________________________________________\n", Side, Area);
        }
        public int CompareTo(object obj)
        {
            Square p = obj as Square;
            if (p != null)
                return this.Perimeter.CompareTo(p.Perimeter);
            else
                throw new Exception("Невозможно сравнить!");
        }
    }
}
