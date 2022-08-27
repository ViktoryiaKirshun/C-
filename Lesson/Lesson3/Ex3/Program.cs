//Алгоритм сортировки методом выбора(минимакса)
//упорядочить числа по порядку
//1. Найти позицию минимального эл-та в неотсортированной части массива
//2. Произвести обмен этого значения со значением первой неотсортированной позиции
//3. Повторять пока есть не отсортированные элементы

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//метод, который упорядочивает массив
void SelectionSort (int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        
        int temporary = array [i];
        array[i] = array[minPosition]; //в i-тую позицию кладем array[minPosition] эл-т(меняем их местами)
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);

