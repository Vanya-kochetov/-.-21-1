using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Equations // Создаем пространство имен
{
    class Program
    {
        static void Main(string[] args) // Объявляем метод класса в которм
                                        // будет основное взаимодействие
        {
            int q = 1;     // Цикл отвечающий за меню,
            while (q != 0) // он будет бесконечен пока пользователь не введт 0

            {   // Тело программы, здесь через case мы можем выбрать нужный вариант примера
                Console.WriteLine("Введите число для выбора варианта от 5 до 15: ");
                int t = Convert.ToInt16(Console.ReadLine());
                switch (t)
                {
                    case 5:
                        double x, y, z, c; // Инициализация необходимы переменных
                        Console.WriteLine("Вы выбрали 5 вариант:" +
                            "D = (tg(x^4 - 6) - cos^3(z + x*y)) / cos^4(x^3 * c^2) \n");
                        Console.WriteLine("Введите x: "); // Ввод необходимых значений
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите z: ");
                        z = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите c: ");
                        c = Convert.ToDouble(Console.ReadLine());

                        new Reshenie().raschet5(x, y, z, c); // Вызов экземпляра класса
                                                             // в зависимости от варината

                        Console.WriteLine("Если Вы хотите продолжить выберите вариант. " +
                            "Для завершения введите 0: ");
                        q = Convert.ToInt16(Console.ReadLine()); // Ввод значения для завершения цикла
                        break;                                   // или выбора нового варианта


                    case 6:
                        double a, b; // Инициализация необходимы переменных
                        Console.WriteLine("Введите x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите b: ");
                        b = Convert.ToDouble(Console.ReadLine());

                        new Reshenie().raschet6(x, y, a, b);

                        Console.WriteLine("Если Вы хотите продолжить выберите вариант. " +
                            "Для завершения введите 0: ");
                        q = Convert.ToInt16(Console.ReadLine());
                        break;


                    case 7:
                        Console.WriteLine("Введите x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите a: ");
                        a = Convert.ToDouble(Console.ReadLine());

                        new Reshenie().raschet7(x, y, a);

                        Console.WriteLine("Если Вы хотите продолжить выберите " +
                            "вариант. Для завершения введите 0: ");
                        q = Convert.ToInt16(Console.ReadLine());
                        break;


                    case 8:
                        Console.WriteLine("Введите x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите c: ");
                        c = Convert.ToDouble(Console.ReadLine());

                        new Reshenie().raschet8(x, y, a, c);

                        Console.WriteLine("Если Вы хотите продолжить выберите " +
                            "вариант. Для завершения введите 0: ");
                        q = Convert.ToInt16(Console.ReadLine());
                        break;

                    case 9:
                        double d;
                        Console.WriteLine("Введите x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите d: ");
                        d = Convert.ToDouble(Console.ReadLine());

                        new Reshenie().raschet9(x, y, d);

                        Console.WriteLine("Если Вы хотите продолжить выберите " +
                            "вариант. Для завершения введите 0: ");
                        q = Convert.ToInt16(Console.ReadLine());
                        break;

                    case 10:
                        Console.WriteLine("Введите x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите y: ");
                        y = Convert.ToDouble(Console.ReadLine());

                        new Reshenie().raschet10(x, y);

                        Console.WriteLine("Если Вы хотите продолжить выберите " +
                            "вариант. Для завершения введите 0: ");
                        q = Convert.ToInt16(Console.ReadLine());
                        break;

                    case 11:
                        Console.WriteLine("Введите x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите y: ");
                        y = Convert.ToDouble(Console.ReadLine());

                        new Reshenie().raschet11(x, y);

                        Console.WriteLine("Если Вы хотите продолжить выберите " +
                            "вариант. Для завершения введите 0: ");
                        q = Convert.ToInt16(Console.ReadLine());
                        break;

                    case 12:
                        Console.WriteLine("Введите x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите a: ");
                        a = Convert.ToDouble(Console.ReadLine());

                        new Reshenie().raschet12(x, y, a);

                        Console.WriteLine("Если Вы хотите продолжить выберите " +
                            "вариант. Для завершения введите 0: ");
                        q = Convert.ToInt16(Console.ReadLine());
                        break;

                    case 13:
                        Console.WriteLine("Введите x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите b: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите a: ");
                        a = Convert.ToDouble(Console.ReadLine());

                        new Reshenie().raschet13(x, b, a);

                        Console.WriteLine("Если Вы хотите продолжить выберите " +
                            "вариант. Для завершения введите 0: ");
                        q = Convert.ToInt16(Console.ReadLine());
                        break;


                    case 14:
                        Console.WriteLine("Введите x: ");
                        x = Convert.ToDouble(Console.ReadLine());

                        new Reshenie().raschet14(x);

                        Console.WriteLine("Если Вы хотите продолжить выберите " +
                            "вариант. Для завершения введите 0: ");
                        q = Convert.ToInt16(Console.ReadLine());
                        break;

                    case 15:
                        double m;
                        Console.WriteLine("Введите y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите m: ");
                        m = Convert.ToDouble(Console.ReadLine());

                        new Reshenie().raschet15(y, m);

                        Console.WriteLine("Если Вы хотите продолжить выберите " +
                            "вариант. Для завершения введите 0: ");
                        q = Convert.ToInt16(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Вы ввели не существующий вариант, " +
                            "попробуйте еще раз");
                        break;

                }

            }
        }
        class Reshenie // Объявление класса содержащего решения искомых уравнений
        {
            private double D;

            public void raschet5(double x, double y, double z, double c) // Варианты уравнений
            {
                D = (Math.Tan(Math.Pow(x, 3) - 6) - Math.Pow(Math.Cos(z + x * y), 3)) /
                    Math.Pow(Math.Cos(Math.Pow(x, 3) * Math.Pow(c, 2)), 4);
                D = Math.Round(D, 2); // Округляем до 2х знаков после запятой
                Console.WriteLine($"Ответ: {D}");
            }

            public void raschet6(double a, double b, double x, double y)
            {
                D = (Math.Sqrt(x + b - a) + Math.Log(y)) / Math.Atan(b + a);
                D = Math.Round(D, 2);
                Console.WriteLine($"Ответ: {D}");

            }

            public void raschet7(double a, double x, double y)
            {
                D = (Math.Cos(Math.Pow(x, 3) + 6) - Math.Sin(y - a)) /
                    (Math.Log(Math.Pow(x, 4) - 2 * Math.Pow(Math.Sin(x), 5)));
                D = Math.Round(D, 2);
                Console.WriteLine($"Ответ: {D}");
            }

            public void raschet8(double a, double x, double y, double c)
            {
                D = (Math.Pow(a, 5) + Math.Pow(Math.Sin(y - c), 4)) /
                    (Math.Pow(Math.Sin(x + y), 3) + Math.Abs(x + y));
                D = Math.Round(D, 2);
                Console.WriteLine($"Ответ: {D}");
            }

            public void raschet9(double x, double y, double d)
            {
                D = (Math.Pow(Math.Cos(y), 3) + Math.Pow(2, x) * d) /
                    (Math.Exp(x) + Math.Log(Math.Pow(Math.Sin(x), 2) + 7.4));
                D = Math.Round(D, 2);
                Console.WriteLine($"Ответ: {D}");
            }

            public void raschet10(double x, double y)
            {
                D = (Math.Exp(Math.Pow(x, 3)) + Math.Pow(Math.Cos(x - 4), 2)) /
                    (Math.Atan(x) + 5.2 * y);
                D = Math.Round(D, 2);
                Console.WriteLine($"Ответ: {D}");
            }

            public void raschet11(double x, double y)
            {
                D = 2.33 * Math.Log(Math.Sqrt(1 + Math.Pow(Math.Cos(y), 2))) /
                    (Math.Exp(y) + Math.Pow(Math.Sin(x), 2));
                D = Math.Round(D, 2);
                Console.WriteLine($"Ответ: {D}");
            }

            public void raschet12(double x, double y, double a)
            {
                D = (Math.Pow(Math.Cos(Math.Abs(y + x)), 3) - (x + y)) /
                    (Math.Pow(Math.Atan(x + a), 4) * Math.Pow(x, 5));
                D = Math.Round(D, 2);
                Console.WriteLine($"Ответ: {D}");
            }

            public void raschet13(double x, double b, double a)
            {
                D = a / (x -a) + (Math.Pow(b, x) + Math.Pow(Math.Cos(x), 3)) / 
                    (Math.Pow(Math.Log(a), 3) + 4.5);
                D = Math.Round(D, 2);
                Console.WriteLine($"Ответ: {D}");
            }

            public void raschet14(double x)
            {
                D = (Math.Sin(Math.Pow(Math.Pow(x, 3) + 4, 3)) + 4.3) / 
                    Math.Pow(Math.Sin(Math.Pow(x, 4)), 3);
                D = Math.Round(D, 2);
                Console.WriteLine($"Ответ: {D}");
            }

            public void raschet15(double y, double m)
            {
                D = (Math.Pow(m, 2) + 2.8 * m + 0.355) /
                    (Math.Cos(2 * y) + 3.6);
                D = Math.Round(D, 2);
                Console.WriteLine($"Ответ: {D}");
            }
        }
    }
}
