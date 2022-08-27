//Программа замены эл-ов массива на противоположные
//уточнения: 
//создать массив из 10-ти эл-ов
//тип массива int 
//заполняем числами от -10 до 10
//создаем цикл изменения состояния, 
//для этого умножаем эл-ты на -1
//вывести в консоль

//Создание массива:
// int[] numbers = new int [10]; //int-тип массива, numbers-имя, состоит из 10 эл-ов

// int index = 0; //счетчик пробегающий по всем эл-ам массива
//     while (index < numbers.Length) //пока индекс меньше, чем длина массива numbers.lenght
// {
//     numbers[index] = new Random().Next(-10, 11); //берем конкретный эл-т М и присвоить случ. число от -10 до 10
//     Console.Write($"{numbers[index],3} "); //печать эл-та М /,3-для вывода конкр числа отводим три символа
//     index++; //увеличиваем индекс (пока будет пробегать по всем эл-ам М)
// } //когда условие перестанет выполнятся, мы делаем переход на новую строку:
// Console.WriteLine(); //переход на новую строку

// index = 0; //снова обнуляем зачение индекса
    
//     while (index < numbers.Length) //пока индекс меньше, чем длина массива numbers.lenght
// {
//     numbers[index] = -numbers[index];//numbers[index]= -1 * numbers[index]; /берем конкретный эл-т массива и умножаем на -1
//     Console.Write($"{numbers[index],3} "); //печать М /,3-для вывода конкр числа отводим три символа
//     index++; //увеличиваем индекс
// }
//System.Console.WriteLine();

//Второй способ решения:
//метод создания
int[] Create(int len)
{
    return new int[len];
}
//метод печати
void Print(int[] array) //void-метод, отвечающий за печать 
{
  int len = array.Length; //получение кол-ва эл-ов
  int i = 0; //цикл
  while (i < len)
  {
    Console.Write($"{array[i],4}"); //печать
    i++;
  }
Console.WriteLine();
}
//метод заполнения
void Fill(int[] numbers)
{
int index = 0;     
while (index < numbers.Length) 
    {
    numbers[index] = new Random().Next(-10, 11);
    index++; 
    }
}

void Invert(int[] arr)
{
    int index = 0; 
    while (index < arr.Length) 
    {
        arr[index] = -arr[index];
        index++; 
    }
}

int[] numbers = Create(10);
Print(numbers);
Fill(numbers);
Print(numbers);
Invert(numbers);
Print(numbers);

Console.WriteLine();

int[] numbers2 = Create(15);
Print(numbers2);
Fill(numbers2);
Print(numbers2);
Invert(numbers2);
Print(numbers2);
