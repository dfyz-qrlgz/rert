using System;

Console.WriteLine(" ");
Console.WriteLine(@"Выберите арифметическое действие:
            1. Сложить 2 числа
            2. Вычесть первое из второго
            3. Перемножить два числа
            4. Разделить первое на второе
            5. Возвести в степень N первое число
            6. Найти квадратный корень из числа
            7. Найти 1 процент от числа
            8. Найти факториал из числа
            9. Выйти из программы");
Console.WriteLine(" ");

double r, a, b;
bool m = true;
while (m)
{
    int q = Convert.ToInt32(Console.ReadLine());
    if (q < 0 || q > 9)
    {
        Console.WriteLine("Введите номер операции повторно: ");
        q = Convert.ToInt32(Console.ReadLine());
    }
    switch (q)
    {
        case 1:
            Console.WriteLine("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            r = a + b;
            Console.Write("Результат сложения: "); Console.WriteLine(r);
            Console.WriteLine("Введите номер операции : ");
            break;

        case 2:
            Console.WriteLine("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            r = a - b;
            Console.Write("Результат вычитания: "); Console.WriteLine(r);
            Console.WriteLine("Введите номер операции : ");
            break;

        case 3:
            Console.WriteLine("Введите первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = Convert.ToInt32(Console.ReadLine());
            r = a * b;
            Console.Write("Результат умножения: "); Console.WriteLine(r);
            Console.WriteLine("Введите номер операции : ");
            break;

        case 4:
            Console.WriteLine("Введите первое число: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            if (b1 == 0)
            {
                Console.WriteLine("На ноль делить нельзя! Введите b повторно: ");
                b1 = Convert.ToDouble(Console.ReadLine());
                r = a1 / b1;
                Console.Write("Результат деления: "); Console.WriteLine(r);
                Console.WriteLine("Введите номер операции : ");
            }
            else
            {
                r = a1 / b1;
                Console.Write("Результат деления: "); Console.WriteLine(r);
                Console.WriteLine("Введите номер операции : ");
            }
            break;

        case 5:
            Console.WriteLine("Введите первое число: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите cтепень: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат возведения в степень N числа а: "); Console.WriteLine(Math.Pow(a2, n));
            Console.WriteLine("Введите номер операции : ");
            break;

        case 6:
            Console.WriteLine("Введите число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Квадратный корень дённого числа равен: "); Console.WriteLine(Math.Sqrt(a));
            Console.WriteLine("Введите номер операции : ");
            break;

        case 7:
            Console.WriteLine("Введите число: ");
            a = Convert.ToDouble(Console.ReadLine());
            r = (a / 100);
            Console.WriteLine("1% от а равен "); Console.WriteLine(r);
            Console.WriteLine("Введите номер операции : ");
            break;

        case 8:
            Console.WriteLine("Введите число: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for (int i = 2; i <= k; i++)
            {
                f = f * i;
            }
            Console.Write("Факториал введённого числа равен "); Console.WriteLine(f);
            Console.WriteLine("Введите номер операции : ");
            break;

    }
    if (q == 9) m = false;
}