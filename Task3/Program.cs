Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int even = 2;


while (num >= even)
{ 
    Console.Write(even + " ");
    even = even + 2;
}
