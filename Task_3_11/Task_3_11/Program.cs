Console.WriteLine("Введите число месяцев:");
int n = Convert.ToInt32(Console.ReadLine());
int x = (n % 12) + 1;
if (x == 1)
{  Console.WriteLine("Январь");}
else if (x == 2)
{ Console.WriteLine("Февраль");}
else if (x == 3)
{ Console.WriteLine("Март"); }
else if (x == 4)
{ Console.WriteLine("Апрель"); }
else if (x == 5)
{ Console.WriteLine("Май"); }
else if(x == 6)
    { Console.WriteLine("Июнь"); }
else if (x == 7)
    { Console.WriteLine("Июль"); }
else if (x == 8)
    { Console.WriteLine("Август"); }
else if (x == 9)
    { Console.WriteLine("Сентабрь"); }
else if (x == 10)
    { Console.WriteLine("Октябрь"); }
else if (x == 11)
    { Console.WriteLine("Ноябрь"); }
else if (x == 12)
{ Console.WriteLine("Декабрь"); }
else
{  Console.WriteLine("????"); }
