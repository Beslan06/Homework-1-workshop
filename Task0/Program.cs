// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Введите первое число: ");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num_B = Convert.ToInt32(Console.ReadLine());

if (num_A > num_B)
    Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B);
else
    Console.WriteLine("Второе число " + num_B + " больше чем первое " + num_A);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    
    Console.WriteLine("Введите любое число:");
       num = Convert.ToInt32(Console.ReadLine());
          if (num % 2 == 1)
    Console.WriteLine("Число " + num + " является: нечётным");
          else
    Console.WriteLine("Число " + num + "является: чётным");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + num);
    while (i <= num)
    if (i % 2 != 1)
Console.Write(i + ", ");
not = false;
i++;
    if (not)
Console.WriteLine("Нет чётных чисел!");
default:
begin = false;

