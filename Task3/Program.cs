Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int remain = 2;
int even = 2;

while (num >= remain)
while (num >= even)
{
    Console.Write(remain + " ");
    remain = remain + 2;
    Console.Write(even + " ");
    even = even + 2;
}
