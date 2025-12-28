using System.Drawing;

Console.WriteLine("Введите количество часов, минут и секунд");
int h = Convert.ToInt32(Console.ReadLine());
int m  = Convert.ToInt32(Console.ReadLine());
int s  = Convert.ToInt32(Console.ReadLine());
if (0 < h && h <= 23 && 0 <= m && m <= 59 && 0<= s && s <= 59)
{
    int angle = (h * 3600 + m * 60 + s) / 120;
    Console.WriteLine(angle + " градусов");
}