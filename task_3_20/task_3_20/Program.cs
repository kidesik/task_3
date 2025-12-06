Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int a = n % 100 / 10;
int  b = n % 100 % 10;
int sum = a + b;
int g = a * b;
Console.WriteLine("Количество десятков: " + a + "\nКоличество едениц: " + b + "\nСумма едениц и десятков: " + sum + "\nПроизведение едениц и десятков: " + g);
int c = n / 100;
Console.WriteLine("Количество сотен: " + c + "\nСумма всех цифр: " + (a + b + c) + "\nПроизведение всех цифр: " + (a * b * c));