//Вид 1 (методы, которые ничего не возвращают и не принимают)
void Method1()
{
    Console.WriteLine("Автор ..."); //тело метода
}
//Method1(); //вызов метода


//Вид 2(не возвращают, но принимают аргументы)
void Method2(string msg) //string msg какое-то кол-во аргументов
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21 (msg: "Текст", count: 4); //count сколько раз хотим увидеть сообщение
//Method21 (count: 4, msg: "Новый текст");


//Вид 3(возвращают, но не принимают)
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);


//Вид 4(принимают и возвращают)

//Цикл while
// string Method4(int count, string text) //string возвращаем строку, передаем count
// {
//     int i = 0; //инициализация счетчика
//     string result = String.Empty; // изначально result будет пустой строкой 
//     while (i < count) //i<count-проверка условия
//     {
//         result = result + text;
//         i++; //увеличение счетчика
//     }
//     return result;
// }

//Цикл for
string Method4(int count, string text) //string возвращаем строку, передаем count
{
    string result = String.Empty; // изначально result будет пустой строкой 
    for (int i = 0; i < count; i++) //for-цикл, int i=0-инициализация счетчика,i<count-проверка условия, i++-увеличение счетчика
    {
        result = result + text;
    }
    return result;
}

string res = Method4(15, "z");
// Console.WriteLine(res);


//Цикл в цикле (вывод табл цмножения)
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}"); //интерполяция строк
    }
     Console.WriteLine();
}


