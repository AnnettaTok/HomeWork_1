/*Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Ведите первое число ");
string number1Str = Console.ReadLine();
int number1 = Convert.ToInt32(number1Str);

Console.WriteLine("Ведите Второе число ");
string number2Str = Console.ReadLine();
int number2 = Convert.ToInt32(number2Str);
 
 if (number1 > number2) 
    Console.WriteLine($"Большее число {number1} Меньшее число {number2}");
    else 
    Console.WriteLine($"Большее число {number2} Меньшее число {number1}");