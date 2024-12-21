
        while (guess != targetNumber)
        {
            Console.Write("Введите число (от 1 до {0}): ", maxNumber);
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if ((guess - targetNumber) > 10)
                Console.WriteLine("Загаданное число намного меньше.");
            else if ((guess - targetNumber) < 10)
                Console.WriteLine("Загаданное число меньше.");
            else if ((targetNumber - guess) < 10)
                Console.WriteLine("Загаданное число намного больше.");
            else if ((targetNumber - guess) > 10)
                Console.WriteLine("Загаданное число больше.");
            else
                Console.WriteLine($"Поздравляем! Вы угадали число за {attempts} попыток.");
        }