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

int targetNumber = random.Next(1, maxNumber + 1);
