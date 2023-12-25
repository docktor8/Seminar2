//Задача 1
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//void MuiNum (double num)
double num = 161.1;
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine($"Число {num} кратно 7 и 23");
    }
    else
    {
        Console.WriteLine($"Число {num} не кратно 7 или 23");
    }
