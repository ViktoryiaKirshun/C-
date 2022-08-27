// Написать программу сложение двух чисел

// Написать программу двух ЦЕЛЫХ чисел
// хотим показать арифм. выражение целиком
// int a = 1;
// int b = 2;
// int c = a + b;
// 1 + 2 = 3 - вывод в терминал
// Откуда числа? - числа генерируются автоматически
// Диапазон важен

int x = new Random().Next(-10, 11);
int y = new Random().Next(-10, 11);
// Console.Write(x);
// Console.Write(" + ");
// Console.Write(y);
// Console.Write(" = ");
// Console.WriteLine(x + y);

// 1 Вариант
//Console.Write(x);
//Console.Write(" + ");
//Console.Write(y);
//Console.Write(" = ");
//Console.WriteLine(x + y);
// 2 Вариант
Console.WriteLine(x + " + " + y + " = " + (x + y));
// 3 вариант
//Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
// 4 вариант
//Console.WriteLine(string.Format("{0} + {1} = {2}", x, y, x + y));
// 5 вариант
//Console.WriteLine($"{x} + {y} = {x + y}");


