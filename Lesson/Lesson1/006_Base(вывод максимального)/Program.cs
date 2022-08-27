int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;
int max = a;
if(a > max) max = a; //если а больше макс, то в макс кладем а
if(b > max) max = b; //если б больше макс, то в макс кладем б
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;
Console.Write("max = ");
Console.WriteLine(max);