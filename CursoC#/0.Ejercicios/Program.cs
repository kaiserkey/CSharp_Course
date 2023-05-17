using System;
namespace _0.Ejercicios
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            /* 
            a. Implementa tu programa en un proyecto de consola llamado calculadora.cs.
            b. Tu programa pedirá al usuario dos números y los almacenará en las siguientes variables num1 y num2.
            c. Tu programa puede recibir números enteros y decimales.
            d. Tu programa deberá imprimir solo la operación que el usuario escriba en la consola. 
            */

            Console.Write("Ingrese el primer numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("+ -> Suma");
            Console.WriteLine("- -> Resta");
            Console.WriteLine("* -> Multiplicacion");
            Console.WriteLine("/ -> Division");

            Console.Write("Ingrese el signo de la operacion a realizar:");
            string operacion = Console.ReadLine();
            
            switch (operacion)
            {
                case "+":
                    Console.WriteLine("La suma de {0} y {1} es: {2}", num1, num2, num1 + num2);
                    break;
                case "-":
                    Console.WriteLine("La resta de {0} y {1} es: {2}", num1, num2, num1 - num2);
                    break;
                case "*":
                    Console.WriteLine("La multiplicacion de {0} y {1} es: {2}", num1, num2, num1 * num2);
                    break;
                case "/":
                    Console.WriteLine("La division de {0} y {1} es: {2}", num1, num2, num1 / num2);
                    break;
                default:
                    Console.WriteLine("La operacion ingresada no es valida!");
                    break;
            }


        }
    }
}
