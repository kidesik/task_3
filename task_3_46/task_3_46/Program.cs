using System.Globalization;

Console.WriteLine("Введите число!");
int k = Convert.ToInt32(Console.ReadLine());
if (1 <= k && k <= 150)
{
    int number_index = (k - 1) / 3;
    int target_number = 101 + number_index;
    int digit_position = (k - 1) % 3;
    if (digit_position == 0)
    {
        int result = target_number / 100;
        Console.WriteLine(result);
    }
    else if (digit_position == 1)
    {
        int result = (target_number / 10)%10;
        Console.WriteLine(result);
    }
    else
    {
        int result = target_number % 10;
        Console.WriteLine(result);
    }
}