Console.Write("Введите количество секунд \n");
int N_sec = Convert.ToInt32(Console.ReadLine());
int n_hours = N_sec / 3600;
int minutes_since_hour_start = (N_sec % 3600) / 60;
int seconds_since_minute_start = (N_sec % 60) / 60;
Console.WriteLine("Количеством полных часов с начала суток: " + n_hours);
Console.WriteLine("Количество полных минут с начала очередного часа: " +  minutes_since_hour_start);
Console.WriteLine("Количество полных секунд с начала очередной минуты: " +  seconds_since_minute_start);