Console.WriteLine("Введите номер квартиры");
int apartment = Convert.ToInt32(Console.ReadLine());
if (apartment <= 15)
{
    int floor = (apartment - 1) / (15 / 5) + 1;
    Console.WriteLine("Квартира " + apartment + " находится на " + floor);
}
else
{
    Console.WriteLine("Эта квартира находится в другом подъезде");
}