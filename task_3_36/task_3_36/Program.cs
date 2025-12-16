Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int x  = (n/100)*100 + (n%100%10)*10 + (n%100 / 10);
Console.WriteLine(x);