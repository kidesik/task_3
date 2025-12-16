Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int c = n / 100;
int ab = n % 100;
Console.WriteLine(ab + "" + c);
