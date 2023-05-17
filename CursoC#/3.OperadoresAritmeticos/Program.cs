
using System;
namespace _3.OperadoresAritmeticos
{
    class Program
    {
        public static void Main(string[] args)
        {
            //operadores aritmeticos
            //suma
            Console.WriteLine("Ingrese el valor de a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int suma = a + b;
            Console.WriteLine("La suma de a + b es: " + suma);

            //resta
            int resta = a - b;
            Console.WriteLine("La resta de a - b es: " + resta);

            //multiplicacion
            int multiplicacion = a * b;
            Console.WriteLine("La multiplicacion de a * b es: " + multiplicacion);

            //division
            int division = a / b;
            Console.WriteLine("La division de a / b es: " + division);

            //modulo
            int modulo = a % b;
            Console.WriteLine("El modulo de a % b es: " + modulo);

            //operadores de asignacion
            int c = 5;
            c += 3;
            Console.WriteLine("El valor de c es: " + c);

            //operadores de incremento y decremento
            int d = 5;
            d++;
            Console.WriteLine("El valor de d es: " + d);

            //operadores de comparacion
            int e = 5;
            int f = 3;
            bool comparacion = e == f;
            Console.WriteLine("El valor de comparacion es: " + comparacion);

            //operadores logicos
            bool g = true;
            bool h = false;
            bool i = g && h;
            Console.WriteLine("El valor de i es: " + i);

            //operadores de tipo
            int j = 5;
            float k = 3.5f;
            bool l = j is int;
            Console.WriteLine("El valor de l es: " + l);

            //operadores de bits
            int m = 5;
            int n = 3;
            int o = m & n;
            Console.WriteLine("El valor de o es: " + o);

            //operadores de desplazamiento
            int p = 5;
            int q = p << 2; // 101 << 2 = 10100 = 20
            Console.WriteLine("El valor de q es: " + q);

            //operadores de igualdad
            int r = 5;
            int s = 3;
            bool t = r == s;
            Console.WriteLine("El valor de t es: " + t);

            //operadores de desigualdad
            int u = 5;
            int v = 3;
            bool w = u != v;
            Console.WriteLine("El valor de w es: " + w);

            //operadores de comparacion
            int x = 5;
            int y = 3;
            bool z = x > y;
            Console.WriteLine("El valor de z es: " + z);

            //operadores de comparacion
            int aa = 5;
            int bb = 3;
            bool cc = aa < bb;
            Console.WriteLine("El valor de cc es: " + cc);

            //operadores de comparacion
            int dd = 5;
            int ee = 3;
            bool ff = dd >= ee;
            Console.WriteLine("El valor de ff es: " + ff);

            //operadores de comparacion
            int gg = 5;
            int hh = 3;
            bool ii = gg <= hh;
            Console.WriteLine("El valor de ii es: " + ii);

            //operadores de igualdad
            int jj = 5;
            int kk = 3;
            bool ll = jj == kk;
            Console.WriteLine("El valor de ll es: " + ll);

            //potencia de un numero
            double mm = Math.Pow(5, 3);
            Console.WriteLine("El valor de mm es: " + mm);

            //raiz cuadrada de un numero
            double nn = Math.Sqrt(25);
            Console.WriteLine("El valor de nn es: " + nn);

            //valor absoluto de un numero
            double oo = Math.Abs(-5);
            Console.WriteLine("El valor de oo es: " + oo);

            //redondear un numero
            double pp = Math.Round(5.3);
            Console.WriteLine("El valor de pp es: " + pp);

            //maximo de dos numeros
            double qq = Math.Max(5, 3);
            Console.WriteLine("El valor de qq es: " + qq);

            //minimo de dos numeros
            double rr = Math.Min(5, 3);
            Console.WriteLine("El valor de rr es: " + rr);

            //constante de pi
            double ss = Math.PI;
            Console.WriteLine("El valor de ss es: " + ss);

            //constante de euler
            double tt = Math.E;
            Console.WriteLine("El valor de tt es: " + tt);

            //logaritmo natural de un numero
            double uu = Math.Log(5);
            Console.WriteLine("El valor de uu es: " + uu);

            //logaritmo en base 10 de un numero
            double vv = Math.Log10(5);
            Console.WriteLine("El valor de vv es: " + vv);

            //seno de un numero
            double ww = Math.Sin(5);
            Console.WriteLine("El valor de ww es: " + ww);

            //coseno de un numero
            double xx = Math.Cos(5);
            Console.WriteLine("El valor de xx es: " + xx);

            //tangente de un numero
            double yy = Math.Tan(5);
            Console.WriteLine("El valor de yy es: " + yy);

            //arco seno de un numero
            double zz = Math.Asin(5);
            Console.WriteLine("El valor de zz es: " + zz);

            //arco coseno de un numero
            double aaa = Math.Acos(5);
            Console.WriteLine("El valor de aaa es: " + aaa);

            //arco tangente de un numero
            double bbb = Math.Atan(5);
            Console.WriteLine("El valor de bbb es: " + bbb);

            //arco tangente de un numero
            double ccc = Math.Atan2(5, 3);
            Console.WriteLine("El valor de ccc es: " + ccc);

            //convertir de radianes a grados
            double ddd = Math.Atan(5);
            double eee = ddd * (180 / Math.PI);
            Console.WriteLine("El valor de eee es: " + eee);

            //convertir de grados a radianes
            double fff = 5;
            double ggg = fff * (Math.PI / 180);
            Console.WriteLine("El valor de ggg es: " + ggg);

            


        }
    }
}
