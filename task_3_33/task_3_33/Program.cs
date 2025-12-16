Console.WriteLine("Введите трехзначное значение");
int x = Convert.ToInt32(Console.ReadLine());
int c = x % 100 % 10;
int a = x / 100;
int  b = x % 100 / 10;
Console.WriteLine(c + "" + a + "" + b);