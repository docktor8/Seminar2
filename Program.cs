﻿// Задача 1
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
/* void MuiNum (double num) //Метод принимающий число и проверяет его на кратность 7 и 23
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine($"Число {num} кратно 7 и 23");
    }
    else
    {
        Console.WriteLine($"Число {num} не кратно 7 или 23");
    }
} 
    

// Задача 2
// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
void CooQua (double X; double Y )
{
    if (X>0 && Y>0)
    {
        Console.WriteLine("1 четверть");
    }
    if (X<0 && Y>0)
    {
        Console.WriteLine("2 четверть");
    }
    if (X<0 && Y<0)
    {
        Console.WriteLine("3 четверть");
    }
    if (X>0 && Y<0)
    {
        Console.WriteLine("4 четверть");
    }
    if (X==0 | Y==0)
    {
        Console.WriteLine("X =0 или Y = 0");
    }
} */

// Задача 3
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
//void MaxNum (int num)
/* int num = 11;
{
    if (num>=10 && num <=99)
    {
        if ((num%100)/10 > num%10)
        {
            Console.WriteLine($"{num%100/10}");
        }
        else
        {
            Console.WriteLine($"{num%10}");
        }
    }
} */


// Задача 4
// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
int  num = 110;
int a = num;
int chet =0;
int result =0;
int step = 1;
while (a>=1)
{
    chet +=1;
    step *=10;
    a /= 10;
}
for (int i = chet; i>=1; i --)
{
    result = (num%step/(step/10));
    step /=10;
    Console.Write($"{result}, ");
}




