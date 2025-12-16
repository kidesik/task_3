Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
if (100<= n && n <= 999)
{
    Console.WriteLine(  n / 100 + "" + n % 100 % 10 + "" + n % 100 / 10);
}
