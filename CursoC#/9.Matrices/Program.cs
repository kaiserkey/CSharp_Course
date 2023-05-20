using System;
namespace _9.Matrices
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* matrices */
            int[,] matriz = new int[3, 3];
            Random random = new Random();

            for(int fila=0; fila<3; fila++)
            {
                for(int columna=0; columna<3; columna++){
                    matriz[fila, columna] = random.Next(1, 10);
                }
            }

            for(int fila=0; fila<3; fila++)
            {
                for(int columna=0; columna<3; columna++){
                    Console.Write(matriz[fila, columna]);
                }
                Console.WriteLine();
            }
        }
    }
}