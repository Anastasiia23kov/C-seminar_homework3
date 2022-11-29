// Задача 21. Программа принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// Формула для нахождения расстояния между двумя точками:
// Квадратный корень из ((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2))

Console.Clear();
Console.WriteLine("Введите координату точки А: ");
double xa = Convert.ToDouble(Console.ReadLine());
double ya = Convert.ToDouble(Console.ReadLine());
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату точки B: ");
double xb = Convert.ToDouble(Console.ReadLine());
double yb = Convert.ToDouble(Console.ReadLine());
double zb = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(xa-xb,2) + Math.Pow(ya-yb,2) + Math.Pow(za-zb,2));
Console.WriteLine($"Расстояние между двумя точками: {Math.Round(result,2)}");