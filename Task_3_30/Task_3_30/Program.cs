Console.WriteLine("Введите натуральное число n больше 99");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99)
{
    Console.WriteLine("Количество сотен: " + n / 100 );
    Console.WriteLine("Количество десятков: " + n % 100 / 10);
}
else Console.WriteLine("Error");