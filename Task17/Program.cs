// Напишите программу, которая принимает на вход координаты точки (X и Y)
// причем X не равен 0 и Y не равен 0 и выдает номер четверти плоскости, в которой находится 
// эта точка.


Console.WriteLine("Введите координаты точки по X: ");
int X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки по Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("Точка находится в 1 координатной четверти");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Точка находится во 2 координатной четверти");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Точка находится во 3 координатной четверти");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Точка находится в 4 координатной четверти");
}
else
{
    Console.WriteLine("Невозможно определить координатную четверть точки");
}