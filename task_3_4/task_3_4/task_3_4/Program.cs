Console.WriteLine("Введите количество школьников");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество яблок");
int k  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вот сколько яблок достанется каждому школьнику: " + (k / N) + "\n" + "Вот сколько яблок останется в корзинке: " + (k % N));