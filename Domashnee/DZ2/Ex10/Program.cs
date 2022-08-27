// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1

//вариант 1
Console.Write("Введите трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("Вторая цифра числа -> "+stringNumber[1]);

//вариант 2(не совсем верный)
// Console.Write("Введите трёхзначное число: ");
// string str = Console.ReadLine();
// char [] arr = str.ToCharArray();
// Console.WriteLine($"Вторая цифра числа -> {arr[1]}");


