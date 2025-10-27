//размеры прямоугольника
int length = 130;
int width = 543;
//Размеры квадратов
int square = 130;
//количество квадратов
int num_of_squares_in_width = width/ square;
int num_of_squares_in_length = length / square;
int num_of_squares = num_of_squares_in_length * num_of_squares_in_width;
Console.WriteLine("Количество квадратов которое можно отрезать от прямоугольника 543*130: " + num_of_squares);