﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1) 
{
    Console.WriteLine("Понедельник");
}
else 

if (day == 2) 
{
Console.WriteLine("Вторник");
}
else

if (day == 3)
{
  Console.WriteLine("Среда");  
}
else

if (day == 4)
{
   Console.WriteLine("Четверг");    
}
else

if (day ==5 )
{
   Console.WriteLine("Пятница");     
}
else

if (day == 6)
{
     Console.WriteLine("Суббота - Выходной день");   
}
else

if (day == 7 )
{
     Console.WriteLine("Воскресенье - выходной день");   
}