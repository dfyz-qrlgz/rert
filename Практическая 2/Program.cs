Console.WriteLine("выберите операцию: \n" +
                  "1. Угадай число\n" +
                  "2. Таблица умножения\n" +
                  "3. Найти делитель числа\n" +
                  "4. Выйти из программы");
bool m = true;
while (m)
{
    int q = Convert.ToInt16(Console.ReadLine());

    switch (q)
    {
        case 1:
            {
                Console.WriteLine("Угадайте число (от 0 до 100): ");
                Random rnd = new Random();
                int f = rnd.Next(0, 100);
                int u;
                do
                {
                    u = Convert.ToInt32(Console.ReadLine());

                    if (u < f)
                        Console.WriteLine("Больше ");
                    if (u > f)
                        Console.WriteLine("Меньше ");
                }
                while (u != f);

                Console.WriteLine("Вы угадали!!!");
                Console.WriteLine("выберете операцию ещё раз");
                break;
            }
        case 2:
            Console.WriteLine("Таблица умножения:\n");
            int[,] tu = new int[11, 11];
            for (int i = 1; i < 11; i += 1)
            {
                for (int j = 1; j < 11; j += 1)
                {
                    tu[i, j] = i * j;
                    Console.Write(" {0, 4}", tu[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nВыберете операцию ещё раз ");
            break;

        case 3:
            {
                Console.WriteLine("Введите число");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Делители числа {0}", b);
                for (int i = 1; i <= b; i++)
                {
                    if (b % i == 0)
                        Console.Write(" {0} ", i);
                }
                Console.Write("\nВыберете операцию ещё раз ");
                break;
            }
        case 4:
            Console.WriteLine("Вы вышли из программы");
            m = false;
            break;
        default:
            Console.WriteLine("Вы ввели что-то не то");
            return;
    }
}