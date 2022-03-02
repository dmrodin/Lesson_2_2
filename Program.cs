using System;

namespace Lesson_2_2
{
    internal class Program
    {
        static void Main()
        {
            double x, y, r;

            try
            {
                Console.Write("Введите число х: ");

                x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите число y: ");

                y = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите число r: ");

                r = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Введено не верное значение");
                throw;
            }

            bool inCircle = Math.Pow(x, 2) + Math.Pow(y, 2) < Math.Pow(r, 2);
            
            Console.WriteLine(inCircle);
            
        }
    }
}
