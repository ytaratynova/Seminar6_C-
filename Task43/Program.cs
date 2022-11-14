// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите коэффициент b1:");
double b1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите коэффициент k1:");
double k1 = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("введите коэффициент b2:");
double b2 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите коэффициент k2:");
double k2 = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Точка пересечения прямых: ({Xcoordinate(b1, k1, b2, k2)}; {Ycoordinate(b1, k1, b2, k2)})");

double Xcoordinate(double coorb1, double coork1, double coorb2, double coork2)       
{
    double x = (coorb2 - coorb1)/(coork1 - coork2);
    return x;
}

double Ycoordinate(double coorb1, double coork1, double coorb2, double coork2)     
{
    double y = coork1 * (coorb2 - coorb1)/(coork1 - coork2) + coorb1;
    return y;
}




       
