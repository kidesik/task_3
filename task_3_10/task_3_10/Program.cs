Console.WriteLine("enter the day");
int k = Convert.ToInt32(Console.ReadLine());
int n = k % 7;
string d_1 = "Monday";
string d_2 = "Tuesday";
string d_3 = "Wednesday";
string d_4 = "Thursday";
string d_5 = "Friday";
string d_6 = "Saturday";
string d_7 = "Sunday";
if (n == 1)
{
    Console.WriteLine(d_1);
}
else if (n == 2)
{
    Console.WriteLine(d_2);
}
else if (n == 3)
{
    Console.WriteLine(d_3);

}
else if (n == 4)
{
    Console.WriteLine(d_4);
}
else if (n == 5)
{
    Console.WriteLine(d_5);
}
else if (n == 6)
{
    Console.WriteLine(d_6);

}
else if (n == 7)
{
    Console.WriteLine(d_7);
}
else
{
    Console.WriteLine("Error");
}