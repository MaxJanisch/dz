Console.WriteLine("введите x:");
Console.WriteLine("введите y:");
double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
Console.WriteLine($"V={Math.Log(y + 0.95) + Math.Sin((Math.Pow(x, 4) * Math.PI / 180))}");