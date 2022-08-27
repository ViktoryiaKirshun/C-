// Задача 29: Напишите метод(ы), которай задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

char[] CreateArray(int count) 
{
  return new char[count]; 
}
void Print(char[] array) 
{
  int len = array.Length; 
  int i = 0; 
  while (i < len)
  {
    Console.Write($"{array[i]} "); 
    i++;
  }
  Console.WriteLine();
}
char GetChar()
{
  return Convert.ToChar(new Random().Next(64, 64 + 22));
}
char GetChar2()
{
  int sc = Convert.ToInt32('а');
  int ec = Convert.ToInt32('я');
  return Convert.ToChar(new Random().Next(sc, ec + 1));
}
char GetChar3()
{
  int sc = Convert.ToInt32('0');
  int ec = Convert.ToInt32('9');
  return Convert.ToChar(new Random().Next(sc, ec + 1));
}
void Fill(char[] array) 
{
  int length = array.Length;
  int i = 0; 
  while (i < length) 
  {
    array[i++] = GetChar3();  
  }
}
char[] arg = CreateArray(8);
Fill(arg);
Print(arg);


