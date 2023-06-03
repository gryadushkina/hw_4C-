//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


Console.Clear();
Console.WriteLine("Массив из 8 случайных элементов не ограниченных по величине: ");
byte num = 8;
int[] array = createNewArray(num);
Console.Write($"[{String.Join(", ", array)}]");


int[] createNewArray (int size)
{
    int[] newArray = new int[size];
    byte i = 0; 
    while (i < size)
    {
        newArray[i] = new Random().Next();
        i++;
    }
    
    return newArray; 
}  


