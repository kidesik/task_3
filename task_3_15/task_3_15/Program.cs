Console.WriteLine("Введите номер товара");
int number_place =  Convert.ToInt32(Console.ReadLine());
int pos = (number_place - 1) % 15;
int tier = (pos / 15) + 1;
int section = ((number_place - 1) / 15) + 1;
Console.WriteLine("Ярус: " +  tier + "\nСекция: " + section);