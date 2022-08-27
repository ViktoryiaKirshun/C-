//С клавы считывается массив чисел через запятую
// в виде: 1,3,4,5,6,7,8,3,4
//Получить новый массив, в к-ом будут квадраты четных чисел
//Нельзя использовать split
//ответ должен быть: 16,36,64,16


//ПЕРВЫЙ ВАРИАНТ
// string s_global;
// int leng;
// int[] array = new int [10];

// //получаем массив от пользователя
// void get_array()
// {
//     Console.WriteLine("Введите массив: ");
//     string s = Console.ReadLine();
//     leng = s.Length; //нужна длина для цикла перебора элементов
//     s_global = s;

// }

// //вынимаем необходимые данные из полученного массива в get_array
// void incept_array(string s)
// {
    
//     int i = 0;
//     int j = 0;
//     while (i < leng)
//     {        
//         array [j] = Convert.ToInt32(s_global[i]);
//         i = i + 2;
//         Console.WriteLine("array = " + array[j]);
//         j = j + j;
//     }


//         make_kvadrat();
// }

// //берем данные из отсортированного массива и возводим в квадрат
// void make_kvadrat()
// {
//     for (int i = 0; i < 10; i++)
//     {
//         array[i] = array[i] * array[i];
//         Console.WriteLine("Измененный массив: ");
//         Console.WriteLine(array[i]);
//     }


// }



// get_array();

// incept_array(s_global);


// string s = "123";
// Console.WriteLine(4 + Convert.ToInt32(s[0].ToString()));
// Console.WriteLine(Convert.ToInt32(' '));
// Console.WriteLine(s[0]


//==================================================================================================
//ВТОРОЙ ВАРИАНТ

// 1 Считывание 
// 10 преобразовывание данных
// 3 получение квадратов четных чисел
// 0 печать массива


// метод печать массива
void Print(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
//

// Считывание 
string GetData(string title)
{
    Console.Write(title);
    return Console.ReadLine()!; //!чтобы убрать подчеркивание 
}
//

// получение квадратов четных чисел
/// узнать сколько четных чисел
/// создать набор квадратов
int[] MainEx(int[] array)
{
    int size = array.Length;
    int isEvenCount = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            isEvenCount++;
        }
    }

    int[] result = new int[isEvenCount];

    int index = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            result[index] = array[i] * array[i];
            index++;
        }
    }

    return result;
}
//

// метод, который считает кол-во запятых
int CountSynbol(string s, char c)
{
    int count = 0;
    int length = s.Length;
    for (int i = 0; i < length; i++)
    {
        if (s[i] == c) count++;
    }
    return count;
}
//

//ищем позицию запятой
int IndexOf(string s, char c)
{
    int length = s.Length;
    //int pos = -1;
    for (int i = 0; i < length; i++)
    {
        if (s[i] == c)
        {
            return i;
            //pos = i;
            //break;
        }
    }
    //return pos;
    return -1;
}
//

//
string Substring(string s, int position)
{
    string res = String.Empty;

    int size = s.Length;
    for (int i = position; i < size; i++)
    {
        res += $"{s[i]}";
    }

    return res;
}
//

//
string SubstringLength(string s, int position, int length)
{
    string res = String.Empty;

    int size = s.Length;
    for (int i = position; i < position + length; i++)
    {
        res += $"{s[i]}";
    }

    return res;
}
//

//
int[] Parse(string s)
{
    int[] result = new int[CountSynbol(s, ',') + 1];
    s += ",";
    int index = 0;

    while (s.Length != 0)
    {
        int posSeparator = IndexOf(s, ',');
        //System.Console.WriteLine($"pos {posSeparator}");
        string need = SubstringLength(s, 0, posSeparator);
        //System.Console.WriteLine($"need = {need}");
        string o = Substring(s, posSeparator + 1);

        //System.Console.WriteLine($"o    = {o}");
        //Console.ReadLine();
        s = o;
        result[index] = Convert.ToInt32(need);
        index++;
    }


    return result;
}
//

string str = GetData("Введите числа через запятую: ");
int[] inArr = Parse(str);
Print(inArr);
int[] outArr = MainEx(inArr);
Print(outArr);

// Console.WriteLine(
// Substring(s, 5)
// );

// Console.WriteLine(
// SubstringLength(s, 0, 5)
// );
// Console.WriteLine(
// IndexOf("143,243,3343,443,5434,643,71,8342", ',')
// );

// Console.WriteLine(CountSynbol(
// "143,243,3343,443,5434,643,71,8342",
// ','
// ));


// string str = GetArray("Введите числа через запятую: ");
// int[] inArr = { 1, 4, 5, 6, 87, 1, 111, 1000, 333, 4 };
// Print(inArr);
// int[] outArr = MainEx(inArr);
// Print(outArr);
