using System;
using System.Globalization;
using System.Runtime.Serialization.Formatters;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opciones;

            do
            {
                Console.WriteLine("\nMenu de opciones:");
                Console.WriteLine("1. Calculo del factorial de un numero.");
                Console.WriteLine("2. Suma de numeros enteros hasta n.");
                Console.WriteLine("3. Calculo de la serie de Fibonacci.");
                Console.WriteLine("4. Declaracion y asignacion de un arreglo.");
                Console.WriteLine("5. Inicializacion de un arreglo en la declaracion.");
                Console.WriteLine("6. Arreglo de cadenas (string).");
                Console.WriteLine("7. salir");
                Console.WriteLine("\nIngrese una opcion: ");

                if (int.TryParse(Console.ReadLine(), out opciones))
                {
                    switch (opciones)
                    {
                        case 1:
                            int num = 6;
                            long resultado = Factorial(num);
                            Console.WriteLine($"El factorial de {num} es {resultado}");
                            break;

                        case 2:

                            int NumEnt = 5;
                            int ResultadoEn = SumaNumeros(NumEnt);
                            Console.WriteLine($"La suma de los numeros enteros desde 1 hasta {NumEnt} es {ResultadoEn}");
                            break;

                        case 3:
                            int NumFibo = 15;
                            for (int i = 0; i < NumFibo; i++)
                            {
                                Console.Write(Fibonacci(i) + " ");
                            }
                            break;

                        case 4:
                            int[] numeros = new int[5]; // DECLARACION DE UN ARREGLO DE ENTEROS CON 5 ELEMENTOS
                            numeros[0] = 10;
                            numeros[1] = 20;
                            numeros[2] = 30;
                            numeros[3] = 40;
                            numeros[4] = 50;

                            // ACCEDER A LOS ELEMENTOS DEL ARREGLO
                            Console.WriteLine("El primer elemento del arreglo es: " + numeros[0]);
                            Console.WriteLine("El segundo elemento del arreglo es: " + numeros[1]);
                            break;

                        case 5:
                            int[] numeross = { 10, 20, 30, 50 }; // INICIALIZACION DE UN ARREGLO DE ENTEROS  

                            // ACCEDER A LOS ELEMENTOS DEL ARREGLO
                            Console.WriteLine("El primer elemento del arreglo es: " + numeross[0]);
                            Console.WriteLine("El segundo elemento del arreglo es: " + numeross[1]);

                            break;

                        case 6:
                            string[] nombres = { "Juan", "Maria", "Carlos", "Ana"};
                            foreach (string nombre in nombres)
                            {
                                Console.WriteLine("Nombres: " + nombre);
                            }
                            break;

                        case 7:
                            Console.WriteLine("\nSaliendo del programa.....");
                        break;

                        default:
                            Console.WriteLine("\nOpcion no valida. Intente de nuevo");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("\nOpcion bo valida. Intente de nuevo");
                }

            } while (opciones != 7);

        }

        // INICIO FACTORIAL
        static int Factorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        // FIN FACTORIAL

        // INICIO SUMANUMEROS
        static int SumaNumeros(int n)
        {
            if (n <= 0)
                return 0;
            else
                return n + SumaNumeros(n - 1);
        }
        // FIN SUMA NUMEROS

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
// NOMBRE: PEDRO ANTONIO ALVAREZ HERNANDEZ
// CODIGO: U20230697