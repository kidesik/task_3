
Console.WriteLine("введите целое двухзначное число и целое однозначное число");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int a2 = a / 10;
int a1= a % 10;
int c1 = (a1 + b) % 10;
int c2 = a2 + ((a1 + b) / 10);
Console.WriteLine(c2 + "" + c1);
