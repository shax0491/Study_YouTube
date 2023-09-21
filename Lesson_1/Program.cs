// Структура проекта
// Структура и порядок выполнения программы

/* 
Многострочный коммент-который не видит программа при компиляции
*/
{
Console.WriteLine("Введите три числа, и узнайте, какое из них имеет максимальное значение ");

Console.Write("Введите три числа нажмите ENTER: ");
int num1, num2, num3 = int.Parse(Console.ReadLine());
int maxNum = 0;
if (num1 > maxNum) maxNum = num1;
if (num2 > maxNum) maxNum = num2;
if (num3 > maxNum) maxNum = num3;
Console.Write("Максимальное значение имеет число " + maxNum);
}