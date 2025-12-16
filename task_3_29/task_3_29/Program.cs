Console.WriteLine("Введите натуральное число n больше 9");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 9)
{
    Console.WriteLine("Количество единиц: " + n % 10);
    Console.WriteLine("Количество десятков: " + n / 10);
}
else Console.WriteLine("Error");