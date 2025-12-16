Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
if (1 <= n && n <= 999 && (n % 100 % 10) != 1) 
{
    Console.WriteLine(n % 100 % 10 + "" + n % 100 / 10 + "" + n / 100);
}