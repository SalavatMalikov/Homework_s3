﻿// Задача 21
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними 
// в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите X для точки 1");
int X1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите Y для точки 1");
int Y1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите Z для точки 1");
int Z1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите X для точки 2");
int X2 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите Y для точки 2");
int Y2 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите Z для точки 2");
int Z2 = Convert.ToInt32 (Console.ReadLine());

double d = Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2));
Console.WriteLine(d);