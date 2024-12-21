using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите уровень сложности:");
        Console.WriteLine("1 - Легкий (1-50)");
        Console.WriteLine("2 - Средний (1-100)");
        Console.WriteLine("3 - Сложный (1-200)");

        int difficulty = int.Parse(Console.ReadLine());

        int maxNumber = difficulty switch
        {
            1 => 50,
            2 => 100,
            3 => 200,
            _ => 100
        };

        Random random = new Random();
        int targetNumber = random.Next(1, maxNumber + 1);
        int attempts = 0;
        int guess = 0;

        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");

        while (guess != targetNumber)
        {
            Console.Write("Введите число (от 1 до {0}): ", maxNumber);
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess < targetNumber)
                Console.WriteLine("Загаданное число больше.");
            else if (guess > targetNumber)
                Console.WriteLine("Загаданное число меньше.");
            else
                Console.WriteLine($"Поздравляем! Вы угадали число за {attempts} попыток.");
        }
    }
}
