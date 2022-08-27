//Дан текст. В тексте надо все пробелы заменить черточками, 
//маленькие буквы "к" заменить большими "К",
//а большие "С" заменить маленькими "с".

string text = "Мистер Дурсль возглавлял фирму под названием «Граннингс», которая специализировалась" 
            + "на производстве дрелей. Это был полный мужчина с очень пышными усами и очень короткой шеей." 
            +  "Что же касается миссис Дурсль, она была тощей блондинкой с шеей почти вдвое длиннее, "
            +  "чем положено при ее росте. Однако этот недостаток пришелся ей весьма кстати, поскольку "
            +  "большую часть времени миссис Дурсль следила за соседями и подслушивала их разговоры. "
            +  "А с такой шеей, как у нее, было очень удобно заглядывать за чужие заборы. У мистера и "
            +  "миссис Дурсль был маленький сын по имени Дадли, и, по их мнению, он был самым чудесным "
            +  "ребенком на свете.";

//пояснение:
// string s = "qwerty"
//             0123
//s[3] //r - в слове qwerty третий символ буква r


string Replace(string text, char oldValue, char newValue) //oldValue старый символ менятеся на newValue новый символ
{
    string result = String.Empty; //инициализация пустой строки

    int lenght = text.Length; //int lenght получаем длину строки,показывающую text.Length длину строки(напр. в слове qwerty будет число 6)
    for (int i = 0; i < lenght; i++) //i = 0 пробегаем от нулевого символа до lenght конца строки
    {
        if(text[i] == oldValue) result = result + $"{newValue}"; //если text[i] текущий текст==совпал с oldValue тем символом, котрый хотим заменить
        //то в result положим newValue новое значение
        else result = result + $"{text[i]}"; //если совпадений нет, то в result надо добавить text[i] текущий символ 
    }

    return result; //возвращаем результат
}

string newText = Replace(text, ' ', '|'); //пробелы меняем на черточки
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);






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
