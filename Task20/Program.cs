// Задача 20: Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки A по X: ");
int Xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки A по Y: ");
int Ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по X: ");
int Xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по Y: ");
int Yb = Convert.ToInt32(Console.ReadLine());

double N = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2));
Console.WriteLine($"Расстояние между двумя точками = {N}");
