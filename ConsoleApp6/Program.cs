using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A continuación ingresa 10 números y se calculará cuales son pares");

            int[] Enteros = new int[10];

            for (int i =0; i<10; i++)
            {
               

                Console.WriteLine("ingresa el nº {0}", i + 1);

                Enteros[i]= Int32.Parse(Console.ReadLine());

               

            }

            for (int n=0; n<10; n++) { 
            
                
                if ( Enteros[n] % 2 == 0)
                {

                    Console.WriteLine("El número ingresado en la posición {0}º ({1}) es par",n + 1, Enteros[n]);

                }

            }

        }
    }
}
