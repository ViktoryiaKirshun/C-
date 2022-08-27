//программа, которая принимает на вход координаты точки (X и Y), причем X не= 0 и Y не= 0 и выдает
//номер четверти плоскости, в которой находится эта точка
//уточнения: координаты - double


//вариант 1
double x = 0;
bool flag = false;
while (x == 0 || !flag)
{
    Console.Write($"Введите x: ");
    string str = Console.ReadLine();
    int pos = 0;
    flag = true;
    while (pos < str.Length)
    {
        if (!(str[pos] >= '0' && str[pos] <= '9'))
        {
            flag = false;
            break;
        }
        pos++;
    }
    if (str == string.Empty) flag = false;
    if (flag) x = Convert.ToDouble(str);
}
double y = 0;
flag = false;
while (y == 0 || !flag)
{
    Console.Write($"Введите y: ");
    string str = Console.ReadLine();
    int pos = 0;
    flag = true;
    while (pos < str.Length)
    {
        if (!(str[pos] >= '0' && str[pos] <= '9'))
        {
            flag = false;
            break;
        }
        pos++;
    }
    if (str == string.Empty) flag = false;
    if (flag) y = Convert.ToDouble(str);
}
Console.WriteLine($"P({x};{y})");
if (x > 0 && y > 0) { Console.WriteLine("1 четверть"); }
if (x < 0 && y > 0) { Console.WriteLine("2 четверть"); }
if (x < 0 && y < 0) { Console.WriteLine("3 четверть"); }
if (x > 0 && y < 0) { Console.WriteLine("4 четверть"); }


//вариант 2
// double TryGetDoubleFromConsole(string text)
// {
//     double temp = 0;
//     bool flag = false;
//     while (temp == 0 || !flag)
//     {
//         Console.Write(text);
//         string str = Console.ReadLine()!;
//         int pos = 0;
//         flag = true;
//         while (pos < str.Length)
//         {
//             if (!(str[pos] >= '0' && str[pos] <= '9'))
//             {
//                 flag = false;
//                 break;
//             }
//             pos++;
//         }
//         if (str == string.Empty) flag = false;
//         if (flag) temp = Convert.ToDouble(str);
//     }
//     return temp;
// }
// double x = TryGetDoubleFromConsole("Введите x: ");
// double y = TryGetDoubleFromConsole("Введите y: ");
//     Console.WriteLine($"P({x};{y})");
//     string result = string.Empty;
//     if (x > 0 && y > 0) { result = "1 четверть"; }
//    else if (x < 0 && y > 0) { result = "2 четверть"; }
//    else if (x < 0 && y < 0) { result = "3 четверть"; }
//    else if (x > 0 && y < 0) { result = "4 четверть"; }
//     else {result = "увы"; }
//  Console.WriteLine($"result = {result}");



