
// Задание 1
Console.WriteLine("Нажмите любую клавишу для вывода всех нечётных чисел выбранном вами диапазоне");
ConsoleKey key = Console.ReadKey(true).Key;
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int i = 1;

while (i <= n)
{
    if (i % 2 != 0)
        Console.Write("{0}" + " ", i);
    ++i;
}
Console.WriteLine();
//Задание 2

Console.WriteLine("До какого числа считать ряд Фибоначчи?");
int number = Convert.ToInt32(Console.ReadLine());
int first = 1;
Console.Write("{0} ", first);
int second = 1;
Console.Write("{0} ", second);
int sum = 0;
while (number >= sum)
{
    sum = first + second;

    Console.Write("{0} ", sum);

    first = second;
    second = sum;

}

Console.WriteLine();

//Задание 3
Console.WriteLine("Задача про лыжника");
double summ = 0;
double day = 10;
int p, u = 0;
Console.Write("Введите процент от каждого пробега: ");
p = Convert.ToInt32(Console.ReadLine());
while (summ <= 100)
{
    summ = summ + day;
    u = u + 1;
    Console.WriteLine("В {0} день пробежал {1:F2} км. Всего {2:F2} км.", u, day, summ);
    day = day + day * p / 100;
}
Console.WriteLine("После {0} дня лыжник преодолел отметку в 100 км", u);
Console.ReadLine();