/*
Переменная-1:

while

Переменная-1:

for (int i = 0; i < 10; i++)
{
    Console.Write($"{i}, ");
}
Console.Write("\b\b ");


/*Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8

/*int num = new Random().Next(10,100);
int a1 = num / 10;
int a2 = num % 10;
int max = a1;
if (max < a2)
{
  max = a2;
}
Console.WriteLine($"Наибольшая цифра числа {num} -> {max}");




/*Задача №11. Работа в группах
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
782 -> 72
918 -> 98


/*int num = new Random().Next(100,1000);
int num1;
Console.Write($"{num} ");
num1= num % 10;
num= num / 100;
num = (num * 10) + num1;
Console.Write(num);


/*Задача №12. Работа в группах
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно


/*int a, b;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if (a%b == 0)
{
Console.WriteLine("Кратно");
} else {
   Console.WriteLine(a%b);
}

/*int number = int.Parse(Console.ReadLine());

if(number%7 == 0 && number%23 == 0)
{
    Console.WriteLine($"Число {number} кратно 7 и 23 одновременно");
}
else
{
    Console.WriteLine($"Число {number} не кратно 7 и 23 одновременно");
}
*/

/*int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

if(number2 == number1 * number1 || number1 == number2 * number2)
{
   Console.WriteLine("Одно из заданных чисел является квадратом второго");
}
else
{
    Console.WriteLine("Одно из заданных чисел не является квадратом второго");
}
for(int i = 7; i <= 1000; i++) 
{
      if(i % 7 == 0 && i % 23 == 0)
        Console.WriteLine(i + " кратно 7 и 23");
      else
        Console.WriteLine(i + " не кратно 7 и 23");
}


/*Работа в группах
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет


/*Console.WriteLine ("Enter your first number ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "Enter your second number");
int b1 = Convert.ToInt32(Console.ReadLine());

 if (a1 * a1 == b1 || b1 * b1 == a1)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}
*\

/*int number = int.Parse(Console.ReadLine());

if(number%7 == 0 && number%23 == 0)
{
    Console.WriteLine($"Число {number} кратно 7 и 23 одновременно");
}
else
{
    Console.WriteLine($"Число {number} не кратно 7 и 23 одновременно");
}
*/

/*int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

if(number2 == number1 * number1 || number1 == number2 * number2)
{
   Console.WriteLine("Одно из заданных чисел является квадратом второго");
}
else
{
    Console.WriteLine("Одно из заданных чисел не является квадратом второго");
}
*/


