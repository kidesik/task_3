Console.WriteLine("Введите номер вашего сиденья");
int number = Convert.ToInt32(Console.ReadLine());
int compartment_num = (number - 1) / 4 + 1;
Console.WriteLine("Номер вашего купе: " + compartment_num);