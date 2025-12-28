using System.Globalization;

Console.WriteLine("Введите число!");
int k = Convert.ToInt32(Console.ReadLine());
if  (1 <= k && k <= 180)
{
    int num_pair = 9 + (k + 1) / 2;
    int D = num_pair % 10;
    Console.WriteLine("Двухзначное числоБ образованное парой цифр, в которую входит k " + num_pair + "\n" + "Номер пары цифр " + D);
    if (k % 2 == 0)
    {
        int digit = num_pair % 10;
        Console.WriteLine("K "+digit);
    }
    else
    {
        int digit = num_pair / 10;
        Console.WriteLine("K "+digit);
    }
    
    }