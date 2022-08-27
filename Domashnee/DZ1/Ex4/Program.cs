// задача 4  программа, которая на вход принимает три числа и выдает максимальное из этих чисел
int a = 44;
int b = 5;
int c = 78;
int max = a;
if(b > max) max = b;
if(c > max) max = c;
Console.Write("max = ");
Console.WriteLine(max);