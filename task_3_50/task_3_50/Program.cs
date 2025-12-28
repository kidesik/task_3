Console.WriteLine("Введите часы и минуты");
int h = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
double pos_h = (h % 12) * 30 + m * 0.5;
int pos_m = m * 6;
double v_real = 5.5;
double diff_a = (pos_h - pos_m) % 360;
if (diff_a == 0){
    diff_a = 360;
    double t_a = diff_a / v_real;
    int resultA = (int)Math.Ceiling(t_a);
    Console.WriteLine($"До совпадения: {resultA} мин.");

}
else{
    double t_a = diff_a / v_real;
    int resultA = (int)Math.Ceiling(t_a);
    Console.WriteLine($"До совпадения: {resultA} мин.");
}
double diff_b1 = (pos_h - pos_m - 90) % 360;
double diff_b2 = (pos_h - pos_m - 270) % 360;

if (diff_b1 <= 0) diff_b1 += 360;
if (diff_b2 <= 0) diff_b2 += 360;

double t_b1 = diff_b1 / v_real;
double t_b2 = diff_b2 / v_real;

double t_b = Math.Min(t_b1, t_b2);
int resultB = (int)Math.Ceiling(t_b);

Console.WriteLine($"До перпендикулярности: {resultB} мин.");