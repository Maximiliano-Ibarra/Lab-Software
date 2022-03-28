using System;
using System.Collections.Generic;

namespace Diccionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> values = new Dictionary<String, String>();
            values.Add("Juan", "55423412");
            values.Add("Ernesto", "56985623");
            values.Add("Mariana", "54787451");

            if (values.ContainsKey("Juan"))
                Console.WriteLine(values.GetValueOrDefault("Juan"));
            else
                Console.WriteLine("No contiene la llave");

            if (values.TryGetValue("Pedro", out String itemValue))
                Console.WriteLine(itemValue);
            else
                Console.WriteLine("No se encontró la llave");

            foreach (KeyValuePair<String, String> elem in values)
            {
                Console.WriteLine("{0}, {1}", elem.Key, elem.Value);
            }

            if (values.ContainsKey("Mariana"))
                values["Mariana"] = "58251425";

            Console.WriteLine("Nuevo teléfono de Mariana: " + values["Mariana"]);

            Console.ReadLine();
        }
    }
}
