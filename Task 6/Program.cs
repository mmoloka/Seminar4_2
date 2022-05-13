/* Напишите программу, которая выводит на экран случайное 
трехзначное число и удалет вторую цифру в нем*/
int number = new Random().Next(100,1000);
string str = number.ToString();
Console.WriteLine($"{number} -> {str[0]}{str[2]}");
