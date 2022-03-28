using System;
using System.Collections;
using System.Collections.Generic;

namespace Listas
{
    internal class Program
    {
        private static readonly string[] colors = { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
        private static readonly string[] removeColors = { "RED", "WHITE", "BLUE" };
        static void Main(string[] args)
        {
            List<string> colores = new List<string>();
            List<string> removeColores = new List<string>();

            foreach (string color in colors)
            {
                colores.Add(color);
            }

            foreach (string removeColor in removeColors)
            {
                removeColores.Add(removeColor);
            }

            Console.WriteLine("Lista de colores original");
            foreach(string color in colores)
            {
                Console.Write(color + " ");
            }

            foreach(var color in removeColores)
            {
                colores.Remove(color);
            }

            Console.WriteLine("\nLista de colores luego de llamar a removeColors");
            foreach (string color in colores)
            {
                Console.Write(color + " ");
            }

            Console.ReadLine();
        }
    }
}
