using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RETO2_SEMANA11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] niveles = new int[5];
            int[] niños = new int[5];
            string[] encargado = new string[5];
            int suma = 0;
            int suma2 = 0;
            string nombre;
            string responsable = " ";
            int maspersonas = 0;
            int x = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese la cantidad de adultos en el nivel " + (i + 1));
                niveles[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("El numero de adultos en el nivel " + (i + 1) + " es de: " + niveles[i]);
                suma += niveles[i];
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese la cantidad de niños en el nivel " + (i + 1));
                niños[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("El numero de niños en el nivel " + (i + 1) + " es de: " + niños[i]);
                suma2 += niños[i];
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el nombre del encargado en el nivel " + (i + 1));
                encargado[i] = Console.ReadLine();
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("El nombre del encargado en el nivel " + (i + 1) + " es de: " + encargado[i]);
                nombre = encargado[i];
            }

            Console.WriteLine("La cantidad de adultos en el edificio es de: " + suma);
            Console.WriteLine("La cantidad de niños en el edificio es de: " + suma2);
            for (int i = 0; i < 5; i++)
            {
                if (x < niños[i])
                {
                    x = niños[i];

                    maspersonas = i;
                    responsable = encargado[i];
                }
            }
            Console.WriteLine("El nombre del responsable del nivel con más niños es: " + responsable);

            Console.ReadKey();
            //Reto 3 Semana 11 por Marcela Meléndez y Teresa Solares
        }
    }
}
