using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Top_10_Netflix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lineas = File.ReadAllLines("Especificar la ruta del archivo ratings.txt");
            List<Linea> lines = new List<Linea>();

            foreach (var linea in lineas)
            {
                var valores = linea.Split(',');
                lines.Add(new Linea(int.Parse(valores[0]), long.Parse(valores[1]), int.Parse(valores[2]), DateTime.Parse(valores[3])));
            }

            Console.WriteLine("Top 10 Users Reviewing Movies");
            foreach (var line in lines.GroupBy(el => el.id_usuario).OrderByDescending(el => el.Count()).Take(10))
            {
                Console.WriteLine("{0} : {1}", line.Key, line.Count());
            }
            Console.ReadKey();
        }
    }
}
