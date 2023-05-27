/*Console.Write("Введите сумму вклада: ");
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
*/

/*
Console.Write("Введите количество долларов: ");
int dollars = int.Parse(Console.ReadLine());
double uan = 6.75;
Console.WriteLine($"Столько будет долларов в юанях: {dollars * uan:0.00} китайский юань");
*/

// Домашняя Работа

// Задача 1

/*

Console.Write("Введите темепературу по шкале Цельсия: ");
double a = double.Parse(Console.ReadLine());
double farengate = 32   ;
double kelvin = 273.13;
Console.WriteLine($"Температура по фаренгейту:{(a - Farengate) * 5}");
Console.WriteLine($"Температура по кельвину: {a + Kelvin}");

*/
// Задача 2

/*
 
Console.WriteLine("Привет, я калькулятор!"); Console.WriteLine("Я умею выполнять операции: \n 1.сложения \n 2.вычитания \n 3.умножения \n 4.деления \n 5.вычисления остатка от деления. \n");
Console.Write("Напишите число от 1 до 5, в зависимости от требуемой операции: ");
double a = double.Parse(Console.ReadLine());
if (a == 1)
{
    Console.WriteLine("Введите два числа: ");
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    Console.WriteLine(b + c);
}
else if (a == 2)
{
    Console.WriteLine("Введите два числа: ");
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    Console.WriteLine(b - c);
}
else if (a == 3)
{
    Console.WriteLine("Введите два числа: ");
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    Console.WriteLine(b * c);
}
else if (a == 4)
{
    Console.WriteLine("Введите два числа: ");
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    Console.WriteLine(b / c);
}
else if (a == 5)
{
    
    Console.WriteLine("Введите два числа: ");
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    Console.WriteLine(b % c);
    
}
else
{
    Console.WriteLine("Введите число от 1 до 5!");
}*/

//Задача 3
/*Console.WriteLine("Привет, я могу проверить твои знания таблицы умножения! \nНапиши мне два целых однозначных числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = a * b;
Console.WriteLine("Напиши мне свой ответ: ");
int answer = int.Parse(Console.ReadLine());
if (answer == c)
{
    Console.WriteLine($"Всё верно! Твой ответ: {c}");
}
else
{
    Console.WriteLine($"К сожалению ты ошибся, правильный ответ {c} \n Не расстраивайся и подучи таблицу умножения ;)");
}*/

// Задача 4 (1 , 2-4 года, 5-20 лет, 21 год, 22-24 года,25 - 30 лет 31 год, 32 - 34 года...)

Console.Write("Напишите Ваш возраст: ");
int age = int.Parse(Console.ReadLine());
switch (age)
{
    case int a when age == 1:
        Console.WriteLine("Вам один год");
        break;
    case int a when age > 1 && age < 5:
        Console.WriteLine($"Вам {a} года");
        break;
    case int a when age > 4 && age < 21:
        Console.WriteLine($"Вам {a} лет");
        break;
    case int a when age % 10 == 1: Console.WriteLine($"Вам {age} год ");
        break;
    case int a when age % 10 != 1 && age % 10 >= 5:
        Console.WriteLine($"Вам {age} лет");
        break;
    case int a when age % 10 != 1 && age % 10 < 5:
        Console.WriteLine($"Вам {age} года");
        break;
}


