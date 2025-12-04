Console.WriteLine("Введите номер значения: ");
int n = Convert.ToInt32(Console.ReadLine());
int s = ((n - 1) / 5) + 1;
int p = ((n - 1) % 5) + 1;
Console.WriteLine("Номер строки: " + s + "\nНомер столбца: " + p);