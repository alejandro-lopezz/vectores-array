using System;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio1
            /* int[] numeros = new int[10];
            int n; 

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
                numeros[x] = n;
            }

            int max = 0;
            int posMax = 0;
            for (int x = 0; x < 10; x++)
            {
                if(numeros[x] > max) {
                    max = numeros[x];
                    posMax = x + 1;
                }
            }

            Console.WriteLine("El número maximo es: " + max + " y su posición fue: " + posMax); */


            //ejercicio2
            /* int[] numeros = new int[10];
            int n;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());

                numeros[x] = n;
            }

            int promedio;
            int acu = 0;

            for (int x = 0; x < 10; x++)
            {
                acu += numeros[x];
            }

            promedio = acu / 10;
            Console.WriteLine("El promedio es: " + promedio);

            for (int x = 0; x < 10; x++)
            {
                if(numeros[x] > promedio) {
                    Console.WriteLine("El número " + numeros[x] + " es mayor al promedio");
                }
            } */


            //ejercicio3
            /* char[] cadena = new char[50];
            char letra;
            int indice = 0;

            Console.WriteLine("Ingrese su frase letra por letra que corta con un punto");
            letra = char.Parse(Console.ReadLine());

            while(letra != '.' && indice < 50)
            {
                cadena[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
            }

            cadena[indice] = '\0';

            char letraReemplazada;
            Console.WriteLine("Ingrese la letra que sera reemplazada: ");
            letraReemplazada = char.Parse(Console.ReadLine());

            char letraQueReemplaza;
            Console.WriteLine("Ingrese la letra por la que sera reemplazada la anterior: ");
            letraQueReemplaza = char.Parse(Console.ReadLine());

            for (int x = 0; x < 50; x++)
            {
                if(cadena[x] == letraReemplazada){
                    cadena[x] = letraQueReemplaza;
                }
            }

            indice = 0;
            while(cadena[indice] != '\0') {
                Console.Write(cadena[indice]);
                indice++;
            } */

            //Lo mismo pero de manera resumida xd
            /* string frase;
            char letraActual;
            char letraNueva;

            Console.WriteLine("Ingrese su frase: ");
            frase = Console.ReadLine();

            Console.WriteLine("Ingrese la letra a reemplazar: ");
            letraActual = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la letra nueva: ");
            letraNueva = char.Parse(Console.ReadLine());

            frase = frase.Replace(letraActual, letraNueva);

            Console.WriteLine("La frase nueva es: " + frase); */

            //ejercicio4

            int numeroArticulo;
            int cantidadVendida;
            int[] acu = new int[15];

            for (int x = 0; x < 15; x++)
            {
                acu[x] = 0;
            }

            Console.WriteLine("Ingrese el articulo: ");
            numeroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidadVendida = int.Parse(Console.ReadLine());

            while (numeroArticulo != 0)
            {
                
                acu[numeroArticulo - 1] += cantidadVendida;

                Console.WriteLine("Ingrese el articulo: ");
                numeroArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad vendida: ");
                cantidadVendida = int.Parse(Console.ReadLine());
            }

            //puntoC
            Console.WriteLine("La cantidad vendida del articulo 10 fue: " + acu[9]);

            //puntoB
            int numeroArticuloSinVentas = 0;
            for (int x = 0; x < 15; x++)
            {
                if(acu[x] == 0) {
                    numeroArticuloSinVentas = x + 1;
                    Console.WriteLine("Número de articulo donde no hubo ventas: " + numeroArticuloSinVentas);
                }
            }

            //punto A
            int max = 0;
            int articuloMaximo = 0;
            for (int x = 0; x < 15; x++)
            {
                if(acu[x] > max) {
                    max = acu[x];
                    articuloMaximo = x + 1;
                }
            }

            Console.WriteLine("El articulo que mas se vendio fue el: " + articuloMaximo + " con un total de: " + max);



        }
    }
}
