Console.WriteLine("Введите угол");
int y = Convert.ToInt32(Console.ReadLine());
if  (0 < y && y <= Math.PI)
{
    double total_minute = (y / (2 * Math.PI)) * 720;
    int full_hours = Convert.ToInt32(total_minute / 60);
    double angle_minute = (total_minute % 60) *((2*Math.PI) /60);
    int current_minute = Convert.ToInt32(total_minute % 60);
    Console.WriteLine("Полных минут в часе " + current_minute + "\nВсего часов " + full_hours + "\nУгол минутной стрелки " + angle_minute);
}