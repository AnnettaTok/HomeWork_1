/* Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Ведите число ");
string number1Str = Console.ReadLine();
int number1 = Math.Abs(Convert.ToInt32(number1Str));

for (int i = 1; i < number1; i++)
{
    if(i % 2 ==0)
    Console.WriteLine($"{i }");
}
