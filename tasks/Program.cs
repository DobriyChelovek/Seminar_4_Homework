/*Задача 25
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



int GetNumber(string message)
{
    System.Console.WriteLine(message);
    string? a = Console.ReadLine();
    int b = int.Parse(a);
    return b;
}
int number = GetNumber("Введите число ");

int Sum(int number)
{
    int result = 0;
    while (number >0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}
System.Console.WriteLine($"Введенная цифра = {number}, сумма всех чисел в цифре ");
System.Console.WriteLine($"равна {Sum(number)}");



                        Задача 29: Напишите метод, который задаёт
массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]


int Prompt(string message)// Ввод числа с экрана
{
    System.Console.WriteLine(message);// Приглашение ко вводу
    string? a = Console.ReadLine();
    int b = int.Parse(a);//приводим к числу
    return b;// возврат результата
}

// метод для получения случайных элементов массива
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];// объявляем массив
    Random random = new Random();// создаем переменную, которая будет заполняться псевдослучайныйм числом
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);// заполняем 
                                                       //случайными цифрами в диапазоне min-> max
    }
    return array;

}

void PrintArray(int[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");// вывод значения массива
    }
    System.Console.Write($"{array[array.Length - 1]}");// вывод значения массива
    System.Console.WriteLine(("}"));
}
int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение, для диапазона случайного числа: ");
int max = Prompt("Конечное значение, для диапазона случайного числа: ");
int[] array = GenerateArray(length, min, max); // заполнение массива случайными числами
PrintArray(array);// вывод массива
*/
