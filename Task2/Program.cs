﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 1)
                Console.WriteLine("Число " + num + " является: НЕЧЁТНЫМ");
            else
                Console.WriteLine("Число " + num + "является: ЧЁТНЫМ");
