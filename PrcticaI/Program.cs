using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int cantidadPersonas = 0;

        // Listas generales
        List<string> nombres = new List<string>();
        List<int> edades = new List<int>();

        // Validar cantidad de personas
        while (true)
        {
            Console.Write("Ingrese la cantidad de personas a registrar: ");
            if (int.TryParse(Console.ReadLine(), out cantidadPersonas) && cantidadPersonas >= 1)
            {
                break;
            }
            Console.WriteLine("⚠️ Valor inválido. Ingrese un número mayor o igual a 1.");
        }

        // Captura de datos
        for (int i = 0; i < cantidadPersonas; i++)
        {
            Console.WriteLine($"\nPersona #{i + 1}");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            nombres.Add(nombre);

            int edad;
            while (true)
            {
                Console.Write("Edad: ");
                if (int.TryParse(Console.ReadLine(), out edad) && edad >= 0)
                {
                    edades.Add(edad);
                    break;
                }
                Console.WriteLine("⚠️ Edad inválida. Ingrese un número válido.");
            }
        }

        // Caso especial: solo una persona
        if (cantidadPersonas == 1)
        {
            Console.WriteLine("\n--- Resultado ---");
            Console.WriteLine($"Nombre: {nombres[0]}");
            Console.WriteLine($"Edad: {edades[0]}");

            if (edades[0] >= 18)
                Console.WriteLine("Es MAYOR de edad.");
            else
                Console.WriteLine("Es MENOR de edad.");

            return;
        }

        // Caso general: dos o más personas
        Console.WriteLine("\n--- Lista General ---");
        for (int i = 0; i < cantidadPersonas; i++)
        {
            Console.WriteLine($"{nombres[i]} - {edades[i]} años");
        }

        // Clasificación
        List<string> mayores = new List<string>();
        List<string> menores = new List<string>();

        for (int i = 0; i < cantidadPersonas; i++)
        {
            if (edades[i] >= 18)
                mayores.Add($"{nombres[i]} - {edades[i]} años");
            else
                menores.Add($"{nombres[i]} - {edades[i]} años");
        }

        // Mostrar listados finales
        if (mayores.Count > 0)
        {
            Console.WriteLine("\n--- Personas MAYORES de edad ---");
            foreach (string persona in mayores)
            {
                Console.WriteLine(persona);
            }
        }

        if (menores.Count > 0)
        {
            Console.WriteLine("\n--- Personas MENORES de edad ---");
            foreach (string persona in menores)
            {
                Console.WriteLine(persona);
            }
        }
    }
}
