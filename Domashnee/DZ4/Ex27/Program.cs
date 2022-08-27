// Задача 27: Напишите метод, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int SumNumber(int number)
{
    int count = Convert.ToString(number).Length;
    int A = 0;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        A = number - number % 10;
        result = result + (number - A);
        number = number / 10;
    }
    return result;
}
int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр: " + sumNumber);