using System;
using System.Collections.Generic;
using System.Linq;

namespace Contador_de_Palabras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            Console.WriteLine("Ingrese un párrafo: ");
            string[] palabras = Console.ReadLine().Split(' ');

            int contador = 0;
            foreach (string palabra in palabras)
            {
                string palabraActual = palabra;
                foreach (string word in palabras)
                {
                    if (palabraActual.Equals(word))
                    {
                        contador++;
                    }
                }
                if (diccionario.Count == 0)
                {
                    diccionario.Add(palabraActual, contador);
                    contador = 0;
                }
                else
                {
                    bool repetido = false;
                    for (int i = 0; i < diccionario.Count; i++)
                    {
                        if (diccionario.ElementAt(i).Key.Equals(palabraActual) && diccionario.ElementAt(i).Value.Equals(contador))
                        {
                            repetido = true;
                            break;
                        }
                    }
                    if (repetido == false)
                    {
                        diccionario.Add(palabraActual, contador);
                    }
                }
                contador = 0;
            }
            Console.WriteLine("\nContenido del diccionario: ");
            Console.WriteLine("KEY\t\tVALUE");
            foreach (KeyValuePair<string, int> elemento in diccionario)
            {
                Console.WriteLine(elemento.Key + "\t\t" + elemento.Value);
                contador++;
            }
            Console.WriteLine("\nTotal de palabras sin repetir: " + contador);
            Console.ReadKey();
        }
    }
}
