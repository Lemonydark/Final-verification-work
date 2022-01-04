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

