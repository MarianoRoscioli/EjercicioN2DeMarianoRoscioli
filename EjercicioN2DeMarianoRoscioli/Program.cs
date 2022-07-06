using System;

namespace EjercicioN2DeMarianoRoscioli
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e;
            double resultado, radio, coor1, coor2;

            Console.WriteLine("Ingrese el coeficiente cuadratico A ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el coeficiente cuadratico B ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de C ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de D ");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de E ");
            e = double.Parse(Console.ReadLine());

            resultado = Math.Pow(a, 2) + Math.Pow(b, 2) + c + d + e;

            if (a == 0 && b == 0)
            {
                Console.WriteLine("Los coeficientes A y B no pueden ser ambos 0");
            }
            else 
            {
                if (a != 0 || b != 0)
                {
                    Console.WriteLine("El resultado de la ecuacion es una parabola");
                }
                else
                {
                    if (a!=0 && b!=0 && a == b)
                    {
                        Console.WriteLine("El resultado de la ecuacion es una circunferencia");
                        Console.WriteLine("ingrese el radio: ");
                        radio = double.Parse(Console.ReadLine());
                        radio = 0.5 * Math.Sqrt(Math.Pow(c, 2) + Math.Pow(d, 2) - 4 * e);
                        Console.WriteLine("Ingrese el valor de la primer coordenada: ");
                        coor1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor de la segunda coordenada: ");
                        coor2 = double.Parse(Console.ReadLine());
                        coor1 = (-d / 2);
                        coor2 = (-e / 2);
                        Console.WriteLine($"El radio es ",radio);
                        Console.WriteLine($"Las coordenadas son ",coor1,coor2);
                    }
                    else
                    {
                        if (a != 0 && b != 0 && a > 0 && b > 0 && a == b)
                        {
                            Console.WriteLine("El resultado de la ecuacion es una elipse");
                        }
                        else
                        {
                            if (a!=0 && b!=0 && a!=b && a>0 && b<0 && a<0 && b > 0)
                            {
                                Console.WriteLine("El resultado de la ecuacion es una hiperbola");
                            }
                        }
                    }

                }
                   
            }
        }
    }
}
