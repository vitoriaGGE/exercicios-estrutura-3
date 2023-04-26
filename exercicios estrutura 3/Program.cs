float A = float.Parse(Console.ReadLine());
float B = float.Parse(Console.ReadLine());
float C = float.Parse(Console.ReadLine());
float triangulo, circulo, trapezio, quadrado, retangulo;

triangulo = (float)((A * C) / 2);
circulo = (float)((C * C) * Math.PI);
trapezio = (float)(((A + B) * C) / 2);
quadrado = (float)(B * B);
retangulo = (float)(A * B);

Console.WriteLine(A + " " + B + " " + C);

Console.WriteLine("Triangulo: " + triangulo.ToString("F3"));
Console.WriteLine("Circulo: " + circulo.ToString("F3"));
Console.WriteLine("Trapezio: " + trapezio.ToString("F3"));
Console.WriteLine("Quadrado: " + quadrado.ToString("F3"));
Console.WriteLine("Retangulo: " + retangulo.ToString("F3"));
