Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();
Console.WriteLine($"Привет, {name}!");
Console.WriteLine($"Сегодня:");
Console.WriteLine(DateTime.Now);
Console.Write("Хотите продолжить? (y/n): ");
string answer = Console.ReadLine();
if (answer == "y" || answer == "yes" || answer == "да")
{
    Console.WriteLine("Отлично! Продолжаем...");
}
else if (answer == "n" || answer == "no" || answer == "нет")
{
    Console.WriteLine("До свидания!");
}
else
{
    Console.WriteLine("Неизвестный ответ. Завершаем работу.");
}
Console.WriteLine("\nНажмите любую клавишу для выхода...");
Console.ReadKey();