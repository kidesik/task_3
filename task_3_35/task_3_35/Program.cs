Console.Write("Введите трехзначное число (1<= n <= 999) \n");
int n = Convert.ToInt32(Console.ReadLine());
if (1 <= n && n <= 999) {
    int x = (n % 100 % 10) * 100 + (n / 100) * 10 + (n % 100 / 10);
    Console.Write(x);
}

