// Напишите прогламму, которая по заданному номеру четверти, показывает диапазон
// возможных координат тосек в этой четверти (X и Y).

Console.WriteLine("Введите номер координатной четверти ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Четверть 1 соответствует: X > 0 и Y > 0");
}
else if (number == 2)
{
    Console.WriteLine("Четверть 1 соответствует: X < 0 и Y > 0");
}
else if (number == 3)
{
    Console.WriteLine("Четверть 1 соответствует: X < 0 и Y < 0");
}
else if (number == 4)
{
    Console.WriteLine("Четверть 1 соответствует: X > 0 и Y < 0");
}
else
{
    Console.WriteLine("Такой координатной четверти не существует");
}