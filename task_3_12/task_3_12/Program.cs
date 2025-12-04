Console.WriteLine("Введите номер квартиры:");
int number_kv = Convert.ToInt32(Console.ReadLine());
int floors = ((number_kv - 1)/ (4 + 1))+ 1;
int pos = ((number_kv - 1)% 4) + 1;
Console.WriteLine("Этаж:" + floors + "\n Позиция на этаже:" + pos);