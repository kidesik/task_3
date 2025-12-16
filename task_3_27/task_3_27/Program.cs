{ 
Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());
int a = n / 10000;
int b = n % 10000 / 1000;
int  c = n % 1000 % 1000 / 100;
int d = n % 1000 % 1000 % 100 / 10;
int  e = n % 1000 % 1000 %100 %10;
Console.WriteLine(a + b + c + d + e);
}
{
    Console.WriteLine("Введите четырехзначное число");
    int n = Convert.ToInt32(Console.ReadLine());
    int a = n / 1000;
    int b = n % 1000 / 100;
    int c = n % 1000 % 100 / 10;
    int d = n % 1000 % 100 % 10;
    Console.WriteLine(a + b + c + d );
}