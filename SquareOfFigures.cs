using System;

namespace SquareOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the name of figure: ");
            string name = Console.ReadLine();//ввод названия фугуры
            Console.WriteLine(Square(name)); //нахождение площади фигуры
        }
        static double Square(string figureName)
        {
            if (figureName == "circle") //проверка на имя фигуры
            {
                Console.WriteLine("Give the radius of circle: ");
                int r = int.Parse(Console.ReadLine()); //ввод радиуса круга
                return Math.PI * Math.Pow(r, 2);
            }
            else if (figureName == "triangle")
            {
                Console.WriteLine("Give the first side of triangle: "); //ввод сторон треугольника
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Give the second side of triangle: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Give the third side of triangle: ");
                int c = int.Parse(Console.ReadLine());
                int p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
            {
                Console.WriteLine("Give the first side of square: "); //ввод сторон прямоугольника(квадрата)
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Give the second side of square: ");
                int b = int.Parse(Console.ReadLine());
                return a * b;

            }

        }




    }
}

