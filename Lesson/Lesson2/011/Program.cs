void FillArray(int[] collection) //void-метод,к-й ничего не возвращает,значит не надо писать return в конце
{
    int Length = collection.Length; //длина массива
    int index = 0;
    while(index < Length)
    {
        //обращаемся к аргументу колекшн и положить туда новое случ число из диапазона 1-10:
        collection [index] = new Random().Next(1,10); 
        
        //index = index + 1
        index++; 
    }
    // return не надо,т.к. написано void
}


void printArray(int[] col) //метода, к-й печатает массив
{
    int count = col.Length; //кол-во эл-ов
    int position = 0; //наименование переменной не через индекс, а через position
    while (position < count) 
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) //в качестве аргумента массив collection
{
    int count = collection.Length; //определяем кол-во эл-ов
    int index = 0;
    int position = -1; //если эл-та в списке (в консоли) нет, то выведет -1 (значит эл-т не найден)
    while (index < count)
    {
        if(collection[index] == find) //если collection[index] совпал с find
        {
            position = index; 
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; //new int[10] - новый эл-т в к-ом будет 10 эл-ов

FillArray(array); //вызвали филлэррэй, к-й заполнил массив
array[ 4 ] = 4; //искусственно добавляем в четверки
array[ 6 ] = 4; //искусственно добавляем в четверки
printArray(array); //печать
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);