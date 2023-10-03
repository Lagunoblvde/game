namespace programm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Game();
                        break;
                    case 2:
                        Table();
                        break;
                    case 3:
                        Delimoe();
                        break;
                    case 0:
                        Console.WriteLine("До свидания!");
                        return;
                    default:
                        Console.WriteLine("Ошибка, попробуйте ещё раз");
                        break;
                }
            }
        }
        static void Menu()
        {
            Console.WriteLine("Выберите программу: \n1. Игра 'Угадай число'\n2. Таблица умножения\n3. Вывод делителей числа\n0. Выход");
        }
        static void Game()
        {
            Random name_1 = new Random();
            int name_2 = name_1.Next(0, 101);
            int name_3 = 0;

            while (true)
            {
                Console.Write("Введите число от 0 до 100: ");
                int name_4 = int.Parse(Console.ReadLine());
                name_3++;

                if (name_4 < name_2)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else if (name_4 > name_2)
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
                else
                {
                    Console.WriteLine("Вы победили, " + "вы сделали " + name_3 + " попыток.");
                    break;
                }
            }
        }
        static void Table()
        {
            Console.WriteLine("Таблица умножения:");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
        }
        static void Delimoe()
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Делители числа: " + num);
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(" " + i);
                }
            }
            Console.WriteLine();
        }

    }
}