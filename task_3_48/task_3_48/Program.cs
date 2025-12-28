Console.WriteLine("Введите угол");
int angle = Convert.ToInt32(Console.ReadLine());
if  (0 <= angle && angle <= 360 )
{
    int total_minute = angle * 2;
    int full_hours = total_minute / 60;
    int minuts_in_current_hour = total_minute % 60;
    Console.WriteLine("Количество полных часов " + full_hours + "\nЧисло полных минут, прошедших с начла суток " + total_minute + "\nМинут в конкретном часе " + minuts_in_current_hour);
}