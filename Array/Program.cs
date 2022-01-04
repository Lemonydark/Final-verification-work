// Необходимо написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
// Первоначальный массив будет сгенерирован случайным образом.
// CreateArray(int count);
// FillArray(int[] array, int minValue, int maxValue);
// PrintArray(int[] array);
// EvenNumbers(int[] array);
// Console.WriteLine(PrintArray(array)); 
// Console.WriteLine(PrintArray(EvenNumbers(array))); 

int[] CreateArray(int count)
{
    return new int[count];
}

void FillArray(int[] array, int minValue, int maxValue)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
}

string PrintArray(int[] array)
{
    int count = array.Length;
    string res = String.Empty;
    for (int i = 0; i < count; i++)
    {
        res += $"{array[i]} ";
    }
    return res;
}

int[] EvenNumbers(int[] array)
{
    int[] arrayB = new int[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            arrayB[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref arrayB, count);
    return arrayB;
}

int[] array = CreateArray(5); 
FillArray(array,-10,10); 
Console.WriteLine(PrintArray(array)); 
Console.WriteLine(PrintArray(EvenNumbers(array))); 
