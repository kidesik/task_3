Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int a = n / 100;
int b = n % 100 / 10;
int c = n % 100  % 10;
Console.WriteLine(c + "" + a + "" +  b);