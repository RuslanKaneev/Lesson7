// Decompiled with JetBrains decompiler
// Type: Program
// Assembly: Lesson7-1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 310B3A9D-3F77-470C-9CD6-79866051E257
// Assembly location: C:\Users\karus\source\repos\Lesson7\Lesson7-1\bin\Debug\net6.0\Lesson7-1.dll

using System;

Console.WriteLine("Введите число");
int chislopolz = Convert.ToInt32(Console.ReadLine());
int chislo = chislopolz % 2;
if (chislo == 0)
{
    Console.WriteLine($"Число четное");
}
else
{
    Console.WriteLine($"Число нечетное");
}
if (chislopolz == 0)
{

    Console.WriteLine($"Вы ввели ноль");
}
Console.ReadKey();
