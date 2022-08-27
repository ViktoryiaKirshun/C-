//Программа, которая по заданному номеру четверти, показывает диапазон возможных 
//координат точек в этой четверти (x и y).
//по теореме пифагора(треугольник)
// b = {x0, y0}
// c = {x1, y1}
//AB = (y1 - y0)
//AC = (x1 - x0)
//BC^2 = AB^2 + AC^2
//BC = Sqrt(AB^2 + AC^2)

double Distance(double[] b, double[] c)
{
    double ab = b[0] - c[0];
    double ac = b[1] - c[1];
    return Math.Sqrt(ab*ab + ac*ac);
}
//            x0  y0
double[] x = { 0, 0};
//            x1  y1
double[] y = { 1, 1};
Console.WriteLine($"dis = {Distance(x, y)}");
