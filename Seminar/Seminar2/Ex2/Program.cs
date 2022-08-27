//Задать массив из 8 эл-ов и вывести их на экран
//Уточнение: буквы алфавита, прописные или строчные, случайные символы, 

//Метод создания массива
//Метод печати массива
//Метод получения случайного символа
//Метод заполнения массива



//Метод создания массива
//char - так представлены символы
char[] CreateArray(int count) //char-метод возвращает/CreateArray-имя метода/int count-в качестве аргумента передаем кол-во
{
  return new char[count]; //возвращает пустой массив, состоящий из count эл-ов
}

// Метод печати массива
void Print(char[] array) //void-метод, отвечающий за печать /Print-наз-ие /char[]array-аргумент
{
  int len = array.Length; //получение кол-ва эл-ов
  int i = 0; //цикл
  while (i < len)
  {
    Console.Write($"{array[i]} "); //печать
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

// Метод заполнения массива
void Fill(char[] array) //void метод принимает char[] array
{
  int length = array.Length; //получение кол-ва эл-ов
  int i = 0; //завели какой-то счетчик
  while (i < length) //пока i меньше length
  {
    //array[i++] = "!"; в array[i-итое] класть символ !
    //array[i++] = 'a' + new Random().Next(0, 23);
    //array[i++] = Convert.ToChar(32 + i); // число конвертирует символы из таблицы кодировки
    //array[i++] = Convert.ToChar(64 + i); // число конвертирует нумерацию англ букв (A,B,C,D...)
    array[i++] = GetChar3();  
  }
}
char[] arg = CreateArray(8);
Fill(arg);
Print(arg);

//вариант решения без использования методов

// int length = 8; 
// char[] arg = new char[length]; int arg = new char[8]
// int i = 0;
// while (i < length)
// {
//     arg[i] = Convert.ToChar(64 + i); //arg[i] = Convert.ToChar(new Random().Next(70, 90));
//     Console.WriteLine(arg[i]);
//     i++;
// }
//ИЛИ
// {
//   int sc = Convert.ToInt32('а'); //int sc-взять остаток символа; букву "а" превратим в число
//   int ec = Convert.ToInt32('я'); //int ec-взять конечный символ
//   arg[i] = Convert.ToChar(new Random().Next(sc, ec + 1));//из рандомного берется буква и превращается в число
//   Console.WriteLine(arg[i]);
//   i++;
// }

// string s = Console.ReadLine()!;

// int i = 0;
// int sum = 0;
// while (i < s.Length)
// {
//   sum = sum + Convert.ToInt32(s[i].ToString());
//   i++;
// }
// Console.WriteLine($"sum {sum}");