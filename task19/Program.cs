/*Напишите программу, которая
принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите число");
string numberStr=Console.ReadLine();
int number=Convert.ToInt32(numberStr);

if (number>9999 && number<100000)
 if(number/10000==number%10 && (number/1000)%10==(number%100)/10)
 Console.WriteLine($"{number},палиндром");
 else
 Console.WriteLine($"{number},не палиндром");