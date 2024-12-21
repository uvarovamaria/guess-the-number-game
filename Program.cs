using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        Random random = new Random();
        int targetNumber = random.Next(1, 101);
        int attempts = 0;
        int guess = 0;

        while (guess != targetNumber)
        {
            Console.Write("Введите число (от 1 до 100): ");
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
