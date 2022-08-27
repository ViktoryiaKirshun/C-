            //Первый вариант решения(неудобный)
// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 313;
// int max = a1;
// if(b1 > max) max = b1;
// if(c1 > max) max = c1;
// if(a2 > max) max = a2;
// if(b2 > max) max = b2;
// if(c2 > max) max = c2;
// if(a3 > max) max = a3;
// if(b3 > max) max = b3;
// if(c3 > max) max = c3;
// Console.WriteLine(max); //показывааем результат

            //Второй вариант решения(удобный, ч/з аргумент)
int Max (int arg1, int arg2, int arg3) //возьмем аргумент 1,2,3
{
    int result = arg1; //тело метода, определяем внутренний резалт
    if (arg2 > result) result = arg2; //если арг2 > резалт, в резалт надо положить этот самый арг2
    if (arg3 > result) result = arg3;
    return result; //надо чтобы метод возвращал этот резалт
}
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 12311;
int c3 = 313;

//первый вариант
// int max1 = Max (a1, b1, c1); //результатом работы ф-ии макс, б. явл максимальное из 3 чисел
// int max2 = Max (a2, b2, c2);
// int max3 = Max (a3, b3, c3);
// int max = Max(max1, max2, max3); //чтобы макс принял макс1, макс2, макс3
// Console.WriteLine(max); //показывааем результат

//второй вариант
int max = Max(
    Max (a1, b1, c1), 
    Max (a2, b2, c2), 
    Max (a3, b3, c3));
Console.WriteLine(max); //показывааем результат

