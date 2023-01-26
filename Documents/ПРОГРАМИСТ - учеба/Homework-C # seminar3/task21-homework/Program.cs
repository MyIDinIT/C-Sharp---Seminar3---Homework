// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А по оси Х: ");
int Ax=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки А по оси Y: ");
int Ay=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки А по оси Z: ");
int Az=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси Х: ");
int Bx=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси Y: ");
int By=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси Z: ");
int Bz=Convert.ToInt32(Console.ReadLine());

double Distance=Math.Round(Math.Sqrt(Math.Pow(Bx-Ax,2)+Math.Pow(By-Ay,2)+Math.Pow(Bz-Az,2)),2);

Console.WriteLine("Дистанция между точками составляет:   "+Distance);