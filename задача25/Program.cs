//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int MathPow(int a, int b)
{
    int rez = a;
    int i = 1;
    while (i != b)
    
    {
        rez = rez * a;

        i++;
    }
   
    return rez;
}

Console.Clear();
Console.Write("введите число 1 ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("введите число 2 ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"число {num1} в степени {num2} равно {MathPow(num1, num2)}");