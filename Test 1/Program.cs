/*Задача: Написать программу, которая из имеющегося массива строк формирует 
новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатурыs, либо задать на старте выполнения алгоритма.*/

string[] array1 = new string[4] {"Hello", "2", "world", ":-)"};
string[] array2 = new string[array1.Length];
void NewArray(string[] array1, string[] array2)
{
    int index = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[index] = array1[i];
        index++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
NewArray(array1, array2);
PrintArray(array2);