void GenerateArray(int [] array)  //Создаем функцию генерирующую массив void - функция не возвращает результат, оставляет его в памяти
{
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(-array.Length, array.Length); // в массив записываем рандомные значения как положительные так и отрицательные
    }
}


void ShowArray(int [] array) // Создаем функцию, для вывода массива в консоль
{
    Console.WriteLine(); //просто разрыв строк в выводе в консоль
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write($" [{i}]: {array[i]},");
    }
    Console.WriteLine();
}


void SumOfArray(int [] array) // создаем функцию для подсчета суммы элементов массива
{ 
int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
    Sum+=array[i]; // Sum = Sum + Array[i]
    }
    Console.WriteLine($"Сумма массива: {Sum}");
}


void NullingArrayItemLowerZero(int [] array) // создаем функцию обнуления отрицательных значений в массиве
{
 for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            array [i] = 0;
        }
    }
}

bool HaveNegativeElements (int [] array) // создаем функцию, которая проверяет есть ли отрицательные значения в массиве и выводи true, если есть и false, если нет
{
    bool HaveNegative = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
           HaveNegative = true;
           break;
        }
    }
    return HaveNegative;
}

int arrayLength = 10; //длинна массива
int [] riceItem = new int[arrayLength]; // объявляем массив riceItem длинной arrayLength
GenerateArray(riceItem); // заполняем массив рандомными элементами
ShowArray(riceItem); //выводим массив в консоль
SumOfArray(riceItem); //подсчитываем сумму элементов массива
bool HaveNegative = HaveNegativeElements(riceItem);// проверяем на отрицательные значения
Console.WriteLine(HaveNegative);
NullingArrayItemLowerZero(riceItem); //обнуляем отрицательные элементы массива
ShowArray(riceItem);
SumOfArray(riceItem); // ещё раз подсчитываем сумму уже с обнуденными элементами
HaveNegative = HaveNegativeElements(riceItem);
Console.WriteLine(HaveNegative);
