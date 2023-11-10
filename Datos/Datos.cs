using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciospracticos4_U2_EESA.Datos
{
    public class Datos
    {
                    //2 filas y 3 columnas
            int[,] t = { { 5, 6, 8 }, { 8, 7, 3 } };
        public void uno()
        {
            for (int i = 0; i < t.GetLength(0) + 1; i++)
            {
                Console.Write(t[0, i] + " ");
            }
            Console.WriteLine(" ");
        }
        public void dos()
        {
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for(int j = 0; j < t.GetLength(1); j++)
                {
                    Console.Write(t[i, j] + " ");
                }
            }
            Console.WriteLine(" ");
        }
        public void tres()
        {
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    t[i, j] = 0;
                    Console.Write(t[i, j] + " ");
                }
            }
            Console.WriteLine(" ");

        }
        public void cuatro()
        {
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    Console.Write("Ingrese el valor para la fila" + i + " y la columna " + j);
                    t[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
        }
        public void cinco()
        {
            int min = t[0, 0];
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    if (t[i, j] < min)
                    {
                        min = t[i, j];
                        Console.WriteLine($"El numero mas pequeño es: {min}");
                    }
                }
            }
            Console.WriteLine($"La primera fila del arreglo es: {t[0,0]}");
            Console.WriteLine($"La segunda fila del arreglo es: {t[0, 1]}");
            Console.WriteLine($"La tercera fila del arreglo es: {t[0, 2]}");
        }
        public void seis()
        {
            for (int i = 0; i < t.GetLength(1); i++)
            {
                Console.Write("    Columna " + i + ": ");
            }
            Console.WriteLine();
            for (int i = 0; i < t.GetLength(0); i++)
            {
                Console.Write("Fila " + i + ": ");
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    Console.Write("      "+t[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
