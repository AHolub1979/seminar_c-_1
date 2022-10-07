// Первая задача
/*
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()!);
if(num1 > num2)
{
    Console.WriteLine("Первое число больше втрого");
}
else 
{
    Console.WriteLine("Второе число больше первого");
}
*/

//Вторая задача
/*
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int num3 = int.Parse(Console.ReadLine()!);
int max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3; 
Console.WriteLine (max);
*/

//Третья задача
/*
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
if(num %2 == 0 )
{
    Console.WriteLine("Введенное чило четное");
}
else
{
    Console.WriteLine("Введенное чило НЕчетное");
}
*/

//Четвертая задача

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
int num2 = 1;
if (num2 %2 == 0)
{
    Console.WriteLine(num2);
    num2++;
}
while(num2 <= num);


// зависает, не могу понять причину

