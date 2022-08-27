//задача 8 программа, которая на вход принимает число(N), а на выходе показывает все четные число от 1 до N
Console.Write("введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index <= N)
{
  int mod = index % 2;
  if (mod == 0)
  {
    Console.Write($"{index,3} ");
  }
  index++;
}

