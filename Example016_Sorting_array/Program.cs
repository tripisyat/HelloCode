//сортировка чисел массива от минимума к максимуму

int[]array = {1, 5, 4, 3, 2, 6, 7, 1, 21};
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++) // ищем минимальный элемент
        {
            if (array[j] < array [minPosition]) minPosition = j; // ищем минимальный элемент
        }
       
        int temporary = array[i]; //обмен элементов массива местами
        array[i] = array[minPosition]; //обмен элементов массива местами
        array[minPosition] = temporary; //обмен элементов массива местами
    }
}

PrintArray(array);
SelectionSort(array);
PrintArray(array);