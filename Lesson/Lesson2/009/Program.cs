int Max (int arg1, int arg2, int arg3) //возьмем аргумент 1,2,3
{
    int result = arg1; //тело метода, определяем внутренний резалт
    if (arg2 > result) result = arg2; //если арг2 > резалт, в резалт надо положить этот самы арг2
    if (arg3 > result) result = arg3;
    return result; //надо чтобы метод возвращал этот резалт
} 
  //             0    1   2   3   4   5   6   7   8
int [] array = {11, 211, 31, 41, 15, 61, 17, 18, 19};
//array [ 0 ] = 12; //каким образом м обратиться к массиву и записать в него зн-я
//Console.WriteLine(array[4]); //каким образом м обратиться к массиву и получить зн-я соот-ющего эл-та по указанному индексу
int result = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);
