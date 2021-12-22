int[] array = {11,21,31,4,15,61,17,18,19};
int n = array.Length;
int find = 18;
int index = 0;

while (index < n)
{
    if (array [index] == find)
    {
        System.Console.WriteLine(index);
        break; // завершаеи работу цикла
    }

    index++; // index = index + 1
}
