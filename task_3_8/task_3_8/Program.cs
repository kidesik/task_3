Console.WriteLine("Введите номер места");
int serial_number = Convert.ToInt32(Console.ReadLine());
int seat_number = serial_number - 01643 + 1;
int row_number = (seat_number / 15);
if (row_number == 0)
{
    row_number += 1;
}
Console.WriteLine("Ваше место " + seat_number + " находится в " + row_number + " ряду");