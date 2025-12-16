Console.WriteLine("Введите натуральное число n больше 999");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 999)
{
    Console.WriteLine("Количество тысяч: " + n / 1000);
    Console.WriteLine("Количество сотен: " + n % 1000 / 100);
}
else Console.WriteLine("Error");