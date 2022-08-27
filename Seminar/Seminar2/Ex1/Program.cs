//Программа, которая выводит случ число из отрезка [10, 99] и показывает наибольшую цифру числа

Console.Clear(); //каждый раз будет очищать предыдущие строки
int number = new Random().Next(10, 100); //[10, 100)
//Console.WriteLine("number: " + number);
//Console.WriteLine("number: {number}"); //выведет просто текст
Console.WriteLine($"number: {number}"); //выведет как должно быть

int x = number / 10; //деление(нахождение неполного частного)
int y = number % 10; //нахождение остатка
 
if(x >y) //сравниваем x и y 
{
    Console.WriteLine(x); //Console.WriteLine($"max {x}");
}
else
{
    Console.WriteLine(y); //Console.WriteLine($"y {y}");
}

