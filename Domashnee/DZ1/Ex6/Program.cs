//задача 6 программа, которая на вход принимает число и выдает, является ли число четным(делится ли оно на два без остатка)
int a;
Console.Write("введите число: ");
a = Console.Read();
if(a % 2 == 1) 
{
   Console.WriteLine("нечетное");
}
else
{
   Console.WriteLine("четное");
}
Console.ReadKey();
