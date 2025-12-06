Console.WriteLine("Введите номер квартиры");
int kv = 9*6;
int number_kv = Convert.ToInt32(Console.ReadLine());
int floor = ((number_kv - 1) / kv) + 1;
int p = (number_kv - 1) % kv / 4 + 1; 
int pos = ((number_kv - 1) %  6) +1;
Console.WriteLine("Квартира находится на этаже: " + floor + "\nВ " + p + " подьезде \nпозиция на этаже: " + pos);