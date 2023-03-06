/* Задача 25
Напишите метод, который принимает на вход два числа (A и B) и возводит
число A в натуральную степень B.Math.Pow использовать нельзя
 3, 5 -> 243 (3⁵)
2, 4 -> 16


int Number()
{
    System.Console.WriteLine("Введите число");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
int number = Number();
int Pow()
{
    System.Console.WriteLine("Введите степень числа");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
int pow = Pow();
int result = 1;


int Action()
{
    for (int i = 1; i <= pow; i++)
    {
        result = result*number;
    }
    return result;
}
int Result = Action();
Action();
System.Console.WriteLine($"Ррешение для числа {number} в степени {pow} = {Result}");

                        Задача 27: Напишите метод, который принимает на вход
число и выдаёт сумму цифр в числе.
452 -> 11; 82 -> 10; 9012 -> 12

*/

string GetNumber()
{
    System.Console.WriteLine("Введите число");
    string? a = Console.ReadLine();
    return a;
}
string number = GetNumber();

char ToArr(string number)
{
    char[] Array = number.ToCharArray();
    for (int i = 1; i <= Array.Length; i++)
    {
        Console.Write($"{i}, ");
    }
    return;
}
ToArr(number);
System.Console.WriteLine($"Введенное число = {number}");
