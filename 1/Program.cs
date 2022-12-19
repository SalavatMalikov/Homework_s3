// Задача 19
// Напишите программу, которая принимает на вход п
// ятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32 (Console.ReadLine());

string aNum = Convert.ToString(num);

if (aNum[0]==aNum[4]&&aNum[1]==aNum[3])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}