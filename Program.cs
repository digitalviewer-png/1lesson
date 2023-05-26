Console.Write("Введите сумму вклада: ");
double a = double.Parse(Console.ReadLine());
if (a <= 100)
{
    Console.WriteLine(a * 1.05);
}
else if (a > 100 && a < 200)
{
    Console.WriteLine(a * 1.07);
}
else 
{
    Console.WriteLine(a * 1.1);
}
// ff