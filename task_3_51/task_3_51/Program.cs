Console.WriteLine("Введите два целых числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((a % b) * (b % a) + 1);
