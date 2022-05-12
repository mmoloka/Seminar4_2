/*Напишите программу, которая будет принимать на
вход два числа и выводить, является ли второе число
кратным первому. Если число 2 не кратно числу 1, то
программа выводит остаток от деление.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно*/
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
int reminder = numberB % numberA;
if(numberB % numberA > 0)
{
       Console.Write("Не кратно, остаток ");
       Console.WriteLine(reminder);
}
else
{
    Console.Write("Кратно");
}
