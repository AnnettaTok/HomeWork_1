/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Ведите Первое число ");
string number1Str = Console.ReadLine();
int number1 = Convert.ToInt32(number1Str);

Console.WriteLine("Ведите Второе число ");
string number2Str = Console.ReadLine();
int number2 = Convert.ToInt32(number2Str);

Console.WriteLine("Ведите Третье число ");
string number3Str = Console.ReadLine();
int number3 = Convert.ToInt32(number3Str);

int max = 0;

 if (number1 > max) max = number1;
 if (number2 > max) max = number2;
  if (number3 > max) max = number3;


Console.WriteLine($"Большее число {max}");
